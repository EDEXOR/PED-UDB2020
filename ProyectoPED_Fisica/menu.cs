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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            menuU1 form_log = new menuU1();
            this.Hide();
            form_log.Show();
        }
    }
}
