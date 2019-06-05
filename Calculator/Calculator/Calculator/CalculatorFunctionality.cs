using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class CalculatorFunctionality
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }

        public decimal Plus(decimal number1, decimal number2)
        {
            decimal answer;
            answer = number1 + number2;
            return answer;
        }

        public  decimal Minus(decimal number1, decimal number2)
        {
            decimal answer;
            answer = number1 - number2;
            return answer;
        }

        public  decimal Multiply(decimal number1, decimal number2)
        {
            decimal answer;
            answer = number1 * number2;
            return answer;
        }

        public decimal Devide(decimal number1, decimal number2)
        {
            decimal answer;
            try
            {
                answer = number1 / number2;
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Exception caught: {0}", e);
                answer = 0;
            }
            return answer;
        }
    }
}
