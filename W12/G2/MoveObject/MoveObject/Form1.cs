using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        int x = 0, dx = 10;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            p = new Pen(Color.Red, 3);
            //timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(p, x, 150, 100, 100);
            drawRect();
        }

        private void drawRect()
        {
            g.DrawRectangle(p, x, 150, 100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
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
