using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED_Fisica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl2019_Click(object sender, EventArgs e)
        {

        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {

        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblUDB_Click(object sender, EventArgs e)
        {

        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "hola@gmail.com" || txtCorreo.Text == "hola123")
            {
                menu form_log = new menu();
                this.Hide();
                form_log.Show();
            }
            else
            {
                MessageBox.Show("Favor revisar los datos del usuario y contraseña");
            }
            

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
