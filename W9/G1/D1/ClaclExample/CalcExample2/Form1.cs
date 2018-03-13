using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcExample2
{
    public partial class Form1 : Form
    {
        TextBox display;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display = new TextBox();
            display.Font = new Font(FontFamily.GenericMonospace, 25);
            display.Location = new Point(50, 20);
            display.Width = 180;
            display.TextAlign = HorizontalAlignment.Right;

            Width = 250;
            Height = 350;

            int cnt = 1;
            for(int i  =0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = cnt.ToString();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(j * 50 + 50, i * 60 + 70);
                    btn.Click += numbers_click;

                    Controls.Add(btn);

                    cnt++;
                }
            }

            Controls.Add(display);
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = display.Text + btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
