using System;
using System.Windows.Forms;

namespace Servidor
{
    public partial class fmAcercade : Form
    {
        public fmAcercade()
        {
            InitializeComponent();
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
