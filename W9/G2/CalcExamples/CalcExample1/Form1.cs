using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label2.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBox1.Text);
            int secondNumber = int.Parse(textBox2.Text);

            int res = firstNumber + secondNumber;

            label2.Text = res + "";
        }
    }
}
