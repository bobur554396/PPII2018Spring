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

namespace PaintExample1
{
    public partial class Form1 : Form
    {
        Graphics g;
        GraphicsPath path;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            path = new GraphicsPath();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(20, 20, 100, 100);
            Rectangle r2 = new Rectangle(300, 300, 200, 100);

            path.AddRectangle(r);
            path.AddEllipse(r2);

            g.DrawPath(Pens.Red, path);
        }
    }
}
