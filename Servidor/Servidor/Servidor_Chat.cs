using System;
using System.Collections.Generic;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using Cliente;
using System.Linq;
using System.Net.NetworkInformation;

namespace Servidor
{
    public partial class Servidor_Chat : Form
    {
        //variables para la conexión y el chat
        private TcpListener server;
        private TcpClient client = new TcpClient();
        private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 8000);
        private Dictionary<string, List<Connection>> chats = new Dictionary<string, List<Connection>>();
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        public static OleDbConnection miconexion;

        public static ListBox MyListBox { get; set; }

        Connection con;
        private static readonly byte[] encryptionKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\\datos\\BDatos.accdb";


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

        // Metodo para desencriptar
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

        // Estructura para guardar información sobre la conexión
        private struct Connection
        {
            public NetworkStream stream;
            public StreamWriter streamw;
            public StreamReader streamr;
            public string nick;
            public string chatName;
            public string clientIP;
        }

        public Servidor_Chat()
        {
            InitializeComponent();
            Thread serverThread = new Thread(Start);
            serverThread.IsBackground = true;
            serverThread.Start();
            MyListBox = listBox1;
        }

        // Método para iniciar el servidor
        public void Start()
        {
            DateTime now = DateTime.Now;
            AddMessage("["+ now + "]   Servidor Activado!");
            server = new TcpListener(ipendpoint);
            server.Start();

            // Bucle para aceptar conexiones entrantes
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {

                try {
                // Acepta la conexion entrante de un cliente
                client = server.AcceptTcpClient();
                } catch (Exception)
                {
                    client.Close();
                }

                // Inicializa un nuevo objeto de conexión
                try { 
                con = new Connection();
                con.stream = client.GetStream();
                con.streamr = new StreamReader(con.stream);
                con.streamw = new StreamWriter(con.stream);
                

                //Desencripta los datos recibidos por el cliente
                con.nick = DecryptString(con.streamr.ReadLine(), encryptionKey);
                string password = DecryptString(con.streamr.ReadLine(), encryptionKey);
                con.chatName = DecryptString(con.streamr.ReadLine(), encryptionKey);

                string clientIP = con.streamr.ReadLine();
                con.clientIP = clientIP;


                // Verifica las credenciales
                if (!CheckCredentials(con.nick, password))
                {
                    con.streamw.WriteLine("INVALIDCREDENTIALS");
                    con.streamw.Flush();
                    client.Close();
                    continue;
                }

                // Envia respuesta "CONNECTED" cuando las credenciales son válidas
                con.streamw.WriteLine("CONNECTED");
                con.streamw.Flush();

                if (!chats.ContainsKey(con.chatName))
                {
                    chats[con.chatName] = new List<Connection>();
                }

                chats[con.chatName].Add(con);

                AddMessage($"{clientIP} [{now}]  {con.nick} se ha conectado al chat {con.chatName}");

                //Inicia un nuevo hilo
                Thread t = new Thread(Listen_connection);
                t.Start();
                }
                catch { }
            }
        }

        // Método para escuchar conexiones entrantes
        void Listen_connection()
        {
            Connection hcon = con;

            // Envia la lista de usuarios actualizada a todos los clientes cuando un nuevo usuario se conecta
            string userListUpdate = "USERLIST ";
            foreach (Connection c in chats[hcon.chatName])
            {
                userListUpdate += c.nick + ",";
            }
            userListUpdate = userListUpdate.TrimEnd(',');

            string userConnectedMessage = $"USERCONNECTED {hcon.nick} {DateTime.Now.ToString("HH:mm:ss")}";

            foreach (Connection c in chats[hcon.chatName])
            {
                    c.streamw.WriteLine(userListUpdate);
                    c.streamw.WriteLine(userConnectedMessage);
                    c.streamw.Flush();
            }

            do
            {
                try
                {
                    string tmp = hcon.streamr.ReadLine();

                    if (string.IsNullOrEmpty(tmp))
                    {
                        break;
                    }

                    if (tmp.StartsWith("USERLIST"))
                    {
                        string userList = "USERLIST ";
                        foreach (Connection c in chats[hcon.chatName])
                        {
                            userList += c.nick + ",";
                        }
                        userList = userList.TrimEnd(',');
                        hcon.streamw.WriteLine(userList);
                        hcon.streamw.Flush();
                    }
                    else
                    {
                        DateTime now = DateTime.Now; //Obtiene la hora y fecha actual
                        // Muestra en el log la dirección IP del cliente, la fecha y hora, y el mensaje enviado
                        string decryptedMessage = DecryptString(tmp, encryptionKey);
                        AddMessage($"{hcon.clientIP} [{now}]  {hcon.nick} en chat {hcon.chatName}: {decryptedMessage}");
                        string encryptedMessage1 = EncryptString($"{hcon.clientIP} [{now}]  {hcon.nick} en chat {hcon.chatName}: {tmp}", encryptionKey);


                        foreach (Connection c in chats[hcon.chatName])
                        {
                            try
                            {
                                // Encripta el mensaje antes de enviarlo al cliente
                                c.streamw.WriteLine(EncryptString($"{now} >>  {hcon.nick}: {decryptedMessage}", encryptionKey));
                                c.streamw.Flush();
                            }
                            catch
                            {
                            }
                        }}}
                catch
                {
                    break;
                }
            } while (true);
            try { 
            chats[hcon.chatName].Remove(hcon);
            } catch { }
            // Envia la lista de usuarios actualizada a todos los clientes cuando un usuario se desconecta
            userListUpdate = "USERLIST ";
            foreach (Connection c in chats[hcon.chatName])
            {
                userListUpdate += c.nick + ",";
            }
            userListUpdate = userListUpdate.TrimEnd(',');

            foreach (Connection c in chats[hcon.chatName])
            {
                try
                {
                    c.streamw.WriteLine(userListUpdate);
                    c.streamw.Flush();
                }
                catch { }
            }

            // Muestra en el log la dirección IP del cliente y la fecha y hora de la desconexión
            AddMessage($"{hcon.clientIP} [{DateTime.Now}]  {hcon.nick} se ha desconectado del chat {hcon.chatName}");
            string encryptedMessage2 = EncryptString($"{hcon.clientIP} [{DateTime.Now}]  {hcon.nick} se ha desconectado del chat {hcon.chatName}", encryptionKey);
        }

        // Método para agregar un mensaje al listBox1
        public void AddMessage(string message)
        {
            try {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() => listBox1.Items.Add(message)));
            }
            else
            {
                listBox1.Items.Add(message);
            }
            } catch { }

            // Ruta del archivo de texto
            string filePath = ".\\datos\\Registro.txt";

            try
            {
                // Abre o crea el archivo en modo de escritura, con la opción de anexar al final
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Escribe el mensaje en el archivo
                    writer.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el archivo: " + ex.Message);
            }
        }

        // Método para verificar las credenciales de un usuario
        private bool CheckCredentials(string username, string password)
        {
            bool isValid = false;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM usuarios WHERE nick = @username AND contra = @password", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isValid = true;
                    }
                }
            }

            return isValid;
        }

        // Método para obtener la dirección IP local
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

        // Método que se ejecuta cuando se carga el formulario Servidor_Chat
        private void Servidor_Chat_Load(object sender, EventArgs e)
        {
            string ipAddress = GetLocalIPAddress();
            txtIP.Text = ipAddress;

            miconexion = new OleDbConnection(connectionString);
            miconexion.Open();
        
        
        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {
            fmUsers usuarios = new fmUsers();
            usuarios.ShowDialog();
        }

        private void Servidor_Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar el Servidor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                DateTime now = DateTime.Now;
                WriteMessageToFile("[" + now + "]   Servidor Desactivado!");
                // Cancela el token para detener el ciclo de escucha del servidor
                cancellationTokenSource.Cancel();

                // Detiene el servidor
                server.Stop();

                // Cierra todas las conexiones de los clientes
                foreach (var chat in chats.Values)
                {
                    foreach (Connection connection in chat)
                    {
                        connection.streamw.Close();
                        connection.streamr.Close();
                        connection.stream.Close();
                    }
                }
            }


            miconexion.Close(); //cierra la conexión
        }

        //Método para añadir datos al archivo txt
        private void WriteMessageToFile(string message)
        {
            // Ruta del archivo de texto
            string filePath = ".\\datos\\Registro.txt";

            try
            {
                // Abre o crea el archivo en modo de escritura, con la opción de anexar al final
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Escribe el mensaje en el archivo
                    writer.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al escribir en el archivo: " + ex.Message);
            }
        }

        private void tsAcercaDe_Click(object sender, EventArgs e)
        {
            fmAcercade acerca = new fmAcercade();
            acerca.ShowDialog();
        }

        private void tsTerms_Click(object sender, EventArgs e)
        {
           TermsConditions termsConditions = new TermsConditions();
           termsConditions.Show();
        }

        private void tsPolicy_Click(object sender, EventArgs e)
        {
            PrivacyPolicy policy = new PrivacyPolicy();
            policy.Show();
        }

        private void tsCopyRight_Click(object sender, EventArgs e)
        {
            CopyRight copyright = new CopyRight();
            copyright.Show();
        }

        private void tsEvents_Click(object sender, EventArgs e)
        {
            Events events = new Events();
            events.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            fmUsers users = new fmUsers();
            users.Show();
        }
    }
}

