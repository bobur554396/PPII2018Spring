using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Width = 500;
            Height = 500;
        }

        int k = 0;        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = k+"";
            //k++;
            if (k == 0)
            {
                BackColor = Color.Green;
                k++;
            }
            else if (k == 1)
            {
                BackColor = Color.Red;
                k = 0;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue+"");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("key press");
            //MessageBox.Show(e.KeyChar.ToString());
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("key up");
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //MessageBox.Show("preview Key down");
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //textBox1.Text += btn.Text;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
            button1.Location = new Point(e.Location.X - button1.Width / 2, e.Location.Y - button1.Height / 2);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int x = new Random().Next(0, 400);
            int y = new Random().Next(0, 400);
            //MessageBox.Show("Mouse enter");
            //button1.Location = new Point(x, y);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            int x = new Random().Next(0, 400);
            int y = new Random().Next(0, 400);
            MessageBox.Show("Mouse hover");
            
            //button1.Location = new Point(x, y);
        }



    }
}
