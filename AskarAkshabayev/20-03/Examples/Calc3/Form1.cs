using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc3
{
    public partial class Form1 : Form
    {
        CalcBrain calc = new CalcBrain();

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text == "0")
                display.Text = btn.Text;
            else
                display.Text += btn.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.firstNumber = float.Parse(display.Text);
            calc.operation = btn.Text;

            display.Text = "";
        }

        private void result_click(object sender, EventArgs e)
        {
            calc.secondNumber = float.Parse(display.Text);
            calc.calculate();

            display.Text = calc.result.ToString();
        }

        private void clear_click(object sender, EventArgs e)
        {
            display.Text = "";

            /*
            calc.firstNumber = 0;
            calc.secondNumber = 0;
            calc.result = 0;
            calc.operation = "";
            */
            calc = new CalcBrain();
        }
    }
}
