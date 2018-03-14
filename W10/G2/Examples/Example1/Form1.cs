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
        int x = 200, dx = 20, y = 0, dy = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*button1.Text = "Start";
            button1.Font = new Font(FontFamily.GenericSansSerif, 20);
            */
            label1.Location = new Point(x, y);
            Width = 500;
            Height = 500;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if(label1.Location.X + label1.Width < Width)
                label1.Location = new Point(label1.Location.X + 20, label1.Location.Y);
            else
                label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
                */

            if (x + label1.Width > Width)
                dx *= -1;
            else if (x < 0)
                dx *= -1;

            if (y + label1.Height > Height)
                dy *= -1;
            else if (y < 0)
                dy *= -1;

            x += dx;
            y += dy;

            label1.Location = new Point(x, y);
        }
    }
}
