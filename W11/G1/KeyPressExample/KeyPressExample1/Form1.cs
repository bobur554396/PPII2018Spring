using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPressExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        /*
            public enum Gender { male, female };
            public enum Direction { up, down, left, right };

            class Snake
            {
                int a;
                Direction d;
                Gender gender;

                public Snake()
                {
                    d = Direction.right;
                }
            }
        */

        
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

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("key press");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = label1.Location;
            p.Y += 20;

            if (p.Y > Height)
                p.Y = 0;

            label1.Location = p;

        }
    }
}
