using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Calculator : Form
    {
        public decimal number1, number2;
        CalculatorFunctionality functionality = new CalculatorFunctionality();
        int operation;
        public Calculator()
        {
            InitializeComponent();
        }


        private void DisplayResult(object sender, EventArgs e)
        {
            if (inputTab.Text == "")
            {
                resultTab.Text += "0";
                number2 = 0;
            }
            else
            {
                resultTab.Text += inputTab.Text;
                number2 = Convert.ToDecimal(inputTab.Text);
            }
            resultTab.Text += " = ";
            inputTab.Clear();
            if (operation == 1) resultTab.Text += functionality.Plus(number1, number2);
            else if (operation == 2) resultTab.Text += functionality.Minus(number1, number2);
            else if (operation == 3) resultTab.Text += functionality.Multiply(number1, number2);
            else if (operation == 4)
            {
                if (number2 == 0) resultTab.Text = "Cannot divide by zero";
                else resultTab.Text += functionality.Devide(number1, number2);
            }
            equalsButton.Enabled = false;


        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            if (inputTab.Text == "") { Calculate("0 + "); number1 = 0; }
            else
            {
                String action = inputTab.Text;
                action += " + ";
                number1 = Convert.ToDecimal(inputTab.Text);
                Calculate(action);
                
            }
            operation = 1;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (inputTab.Text == "") { Calculate("0 - "); number1 = 0; }
            else
            {
                String action = inputTab.Text;
                action += " - ";
                number1 = Convert.ToDecimal(inputTab.Text);
                Calculate(action);

            }
            operation = 2;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (inputTab.Text == "") { Calculate("0 X "); number1 = 0; }
            else
            {
                String action = inputTab.Text;
                action += " X ";
                number1 = Convert.ToDecimal(inputTab.Text);
                Calculate(action);

            }
            operation = 3;
        }

        private void DevideButton_Click(object sender, EventArgs e)
        {
            if (inputTab.Text == "") { Calculate("0 / "); number1 = 0; }
            else
            {
                String action = inputTab.Text;
                action += " / ";
                number1 = Convert.ToDecimal(inputTab.Text);
                Calculate(action);

            }
            operation = 4;
        }

        private void Calculate(String action)
        {
            equalsButton.Enabled = true;
            resultTab.Text = action;
            inputTab.Clear();  
            inputTab.Select();
        }
    }
}
