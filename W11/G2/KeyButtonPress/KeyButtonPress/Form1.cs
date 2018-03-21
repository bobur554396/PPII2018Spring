using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyButtonPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);
                    break;
                case Keys.D:
                    button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);
                    break;
            }
              
    }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("key press");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);
                    break;
                case Keys.D:
                    button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             * List<Label> l = new List<Label>();
            Label l1 = new Label();
            l1.Text = "O";
            l.Add(l1);
            */

            Point p = label1.Location;

            if (p.Y > Height)
                p.Y = 0;

            p.Y += 20;

            label1.Location = p;
        }
    }
}
