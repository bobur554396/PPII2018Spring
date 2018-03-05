using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaclExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumeber = int.Parse(textBox1.Text);
            int secondNumber = int.Parse(textBox2.Text);
            int result = firstNumeber + secondNumber;

            label1.Text = result.ToString();
        }
    }
}
