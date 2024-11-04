using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class fmUsers : Form
    {
        DataTable tabla; // Guarda el resultado de la ejecución de una sentencia SQL
        DataRow fila; // Guarda la fila de una tabla

        DateTime now = DateTime.Now;


        public fmUsers()
        {
            InitializeComponent();
        }

        private void fmUsuarios_Load(object sender, EventArgs e)
        {
            limpiartextbox();// Al iniciar limpia los textbox
            //carga los combobox de ciudades con los datos de las tablas
            llenaCombo("ciudades");
            llenaCombo("delegaciones"); 
            llenaCombo("paises");
            llenaCombo("sedes");
            cargardatoslisbox(); //carga los nombres de los usuarios en el listbox
            cambiaventana(true); //Habilita botones, listbox, etc que corresponda
        }

        private void cambiaventana(bool modo) //parámetro que recibe true o false
        { 
            //Con esto se cambia estilo de la ventana a edición o no en los botones,el listbox los textbox, etc. correspondientes.
            lbUsuarios.Enabled = modo;
            pNuevoModificarEliminar.Enabled = modo;
            btGuardar.Enabled = !modo;
            btActualizar.Enabled = !modo;
            btCancelar.Enabled = !modo;
            texboxsololectura(modo); //otra función para los textbox y combobox
        }

        private bool camposrequeridos() 
        {
            ////Los campos obligatorios tienen un * comprueba si los datos obligatorios han sido introducidos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Falta Nombre");
                tbNombre.Focus();
                return false; //devuelve false si falta el nombre
            }
            else if (tbDNI.Text == "")
            {
                MessageBox.Show("Falta DNI");
                tbDNI.Focus();
                return false; //devuelve false si falta el DNI
            }
            else if (tbFecha.Text == "")
            {
                MessageBox.Show("Falta Fecha de Nacimiento");
                tbFecha.Focus();
                return false; //devuelve false si falta la fecha
            }
            else if (tbPais.Text == "")
            {
                MessageBox.Show("Falta País");
                tbPais.Focus();
                return false; //devuelve false si falta el país
            }
            else if (cbCiudad.Text == "")
            {
                MessageBox.Show("Falta Ciudad");
                cbCiudad.Focus();
                return false; //devuelve false si falta la ciudad
            }
            else if (cbDelegacion.Text == "")
            {
                MessageBox.Show("Falta Delegación");
                cbDelegacion.Focus();
                return false; //devuelve false si falta la delegación
            }
            else if (cbSede.Text == "")
            {
                MessageBox.Show("Falta Sede");
                cbSede.Focus();
                return false; //devuelve false si falta la sede
            }
            else if (tbNick.Text == "")
            {
                MessageBox.Show("Falta Nick");
                tbNick.Focus();
                return false; //devuelve false si falta el nick
            }
            else if (tbContrasenya.Text == "")
            {
                MessageBox.Show("Falta Contraseña");
                tbContrasenya.Focus();
                return false; //devuelve false si falta la contraseña
            }

            return true; // devuelve true porque todo está correcto
        }

        private void limpiartextbox()
        {
            // Limpia los textbox
            foreach (Control controlSecundario in pDatos.Controls)
            {
                if (controlSecundario is ComboBox)
                {
                    ((ComboBox)controlSecundario).Text = "";
                }
                else if (controlSecundario is TextBox)
                {
                    ((TextBox)controlSecundario).Clear();
                }
            }
            // También borra contenido del DatePicker (asumiendo que se llama tbFecha)
            tbFecha.Text = "";
        }

        private void texboxsololectura(bool modo)
        {
            foreach (Control controlSecundario in pDatos.Controls) // Cambia la referencia al Panel pDatos
            {
                if (controlSecundario is ComboBox) // Cambia la propiedad a los ComboBox según se indique en el parámetro recibido
                {
                    ((ComboBox)controlSecundario).Enabled = !modo; // Habilita o deshabilita los ComboBox
                }
                if ((controlSecundario is TextBox) && (controlSecundario.Name == "tbNombre" 
                    || controlSecundario.Name == "tbDNI" 
                    || controlSecundario.Name == "tbObservaciones" 
                    || controlSecundario.Name == "tbNick" 
                    || controlSecundario.Name == "tbContrasenya"
                    || controlSecundario.Name == "tbCodigo")) // Cambia solo los TextBox indicados, el resto están siempre como solo lectura
                {
                    ((TextBox)controlSecundario).Enabled = !modo; // Habilita o deshabilita los TextBox
                }
            }
            // El DatePicker no tiene ReadOnly, solo Enabled
            tbFecha.Enabled = !modo; // Habilita o deshabilita el DatePicker
            pbOjo.Enabled = !modo; // Habilita o deshabilita el PictureBox
        }

        private void cargardatoslisbox()
        { 
            //Llena listbox con el título desde tabla usuarios
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM usuarios", Servidor_Chat.miconexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            tabla = new DataTable();
            tabla = ds.Tables[0];
            lbUsuarios.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                fila = tabla.Rows[i];
                lbUsuarios.Items.Add(fila["NombreCompleto"].ToString());
            }
        }

        public void llenaCombo(string latabla)
        {
            // función compartida para llenar los
            // combobox correspondientes con datos de las tablas delegaciones, paises,
            // ciudades y librerías, recibida como parámetro
            String consulta = "SELECT nombre FROM " + latabla;
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, Servidor_Chat.miconexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            DataTable tabla = new DataTable();
            tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                switch (latabla) // Extrae todas las filas de la tabla recibida como parámetro
                {
                    case "sedes": //Añade dato nombre al comboBox correspondiente
                        cbSede.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                    case "ciudades":
                        cbCiudad.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                    case "delegaciones":
                        cbDelegacion.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                    case "paises":
                        cbPais.Items.Add(tabla.Rows[i]["nombre"]);
                        break;
                }
            }
        }

        string ponernombre(string latabla, string clave, string parametro)
        {
            // parámetros: nombre tabla, clave tabla, valor de la clave para SQl
            // desde el dato código/clave puesto en el textbox correspondiente y
            // recibido como parámetro devuelvo el nombre que me da la sentencia SQL
            string sentenciasql = "SELECT nombre FROM " + latabla + " where " +
            clave + " = @micod";
            OleDbCommand comando = new OleDbCommand(sentenciasql,
            Servidor_Chat.miconexion);
            comando.Parameters.AddWithValue("@micod", parametro);
            OleDbDataReader lector = comando.ExecuteReader(); // Ejecuta consulta
            if (lector.Read()) //SELECT y devuelve un objeto DataReader.
            {
                return lector["nombre"].ToString();
            }
            else
            {
                return "";
            }
        }

        public string poncodigo(string latabla, string elcodigo, string elitem)
        {
            // La función es compartida para poner código de las 4 tablas
            // con el dato recibido del ítem seleccionado del combobox
            // correspondiente devuelvo código
            string sentenciasql = "SELECT " + elcodigo + " FROM " + latabla + " WHERE nombre = @micod";
            OleDbCommand comando5 = new OleDbCommand(sentenciasql, Servidor_Chat.miconexion);
            string mid = elitem;
            comando5.Parameters.AddWithValue("@midcod", mid);
            OleDbDataReader lector = comando5.ExecuteReader(); // Ejecuta consulta
            if (lector.Read()) // SELECT y en un objeto DataReader.
            {
                return lector[elcodigo].ToString();// Devuelve código
            }
            else
            {
                return ""; // devuelve nada si la consulta está vacía
            }
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (lbUsuarios.SelectedIndex > -1) // Si hay selección
           {
                if (lbUsuarios.SelectedIndex > -1) // Si hay selección
                {
                    fila = tabla.Rows[lbUsuarios.SelectedIndex];//fila objeto global
                                                              // clase DataRow. tabla objeto global clase DataTable
                    tbCodigo.Text = fila["CodigoUsuario"].ToString();// Carga los datos en los textbox y el datepicker
                    tbNombre.Text = fila["NombreCompleto"].ToString();
                    tbFecha.Text = fila["FechaNacimiento"].ToString();
                    tbObservaciones.Text = fila["observacion"].ToString();
                    tbDNI.Text = fila["DNI"].ToString();
                    tbDelegacion.Text = fila["CodigoDelegacion"].ToString();
                    tbPais.Text = fila["CodigoPais"].ToString();
                    tbCiudad.Text = fila["CodigoCiudad"].ToString();
                    tbSede.Text = fila["codigoSede"].ToString();
                    tbNick.Text = fila["nick"].ToString();
                    tbContrasenya.Text = fila["contra"].ToString();

                    //Invoca a la función que pone en el combobox asociado el nombre
                    cbPais.Text = ponernombre("paises", "CodigoPais", tbPais.Text);
                    cbDelegacion.Text = ponernombre("delegaciones", "CodigoDelegacion", tbDelegacion.Text);
                    cbCiudad.Text = ponernombre("ciudades", "CodigoCiudad", tbCiudad.Text);
                    cbSede.Text = ponernombre("sedes", "codigoSede", tbSede.Text);
                }
            }
       }


        private void btNuevo_Click(object sender, EventArgs e)
        {
            limpiartextbox();
            lbUsuarios.SelectedItem = null; // Quita selección del listBox
            cambiaventana(false); // Cambia de estado a controles
            btActualizar.Enabled = false;
            string numFilas = "SELECT TOP 1 codigousuario FROM usuarios ORDER BY codigousuario DESC "; // Para ver el último código
            OleDbCommand comando1 = new OleDbCommand(numFilas, Servidor_Chat.miconexion);
            int numfil = (int)comando1.ExecuteScalar();
            tbCodigo.Text = Convert.ToString(numfil + 1); // Nuevo código último + 1
            tbNombre.Focus();//Envia foco para empezar tecleo de nuevos datos
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (lbUsuarios.Items.Count > 0) //Si no hay ítems en listbox no hay usuarios
            {
                if (lbUsuarios.SelectedItem != null) // No hay ítem seleccionado
                {
                    cambiaventana(false);//cambia a modo edición con botones indicados.
                    btGuardar.Enabled = false;
                    tbNombre.Focus();
                }
                else
                {
                    MessageBox.Show("Selecciona un Usuario para poder modificarlo.","Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Actualmente no hay ningún Usuario en la base de datos.", "Información", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (!camposrequeridos()) //comprueba campos obligatorios si tienen datos
            {
                return;
            }
            Int32 mid = Convert.ToInt32(tbCodigo.Text);
            //Sentencia SQL de actualización. Modifica datos con los nuevos tecleados.
            string modificar = "UPDATE usuarios " + "SET nombrecompleto = '" + tbNombre.Text +
            "', observacion = '" + tbObservaciones.Text + "', dni = '" +
            tbDNI.Text + "', codigopais = '" + tbPais.Text
            + "', fechanacimiento = '" + tbFecha.Text + "', codigodelegacion = '" +
            tbDelegacion.Text + "', codigociudad = '" + tbCiudad.Text + "', codigosede = '" + tbSede.Text
            + "', nick = '" + tbNick.Text + "', contra = '" + tbContrasenya.Text + "' WHERE codigousuario = @mid; ";
            OleDbCommand comando2 = new OleDbCommand(modificar, // instrucción SQL
            Servidor_Chat.miconexion); // conexión definida en winprincipal
            comando2.Parameters.AddWithValue("@mid", mid); //Parámetro sentencia SQL
            try
            {
                comando2.ExecuteNonQuery(); //Método para ejecutar sentencia UPDATE
                string nombreUsuarioModificado = tbNombre.Text;
                // Después de guardar el usuario, muestra un mensaje llamando a AddMessage
                AddMessage("[" + now + "]   Usuario *" + nombreUsuarioModificado + "* modificado en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Datos modificados correctamente.");
            cargardatoslisbox(); //Muestra nuevo usuario en listbox
            lbUsuarios.Focus(); // Espera un nuevo click
            cambiaventana(true); //deja controles sin edición
            limpiartextbox();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (lbUsuarios.Items.Count > 0) // mismas comprobaciones que en modificar
            {
                if (lbUsuarios.SelectedItem != null)
                {
                    if (MessageBox.Show("¿Realmente desea eliminar el Usuario " +
                    tbNombre.Text + " de la base de datos?",
                    "Confirmar Eliminación de Registro", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string borra = "DELETE FROM usuarios WHERE codigousuario = @idborra";
                        // Sentencia SQl de borrado con el usuario seleccionado
                        OleDbCommand comandoborra = new OleDbCommand(borra, // instrucción
                        Servidor_Chat.miconexion); // SQL conexión definida en winPrincipal
                        comandoborra.Parameters.AddWithValue("@idborra", tbCodigo.Text);
                        // Parámetro con código a borrar
                        try
                        {
                            comandoborra.ExecuteNonQuery(); //Método usado para ejecutar borrado
                            string nombreUsuarioModificado = tbNombre.Text;
                            // Después de borrar el usuario, muestra un mensaje llamando a AddMessage
                            AddMessage("[" + now + "]   Usuario *" + nombreUsuarioModificado + "* eliminado de la base de datos.");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show("Datos borrados correctamente.");
                        // Elimina el usuario del listbox y borra contenido de los textbox
                        lbUsuarios.Items.RemoveAt(lbUsuarios.SelectedIndex);
                        lbUsuarios.SelectedIndex = lbUsuarios.Items.Count - 1;
                        limpiartextbox();
                        tbCodigo.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un Usuario para eliminarlo.");
                    lbUsuarios.Focus();
                }
            }
        }


        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!camposrequeridos())//Comprueba si están todos los requeridos
            {
                return;
            }
            // Sentencia SQL de inserción del nuevo usuario tecleado en los textbox
            String insertar = "INSERT INTO usuarios(codigousuario, nombrecompleto, observacion, dni, " +
                "codigopais, fechanacimiento, codigodelegacion, codigociudad, codigosede, nick, contra)"
                + "VALUES('" + tbCodigo.Text + "', '" + tbNombre.Text +"', '" + tbObservaciones.Text 
                + "', '" + tbDNI.Text + "', '" +tbPais.Text + "', '" + tbFecha.Text + "', '" 
                + tbDelegacion.Text + "', '"+ tbCiudad.Text + "', '" + tbSede.Text + "'," +
                " '" + tbNick.Text + "', '" + tbContrasenya.Text + "')";
            OleDbCommand comando = new OleDbCommand(insertar, Servidor_Chat.miconexion);
            // Representa una instrucción SQL con conexión definida en winPrincipal
            try
            {
                comando.ExecuteNonQuery(); //Método para ejecutar sentencia INSERT
                // Después de guardar el usuario, muestra un mensaje llamando a AddMessage
                AddMessage("[" + now + "]   Usuario *" + tbNombre.Text + "* añadido en base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Datos guardados correctamente.", "Información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargardatoslisbox();//muestra un nuevo usuario
            lbUsuarios.SelectedItem = lbUsuarios.Items.Count - 1; // lo selecciona
            lbUsuarios.Focus();
            cambiaventana(true); //cambia controles para que no estén en edición
            limpiartextbox();
            SeePassword();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            lbUsuarios.SelectedItem = null; //Quita selección
            limpiartextbox();
            tbCodigo.Clear();
            cambiaventana(true); // Deja controles sin edición
            SeePassword();
        }

        private void fmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btGuardar.Enabled || btActualizar.Enabled)
            {
                MessageBox.Show("Formulario en edición, debe guardar o cancelar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex > -1) // Si hay selección en el ComboBox
            {
                // invoca a la función con los parámetros nombre Tabla, nombre campo,
                // ítem seleccionado del comboBox
                tbPais.Text = poncodigo("paises", "codigopais",
                cbPais.Items[cbPais.SelectedIndex].ToString());
            }
        }

        private void cbDelegacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDelegacion.SelectedIndex > -1) // Si hay selección en el ComboBox
            {
                // invoca a la función con los parámetros nombre Tabla, nombre campo,
                // ítem seleccionado del comboBox
                tbDelegacion.Text = poncodigo("delegaciones", "codigodelegacion",
                cbDelegacion.Items[cbDelegacion.SelectedIndex].ToString());
            }
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudad.SelectedIndex > -1) // Si hay selección en el ComboBox
            {
                // invoca a la función con los parámetros nombre Tabla, nombre campo,
                // ítem seleccionado del comboBox
                tbCiudad.Text = poncodigo("ciudades", "codigociudad",
                cbCiudad.Items[cbCiudad.SelectedIndex].ToString());
            }
        }

        private void cbSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSede.SelectedIndex > -1) // Si hay selección en el ComboBox
            {
                // invoca a la función con los parámetros nombre Tabla, nombre campo,
                // ítem seleccionado del comboBox
                tbSede.Text = poncodigo("sedes", "codigosede",
                cbSede.Items[cbSede.SelectedIndex].ToString());
            }
        }


        public void AddMessage(string message)
        {
            if (Servidor_Chat.MyListBox.InvokeRequired)
            {
                Servidor_Chat.MyListBox.Invoke(new Action(() => Servidor_Chat.MyListBox.Items.Add(message)));
            }
            else
            {
                Servidor_Chat.MyListBox.Items.Add(message);
            }


            //Añade los mensajes a tun archivo txt
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

        private void pbOjo_Click(object sender, EventArgs e)
        {
            SeePassword();
        }

        public void SeePassword() //muesta el password
        {
            // Invierte el valor de UseSystemPasswordChar
            tbContrasenya.UseSystemPasswordChar = !tbContrasenya.UseSystemPasswordChar;

            // Cambia la imagen del PictureBox en consecuencia
            if (tbContrasenya.UseSystemPasswordChar)
            {
                // Si UseSystemPasswordChar es true, cambia a la imagen de ojo tachado
                pbOjo.Image = Properties.Resources.ojo_tachado;
            }
            else
            {
                // Si UseSystemPasswordChar es false, cambia a la imagen de ojo normal
                pbOjo.Image = Properties.Resources.ojo;
            }
        }
    }
}
