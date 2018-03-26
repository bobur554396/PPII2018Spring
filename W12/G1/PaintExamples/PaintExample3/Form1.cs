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
            path = new GraphicsPath();
            
            // Main graphics
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btm;
            
            // Create graphics from Bitmap
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // save clicked position of mouse
            prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // remove all previous shapes in GraphicsPath
            path.Reset();
            
            // check for mouse left button clicked
            if (e.Button == MouseButtons.Left)
            {
                // get current location of mouse
                Point cur = e.Location;
                
                // add shape to path
                path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                
                // redraw picturebox
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // if GraphicsPath not empty draw last position of the shape in Main Graphics(Bitmap)
            if (path != null)
                g.DrawPath(pen, path);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Draw all temporary shapes in Graphics of picturebox
            e.Graphics.DrawPath(pen, path);
        }
    }
}
