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
        bool email = false, pass = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("@")){
                label1.Text = "good";
                email = true;
            }
            else
                label1.Text = "bad";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 8){
                label2.Text = "good";
                pass = true;
            }
            else
                label2.Text = "bad";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (email && pass)
                MessageBox.Show("true");
            else
                MessageBox.Show("false");
        }
    }
}
