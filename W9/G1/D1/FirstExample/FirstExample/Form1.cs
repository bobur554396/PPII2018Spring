using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExample
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

        private void common_button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            myLabel.Text = btn.Text;
        }
    }
}
