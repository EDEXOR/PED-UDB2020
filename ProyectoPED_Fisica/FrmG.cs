using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED_Fisica
{
    public partial class FrmG : Form
    {
        Vectores listaVector = new Vectores();

        bool resultante = false;

        //Variable para saber el origen del plano
        int origenX = 0;
        int origenY = 0;

        //Estas variables serviran para saber la punta de cada vector y comenzar a dibujar el siguiente desde ahi
        int puntaX = 0;
        int puntaY = 0;

        //Estas variables serviran para saber la cola de cada vector
        int colaX = 0;
        int colaY = 0;

        //Magnitud del vector en X y en Y
        int posX = 0;
        int posY = 0;

        public FrmG()
        {
            InitializeComponent();

            colaX = origenX = AreaGrafica.Width / 2;
            colaY = origenY = AreaGrafica.Height / 2;
        }

        private bool Validaciones()
        {
            bool validado = true;
            if (txtmagnitud.Text == "")
            {
                validado = false;
                EPvalidaciones.SetError(txtmagnitud, "Ingrese la magnitud del vector");
            }
            if (txtangulo.Text == "")
            {
                validado = false;
                EPvalidaciones.SetError(txtangulo, "Ingrese el ángulo del vector");
            }
            /*if (CBoperaciones.Text == "")
            {
                validado = false;
                EPvalidaciones.SetError(CBoperaciones, "seleccione la operaciones");

            }*/

            return validado;
        }

        private void BorarSMS()
        {
           
            EPvalidaciones.SetError(txtangulo, "");
            EPvalidaciones.SetError(txtmagnitud, "");
            //EPvalidaciones.SetError(CBoperaciones, "");

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            BorarSMS();
            if (Validaciones())
            {
                int magnitud = int.Parse(txtmagnitud.Text);
                int angulo = int.Parse(txtangulo.Text);

                double magnitudX = magnitud * Math.Cos(angulo * (Math.PI / 180));
                double magnitudY = magnitud * Math.Sin(angulo * (Math.PI / 180));

                posX = (int) Math.Round(magnitudX);
                posY = (int) Math.Round(magnitudY);

                listaVector.Insertar(magnitud, angulo, magnitudX, magnitudY, posX, posY);

                txtangulo.Clear();
                txtmagnitud.Clear();
                txtmagnitud.Focus();
                Refresh();
                Refresh();
            }

            //int n = Convert.ToInt32(CBCantidad.Text);            
        }
        

        private void txtmagnitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            else if (char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else { e.Handled = true; MessageBox.Show("Solo se admiten datos numéricos", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void txtangulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { e.Handled = false; }
            else if (char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else { e.Handled = true; MessageBox.Show("Solo se admiten datos numéricos", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void AreaGrafica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(this.BackColor);

            Pen pen1 = new Pen(Color.Black, 1);
            g.DrawLine(pen1, AreaGrafica.Width / 2, 0, AreaGrafica.Width / 2, AreaGrafica.Height);//Para dibujar la linea vertical del plano
            g.DrawLine(pen1, 0, AreaGrafica.Height /2, AreaGrafica.Width , AreaGrafica.Height / 2);//Para dibujar la linea horizontal del plano

            listaVector.DibujarVector(g, new Point(origenX, origenY), new Point(colaX, colaY), new Point(puntaX, puntaY), listaVector.inicio);

            if (resultante == true)
            {
                listaVector.DibujarResultante(g , new Point(origenX, origenY));
                resultante = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultante = true;

            listaVector.CalcularResultante(txtResultante);
            Refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AreaDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
