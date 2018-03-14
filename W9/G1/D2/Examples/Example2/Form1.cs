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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            my_btn.BackColor = Color.Blue;
        }

        private void my_btn_Click(object sender, EventArgs e)
        {   
            my_btn.BackColor = Color.Red;
            textBox1.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s.Contains("@"))
                MessageBox.Show("ok");
            else
                MessageBox.Show("false");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar1.Value+"");
        }
    }
}
