using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lineas_a_la_antigua
{
    public partial class Form1 : Form
    {
        Graphics g;
        int numPuntos = 5;
        public Form1()
        {   g = this.CreateGraphics();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numPuntos = int.Parse(textBox1.Text);
                DibujarLinea(numPuntos);

            }
            catch (Exception ex) {
                MessageBox.Show("Dato invalido u_u");
            }
        }

        private void DibujarLinea(int numPuntos)
        {
            g.Clear(Color.White);
            Pen lapiz = new Pen(Color.FromArgb(0, 0, 0), 5);
            int x1 = 0; int x2 = this.Width / 2;
            int y1 = 0; int y2 = this.Height / 2;

            double longitud = Math.Sqrt(((x2-x1)*(x2 - x1))+ ((y2 - y1) * (y2 - y1)));

            double dis_entre_puntos = longitud / numPuntos;
            double dirX = (x2 - x1) / longitud;
            double dirY = (y2 - y1) / longitud;
            for (int i = 0; i <= numPuntos; i++) {
                int x =(int)(x1 + (dis_entre_puntos * i )* dirX);
                int y = (int)(y1 + (dis_entre_puntos * i )* dirY);

                g.DrawRectangle(lapiz, new Rectangle(x, y, 5, 5));

            }

        }
    }
}
