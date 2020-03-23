using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED_Fisica
{
    class Vectores
    {
        public Vector inicio;
        private int PuntaX;
        private int PuntaY;

        public Vectores()
        {
            inicio = null;
        }
        public void Insertar(int magnitud, int angulo, double magnitudX, double magnitudY, int posX, int posY)
        {
            Vector auxiliar = new Vector();
            auxiliar.magnitud = magnitud;
            auxiliar.angulo = angulo;
            auxiliar.magnitudX = magnitudX;
            auxiliar.magnitudY = magnitudY;
            auxiliar.posX = posX;
            auxiliar.posY = posY;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Vector puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }

        public void CalcularResultante(TextBox txt)
        {
            double totalMagnitudX = 0;
            double totalMagnitudY = 0;
            double totalAngulo = 0;
            double totalMagnitud = 0;

            if (inicio == null)
            {
                MessageBox.Show("Ingrese vectores");
            }
            else
            {
                Vector puntero;
                puntero = inicio;
                while (puntero != null)
                {
                    totalMagnitudX = totalMagnitudX + puntero.magnitudX;
                    totalMagnitudY = totalMagnitudY + puntero.magnitudY;

                    puntero = puntero.siguiente;
                }

                totalMagnitud = Math.Sqrt( Math.Pow(totalMagnitudX, 2) + Math.Pow(totalMagnitudY, 2));

                totalAngulo = Math.Atan(totalMagnitudY / totalMagnitudX) * (180 / Math.PI);

                if(totalMagnitudX < 0 && totalMagnitudY > 0)
                {
                    totalAngulo = totalAngulo + 180;
                }
                if (totalMagnitudX < 0 && totalMagnitudY < 0)
                {
                    totalAngulo = totalAngulo + 180;
                }

                txt.Text = "Vector Resultante: \t Magnitud total en X: " + Math.Round(totalMagnitudX, 3) + "\n Magnitud total en Y: " + Math.Round(totalMagnitudY, 3) + "" +
                    "\n Magnitud: " + Math.Round(totalMagnitud, 3) + " \n Ángulo: "+ Math.Round(totalAngulo, 3);
                txt.Visible = true;
                
            }
        }


        public void DibujarResultante(Graphics grafo, Point origen)
        {
            if (inicio != null)
            {
                Pen pen = new Pen(Color.Red, 3);
                pen.EndCap = LineCap.ArrowAnchor;

                grafo.DrawLine(pen, origen, new Point(PuntaX, PuntaY));
            }
        }


        public void DibujarVector(Graphics grafo, Point origen, Point cola, Point punta, Vector vector)
        {
            Pen pen = new Pen(Color.Black, 3);
            pen.EndCap = LineCap.ArrowAnchor;

            if (vector != null)
            {
                if (cola.X == origen.X && cola.Y == origen.Y)
                {
                    punta.X = origen.X + vector.posX;
                    punta.Y = origen.Y - vector.posY;
                    grafo.DrawLine(pen, cola, punta);

                    PuntaX = cola.X = punta.X;
                    PuntaY = cola.Y = punta.Y;

                    DibujarVector(grafo, origen, cola, punta, vector.siguiente);
                }
                else
                {
                    punta.X = cola.X + vector.posX;
                    punta.Y = cola.Y - vector.posY;
                    grafo.DrawLine(pen, cola, punta);

                    PuntaX = cola.X = punta.X;
                    PuntaY = cola.Y = punta.Y;

                    DibujarVector(grafo, origen, cola, punta, vector.siguiente);
                }
            }
        }
    }
}
