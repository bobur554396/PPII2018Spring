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
        }

        int k = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(k++);
            //k++;
            //label1.Text = k.ToString();
            //textBox1.Text = k.ToString(); 
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 500;
            Height = 500;

            BackColor = Color.Red;

            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;

            label1.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Italic);
            label1.ForeColor = Color.White;
            

            //textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s.Contains('@'))
            {
                MessageBox.Show("true");
            } else
            {
                MessageBox.Show("false");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
