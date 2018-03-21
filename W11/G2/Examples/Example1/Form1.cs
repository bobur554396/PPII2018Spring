using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            g = CreateGraphics();
            //MessageBox.Show("constructor");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("load");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show("paint");

            e.Graphics.DrawLine(Pens.Red, 10, 10, 100, 100);

            Pen pen = new Pen(Color.Blue, 3);
            Point p1 = new Point(50, 50);
            Point p2 = new Point(50, 200);
            e.Graphics.DrawLine(pen, p1, p2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Yellow, 4);
            //g.DrawRectangle(p, 100, 50, 100, 100);
            Rectangle r = new Rectangle(100, 50, 100, 100);

            g.DrawRectangle(p, r);

            p = new Pen(Color.Violet, 3);

            g.DrawEllipse(p, 100, 100, 100, 100);

            Point[] arr =
            {
                new Point(50, 50),
                new Point(300, 70),
                new Point(250, 300),
                new Point(30, 250),
                new Point(50, 50),
            };

            p = new Pen(Color.Green, 4);
            //g.DrawPolygon(p, arr);
            g.DrawLines(p, arr);


            SolidBrush brush = new SolidBrush(Color.Red);
            
            g.FillRectangle(brush, 300, 200, 200, 200);
            g.DrawRectangle(p, 300, 200, 200, 200);

        }
    }
}
