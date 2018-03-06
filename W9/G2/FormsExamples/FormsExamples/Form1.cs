using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button 1 clicked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button 2 clicked");
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //MessageBox.Show(btn.Text);
            my_text.Text = btn.Text;
        }
    }
}
