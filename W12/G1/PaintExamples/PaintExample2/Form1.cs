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

namespace PaintExample2
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath path;
        Pen pen;
        Point prev;
        Bitmap btm;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Red, 3);

            // g = CreateGraphics(); // Form1 paint 
            path = new GraphicsPath();
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;


            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
        }

        /*
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
            //g.FillEllipse(Brushes.Red, prev.X, prev.Y, 3, 3);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point cur = e.Location;

                g.DrawLine(pen, prev, cur);

                pictureBox1.Refresh();

                //prev = cur; // Pencil
            }
        }*/

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            if (e.Button == MouseButtons.Left)
            {
                Point cur = e.Location;

                g.DrawRectangle(pen, prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
                pictureBox1.Refresh();
            }*/
            path.Reset();
            if (e.Button == MouseButtons.Left)
            {
                Point cur = e.Location;
                //path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                /* Pencil 
                path.AddLine(prev, cur);
                */
                
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(path != null)
                g.DrawPath(pen, path);
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(pen, path);
        }
    }
}
