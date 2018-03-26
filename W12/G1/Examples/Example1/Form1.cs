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
        Pen pen;
        Graphics g;

        int x = 0, dx = 10;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Red, 3);
            g = CreateGraphics();
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(pen, x, 200, 100, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x + 100 > Width || x < 0)
                dx *= -1;

            x += dx;

            Refresh();
        }
    }
}
