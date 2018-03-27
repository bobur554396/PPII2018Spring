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

namespace PaintExample3
{
    public enum Tool { Pencil, Rectangle, Circle, Line, Triangle1, Erase };

    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath path;
        Bitmap btm;
        Pen pen;
        Point prev;
        Tool t;
        
        public Form1()
        {
            InitializeComponent();

            path = new GraphicsPath();
            pen = new Pen(Color.Red, 2);
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;

            g = Graphics.FromImage(btm);
            g.Clear(Color.White);

            t = Tool.Pencil;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point cur = e.Location;
                path.Reset();
                switch (t)
                {
                    case Tool.Pencil:
                        g.DrawLine(pen, prev, cur);
                        prev = cur;
                        break;
                    case Tool.Rectangle:
                        path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                        break;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (path != null)
                g.DrawPath(pen, path);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(pen, path);
        }

        private void tools_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "Pencil":
                    t = Tool.Pencil;
                    break;
                case "Rect":
                    t = Tool.Rectangle;
                    break;
            }
        }
        
    }
}
