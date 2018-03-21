using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc3
{
    public class CalcBrain
    {
        public float firstNumber, secondNumber, result;
        public string operation;

        public CalcBrain()
        {
            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = "";
        }


        public void calculate()
        {
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
        }
    }
}
