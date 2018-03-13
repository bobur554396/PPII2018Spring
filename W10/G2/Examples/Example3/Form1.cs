using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Location = new Point(0, 0);
            Width = 500;
            Height = 500;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point clickedPoint = e.Location;
            //label1.Location = clickedPoint;
            button1.Location = new Point(clickedPoint.X - button1.Width / 2, clickedPoint.Y - button1.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button clicked");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int x = new Random().Next(0, 400);
            int y = new Random().Next(0, 400);

            button1.Location = new Point(x, y);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            int x = new Random().Next(0, 400);
            int y = new Random().Next(0, 400);

            button1.Location = new Point(x, y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point clickedPoint = e.Location;
            label1.Text = clickedPoint.ToString();
        }
    }
}
