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
        Pen pen;
        Point prev;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Red, 3);

            g = CreateGraphics(); // Form1 paint 
            g.Clear(Color.White);
        }

        
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
                prev = cur;
                //prev = cur; // Pencil
            }
        }
    }
}
