using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CanvaClase180123
{
    public partial class Form1 : Form
    {
        Bitmap ima1;
        Graphics g;
        

        public Form1()
        {
            InitializeComponent();

            ima1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(ima1);
            pictureBox1.Image = ima1;

            int wp = pictureBox1.Width / 2;
            int hp = pictureBox1.Height / 2;

            Point wi = new Point(wp, 0);
            Point wf = new Point(wp, 2 * hp);
            Point hi = new Point(0, hp);
            Point hf = new Point(2 * wp, hp);

            g.Clear(Color.Black);
            g.DrawLine(Pens.Yellow, wi, wf);
            g.DrawLine(Pens.Yellow, hi, hf);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF a2, b2, c2, d2;
            int wp = pictureBox1.Width/ 2;
            int hp = pictureBox1.Height/ 2;
            float angle = Convert.ToInt32(textBox1.Text);
            angle = (float)(angle * (System.Math.PI/180));

            Point a = new Point(0, 0);
            Point b = new Point(0, 100);
            Point c = new Point(100, 100);
            Point d = new Point(100, 0);
            a2 = new PointF(wp + a.X, hp - a.Y);
            b2 = new PointF(wp + b.X, hp - b.Y);
            c2 = new PointF(wp + c.X, hp - c.Y);
            d2 = new PointF(wp + d.X, hp - d.Y);
            a2.X = wp + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            a2.Y = hp - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));
            b2.X = wp + (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            b2.Y = hp - (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));
            c2.X = wp + (float)((c.X * Math.Cos(angle)) - (c.Y * Math.Sin(angle)));
            c2.Y = hp - (float)((c.X * Math.Sin(angle)) + (c.Y * Math.Cos(angle)));
            d2.X = wp + (float)((d.X * Math.Cos(angle)) - (d.Y * Math.Sin(angle)));
            d2.Y = hp - (float)((d.X * Math.Sin(angle)) + (d.Y * Math.Cos(angle)));

            g.DrawLine(Pens.Gray, a2, b2);
            g.DrawLine(Pens.Gray, b2, c2);
            g.DrawLine(Pens.Gray, c2, d2);
            g.DrawLine(Pens.Gray, d2, a2);
            pictureBox1.Refresh();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PointF a2, b2, c2, d2;
            int wp = pictureBox1.Width / 2;
            int hp = pictureBox1.Height / 2;
            float angle = Convert.ToInt32(textBox1.Text);
            angle = (float)(angle * (System.Math.PI / 180));

            Point a = new Point(-50, -50);
            Point b = new Point(-50, 50);
            Point c = new Point(50, 50);
            Point d = new Point(50, -50);
            a2 = new PointF(wp + a.X, hp - a.Y);
            b2 = new PointF(wp + b.X, hp - b.Y);
            c2 = new PointF(wp + c.X, hp - c.Y);
            d2 = new PointF(wp + d.X, hp - d.Y);
            a2.X = wp + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            a2.Y = hp - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));
            b2.X = wp + (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            b2.Y = hp - (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));
            c2.X = wp + (float)((c.X * Math.Cos(angle)) - (c.Y * Math.Sin(angle)));
            c2.Y = hp - (float)((c.X * Math.Sin(angle)) + (c.Y * Math.Cos(angle)));
            d2.X = wp + (float)((d.X * Math.Cos(angle)) - (d.Y * Math.Sin(angle)));
            d2.Y = hp - (float)((d.X * Math.Sin(angle)) + (d.Y * Math.Cos(angle)));

            g.DrawLine(Pens.Gray, a2, b2);
            g.DrawLine(Pens.Gray, b2, c2);
            g.DrawLine(Pens.Gray, c2, d2);
            g.DrawLine(Pens.Gray, d2, a2);
            pictureBox1.Refresh();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            PointF a2, b2, c2, d2;
            int wp = pictureBox1.Width / 2;
            int hp = pictureBox1.Height / 2;
            float angle = Convert.ToInt32(textBox1.Text);
            angle = (float)(angle * (System.Math.PI / 180));

            Point a = new Point(-50, -50);
            Point b = new Point(-50, 50);
            Point c = new Point(50, 50);
            Point d = new Point(50, -50);
            a2 = new PointF(wp + a.X, hp - a.Y);
            b2 = new PointF(wp + b.X, hp - b.Y);
            c2 = new PointF(wp + c.X, hp - c.Y);
            d2 = new PointF(wp + d.X, hp - d.Y);
            a2.X = wp +50 + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            a2.Y = hp -50 - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));
            b2.X = wp +50 + (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            b2.Y = hp - 50 - (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));
            c2.X = wp + 50 + (float)((c.X * Math.Cos(angle)) - (c.Y * Math.Sin(angle)));
            c2.Y = hp - 50 - (float)((c.X * Math.Sin(angle)) + (c.Y * Math.Cos(angle)));
            d2.X = wp + 50 + (float)((d.X * Math.Cos(angle)) - (d.Y * Math.Sin(angle)));
            d2.Y = hp - 50 - (float)((d.X * Math.Sin(angle)) + (d.Y * Math.Cos(angle)));

            g.DrawLine(Pens.Gray, a2, b2);
            g.DrawLine(Pens.Gray, b2, c2);
            g.DrawLine(Pens.Gray, c2, d2);
            g.DrawLine(Pens.Gray, d2, a2);
            pictureBox1.Refresh();
        }
    }
}
