using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //label1.Text = DateTime.Now.ToLongTimeString();
        }

        int k = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*k++;
            textBox1.Text = k.ToString();
            label1.Text = k.ToString();*/

            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
