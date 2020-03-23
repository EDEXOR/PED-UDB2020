using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED_Fisica
{
    public partial class Form1 : Form
    {
        int xcentro = 250;
        int ycentro = 300;

        Pen lapiz = new Pen(Color.Black);
        Graphics areaDibujo;
       
        public Form1()
        {
            InitializeComponent();
            areaDibujo = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables a utilizar
            double magnitudVector = 0;
            double anguloVector = 0;
            double resMagnitud = 0;
            double resAngulo = 0;

            //DIBUJA PLANO CARTESIANO
            areaDibujo.DrawLine(lapiz, 0,ycentro,500,ycentro);
            areaDibujo.DrawLine(lapiz, xcentro, 0, xcentro, 600);

            //DIBUJANDO VECTOR DE LOS VALORES DE LOS TEXTBOX
            if ((txtValorX.Text != "") && (txtValorY.Text != ""))
            {
                Pen lapizVector = new Pen(Color.Red);
                lapizVector.EndCap = LineCap.ArrowAnchor;
                double valorx = double.Parse(txtValorX.Text);
                double valory = double.Parse(txtValorY.Text);

                areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32((xcentro + valorx)), Convert.ToInt32((ycentro - valory)));

                //Conversión de Rectangular a Poolar
                magnitudVector = Math.Sqrt((Math.Pow(valorx, 2)) + Math.Pow(valory, 2));
                anguloVector = Math.Atan(valory / valorx) * 180 / Math.PI;

                resMagnitud = (Math.Truncate(magnitudVector * 10000) / 10000);
                resAngulo = (Math.Truncate(anguloVector * 10000) / 10000);

                lblAnguloVector.Text = resAngulo.ToString();
                lblMagnitudVector.Text = resMagnitud.ToString();
                
            }
            else
            {
                MessageBox.Show("Campos vacíos. Por favor ingresar un valor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnDibujaPolares_Click(object sender, EventArgs e)
        {
            //Variables a utiliar
            double componenteX = 0;
            double componenteY = 0;
            double resCompoX = 0;
            double resCompoY = 0;
          
            //DIBUJA PLANO CARTESIANO
            areaDibujo.DrawLine(lapiz, 0, ycentro, 500, ycentro);
            areaDibujo.DrawLine(lapiz, xcentro, 0, xcentro, 600);

            if ((txtMagnitud.Text != "") && (txtAngulo.Text != ""))
            {
                if (cmbDirecciones.SelectedIndex == 0)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    //Pasando ángulo a ángulo en radian
                    //Las funciones trigonometricas reciben ángulos en radianes
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = magnitud * Math.Cos(anguloRadian);
                    componenteY = magnitud * Math.Sin(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + " + " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 1)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    //Pasando ángulo a ángulo en radian
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = -magnitud * Math.Cos(anguloRadian);
                    componenteY = magnitud * Math.Sin(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + " + " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 2)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    //Pasando ángulo a ángulo en radian
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = magnitud * Math.Sin(anguloRadian);
                    componenteY = magnitud * Math.Cos(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + " + " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 3)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    //Pasando ángulo a ángulo en radian
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = -magnitud * Math.Sin(anguloRadian);
                    componenteY = magnitud * Math.Cos(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);
                    lblResultadoConversion.Text = resCompoX + " i " + " + " + resCompoY + " j ";

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));
                }
                if (cmbDirecciones.SelectedIndex == 4)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    //Pasando ángulo a ángulo en radian
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = magnitud * Math.Cos(anguloRadian);
                    componenteY = -magnitud * Math.Sin(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 5)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = -magnitud * Math.Cos(anguloRadian);
                    componenteY = -magnitud * Math.Sin(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 6)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = magnitud * Math.Sin(anguloRadian);
                    componenteY = -magnitud * Math.Cos(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 7)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double angulo = Convert.ToDouble(txtAngulo.Text);
                    double anguloRadian = angulo * Math.PI / 180;

                    componenteX = -magnitud * Math.Sin(anguloRadian);
                    componenteY = -magnitud * Math.Cos(anguloRadian);
                    //Asignando decimales
                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + resCompoY + " j ";
                }
            }
            else if ((txtMagnitud.Text != ""))
            {
                if (cmbDirecciones.SelectedIndex == 8)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double anguloRadian = 45 * Math.PI / 180;

                    componenteX = magnitud * Math.Cos(anguloRadian);
                    componenteY = magnitud * Math.Sin(anguloRadian);

                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + " + " + resCompoY + " j ";

                }
                if (cmbDirecciones.SelectedIndex == 9)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double anguloRadian = 135 * Math.PI / 180;

                    componenteX = magnitud * Math.Cos(anguloRadian);
                    componenteY = magnitud * Math.Sin(anguloRadian);

                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + " + " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 10)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double anguloRadian = 315 * Math.PI / 180;

                    componenteX = magnitud * Math.Cos(anguloRadian);
                    componenteY = magnitud * Math.Sin(anguloRadian);

                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + resCompoY + " j ";
                }
                if (cmbDirecciones.SelectedIndex == 11)
                {
                    double magnitud = Convert.ToDouble(txtMagnitud.Text);
                    double anguloRadian = 225 * Math.PI / 180;

                    componenteX = magnitud * Math.Cos(anguloRadian);
                    componenteY = magnitud * Math.Sin(anguloRadian);

                    resCompoX = (Math.Truncate(componenteX * 10000) / 10000);
                    resCompoY = (Math.Truncate(componenteY * 10000) / 10000);

                    //Dibujando vector con las componentes
                    Pen lapizVector = new Pen(Color.Red);
                    lapizVector.EndCap = LineCap.ArrowAnchor;
                    areaDibujo.DrawLine(lapizVector, xcentro, ycentro, Convert.ToInt32(xcentro + resCompoX), Convert.ToInt32(ycentro - resCompoY));

                    lblResultadoConversion.Text = resCompoX + " i " + resCompoY + " j ";
                }
            }
            else
            {
                MessageBox.Show("Campos vacíos. Por favor ingresar valores", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbDirecciones.SelectedIndex == 8) || (cmbDirecciones.SelectedIndex == 9) || (cmbDirecciones.SelectedIndex == 10) || (cmbDirecciones.SelectedIndex == 11))
            {
                txtAngulo.Enabled = false;
            }
            else
            {
                txtAngulo.Enabled = true;
            }
        }

        //Validando los campo de Magnitud, Ángulo para solo aceptar números
        private void txtMagnitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtAngulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtValorY_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
