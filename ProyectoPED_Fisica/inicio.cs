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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        Timer Clock = new Timer();
        private void inicio_Load(object sender, EventArgs e)
        {

            Clock.Interval = 5000;
            Clock.Start();
            Clock.Tick += new EventHandler(Timer_Tick);
            

        }
        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            Clock.Stop();
            Login form_log = new Login();
            this.Hide();
            form_log.Show();           
        }

        private void lbl2019_Click(object sender, EventArgs e)
        {

        }

        private void pcbExtra_Click(object sender, EventArgs e)
        {

        }
    }
}
