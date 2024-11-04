using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Events: Form
    {
        public Events()
        {
            InitializeComponent();
        }

        public void events()
        {
            // Ruta del archivo de texto
            string filePath = ".\\datos\\Registro.txt";

            try
            {
                // Lee el contenido del archivo de texto
                string[] lineas = File.ReadAllLines(filePath);

                lbEvents.Items.Clear();

                // Agrega las líneas al ListBox
                lbEvents.Items.AddRange(lineas);

                // Establece el índice superior (TopIndex) al último elemento
                lbEvents.TopIndex = lbEvents.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Events_Load(object sender, EventArgs e)
        {
            events();
        }

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            events();
        }
    }
}
