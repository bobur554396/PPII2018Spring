using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2
{
    public partial class Form1 : Form
    {
        float firstNumber = 0, secondNumber = 0, result = 0;
        string operation = "";

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
            firstNumber = float.Parse(display.Text);
            operation = btn.Text;

            display.Text = "";
        }

        private void result_click(object sender, EventArgs e)
        {
            secondNumber = float.Parse(display.Text);

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
            }

            display.Text = result.ToString();
        }
    }
}
