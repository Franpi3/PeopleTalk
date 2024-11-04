using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Servidor;

namespace Cliente
{
    public partial class Cliente : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknown";
        static private string chatName = "default";
        static private string password = "";

        // Delegados para manejar la actualización de la UI desde otros hilos
        private delegate void DaddItem(String s);
        private delegate void DupdateUserList(List<string> userList);

        private static readonly byte[] encryptionKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");

        // Metodo para encriptar
        public static string EncryptString(string plainText, byte[] key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }

                    byte[] encryptedBytes = memoryStream.ToArray();
                    byte[] resultBytes = new byte[aes.IV.Length + encryptedBytes.Length];
                    Buffer.BlockCopy(aes.IV, 0, resultBytes, 0, aes.IV.Length);
                    Buffer.BlockCopy(encryptedBytes, 0, resultBytes, aes.IV.Length, encryptedBytes.Length);

                    return Convert.ToBase64String(resultBytes);
                }
            }
        }

        //Metodo para desencriptar
        public static string DecryptString(string encryptedText, byte[] key)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;

                using (MemoryStream memoryStream = new MemoryStream(encryptedBytes))
                {
                    byte[] iv = new byte[aes.IV.Length];
                    memoryStream.Read(iv, 0, iv.Length);

                    aes.IV = iv;

                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (StreamReader streamReader = new StreamReader(cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }

        // Metodo para agregar elementos a los listBox
        private void AddItem(String s)
        {
            listBox1.Items.Add(s);
        }


        // Metodo para actualizar la lista de usuarios en el listBox de usuarios
        private void UpdateUserList(List<string> userList)
        {
            lbUsuarios.Items.Clear();
            foreach (string user in userList)
            {
                lbUsuarios.Items.Add(user);
            }
        }

        public Cliente()
        {
            InitializeComponent();
        }

        // Metodo para solicitar la lista de usuarios al servidor
        void RequestUserList()
        {
            if (client.Connected)
            {
                streamw.WriteLine("USERLIST");
                streamw.Flush();
            }
        }

        // Metodo para escuchar los mensajes del servidor
        void Listen()
        {
            try
            {
                while (client.Connected)
            {
                    string receivedData = streamr.ReadLine();

                    if (receivedData.StartsWith("USERLIST"))
                    {
                        List<string> userList = new List<string>(receivedData.Substring(9).Split(','));
                        this.Invoke(new DupdateUserList(UpdateUserList), userList);
                    }
                    else if (receivedData.StartsWith("USERCONNECTED"))
                    {
                        DateTime now = DateTime.Now;
                        string[] messageParts = receivedData.Split(' ');
                        string userConnected = messageParts[1];
                        string connectionTime = messageParts[2];
                        this.Invoke(new DaddItem(AddItem), $"{now} >>  {userConnected} se ha unido al grupo.");
                    }
                    else
                    {
                        string decryptedMessage = DecryptString(receivedData, encryptionKey);
                        this.Invoke(new DaddItem(AddItem), decryptedMessage);
                    }
                }
        }
        catch
                {
                try {
                Info.Text = "";
                client.Close();
                panelChatear.Visible = true;
                listBox1.Items.Clear();
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
                ckCondiciones.Checked = false;
                } catch
                { }
            }
        }

        // Metodo para conectar al servidor
        void Connect()
        {
            string localIP = GetLocalIPAddress();

            try
            {
                client = new TcpClient(); // crea una nueva instancia de TcpClient antes de intentar conectarse
                client.Connect(txtIP.Text, 8000);
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);

                    string encryptedNick = EncryptString(nick, encryptionKey);
                    string encryptedPassword = EncryptString(password, encryptionKey);
                    string encryptedChatName = EncryptString(chatName, encryptionKey);

                    // Envia las variables encriptadas al servidor
                    streamw.WriteLine(encryptedNick);
                    streamw.WriteLine(encryptedPassword);
                    streamw.WriteLine(encryptedChatName);
                    streamw.WriteLine(localIP);
                    streamw.Flush();

                    string response = streamr.ReadLine();
                    if (response == "INVALIDCREDENTIALS")
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                        client.Close();
                        return;
                    }

                    // condición si el nick y la contraseña son correctos
                    if (response == "CONNECTED")
                    {
                        Info.Text = $"{nick} en chat ({chatName})";
                        panelChatear.Visible = false;
                    }

                    RequestUserList(); // Solicita la lista de usuarios
                    t.Start();
                }

                else
                {
                    MessageBox.Show("Servidor no Disponible");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Servidor no Disponible");
                //Application.Exit();
            }
        }

        // Evento de clic en el botón "btnConectar"
        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Verificar si el checkbox "ckCondiciones" está marcado
            if (ckCondiciones.Checked)
            {
                // Si está marcado, continúa con el resto del código
                nick = txtUsuario.Text;
                chatName = txtChatName.Text;
                password = txtPassword.Text;
                Connect();
                txtMensaje.Focus();
            }
            else
            {
                // Si no está marcado, muestra un mensaje de advertencia
                MessageBox.Show("Debes aceptar los Términos & Condiciones para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Evento de clic en el botón "btnEnviar"
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un mensaje.", "Mensaje vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string encryptedMessage = EncryptString(txtMensaje.Text, encryptionKey);
                streamw.WriteLine(encryptedMessage);
                streamw.Flush();
                txtMensaje.Clear();
                txtMensaje.Focus();
            }
        }

        // Evento al abrir formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        // Evento al cerrar del formulario
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        // Evento al pulsar la tecla en el campo "txtMensaje"
        private void txtMensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Para evitar el sonido del "beep" al presionar Enter
                btnEnviar.PerformClick(); // Activa el botón "btnEnviar"
            }
        }

        // Metodo para obtener la dirección IP local
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    byte[] addrBytes = ip.GetAddressBytes();
                    if (addrBytes[0] == 10 ||
                        (addrBytes[0] == 172 && addrBytes[1] >= 16 && addrBytes[1] <= 31) ||
                        (addrBytes[0] == 192 && addrBytes[1] == 168))
                    {
                        return ip.ToString();
                    }
                }
            }
            throw new Exception("No se ha encontrado la red!");
        }

        // Evento de clic en el botón "btnDesconectar"
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro desea desconectar?", "Confirmar Desconexión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Realiza la desconexión
                Info.Text = "";
                client.Close();
                panelChatear.Visible = true;
                listBox1.Items.Clear();
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
                ckCondiciones.Checked = false;
            }
            
        }

        // Evento de clic en el menú "acerdaDeToolStripMenuItem"
        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAcercade acerca = new fmAcercade();
            acerca.ShowDialog();
        }

        private void TermsConditions_Click(object sender, EventArgs e)
        {
            TermsConditions terms = new TermsConditions();
            terms.Show();
        }

        private void tsPolicy_Click(object sender, EventArgs e)
        {
            PrivacyPolicy privacyPolicy = new PrivacyPolicy();
            privacyPolicy.Show();
        }

        private void tsCopyRight_Click(object sender, EventArgs e)
        {
            CopyRight copyright = new CopyRight();
            copyright.Show();
        }

    }
}

