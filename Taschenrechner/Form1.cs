using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool CheckForOperator()
        {
            if (string.IsNullOrWhiteSpace(TxtB.Text)) return false;

            if (TxtB.Text[TxtB.Text.Length - 1] == '/') return true;
            if (TxtB.Text[TxtB.Text.Length - 1] == '*') return true;
            if (TxtB.Text[TxtB.Text.Length - 1] == '-') return true;
            if (TxtB.Text[TxtB.Text.Length - 1] == '+') return true;

            return false;
        }

        public static double ParseMathString(string mathString)
        {
            string[] operators = { "+", "-", "*", "/" };
            string[] tokens = mathString.Split(operators, StringSplitOptions.RemoveEmptyEntries);

            List<double> operands = new List<double>();
            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double operand))
                {
                    operands.Add(operand);
                    continue;
                }
                    throw new ArgumentException("Invalid operand: " + token);
            }

            double result = operands[0];
            for (int i = 0; i < operators.Length; i++)
            {
                string op = operators[i];
                string[] subtokens = mathString.Split(op[0]);

                for (int j = 0; j < subtokens.Length - 1; j++)
                {
                    double num1 = operands[j];
                    double num2 = operands[j + 1];

                    switch (op)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            throw new ArgumentException("Invalid operator: " + op);
                    }

                    operands[j + 1] = result;
                }
            }

            return result;
        }

        private void NumberClick(object sender, EventArgs e)
        {
            string senderName = ((Button)sender).Name;

            if (senderName == "Btn0") TxtB.Text += '0';
            if (senderName == "Btn1") TxtB.Text += '1';
            if (senderName == "Btn2") TxtB.Text += '2';
            if (senderName == "Btn3") TxtB.Text += '3';
            if (senderName == "Btn4") TxtB.Text += '4';
            if (senderName == "Btn5") TxtB.Text += '5';
            if (senderName == "Btn6") TxtB.Text += '6';
            if (senderName == "Btn7") TxtB.Text += '7';
            if (senderName == "Btn8") TxtB.Text += '8';
            if (senderName == "Btn9") TxtB.Text += '9';
        }

        private void OperandClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtB.Text)) return;
            if (CheckForOperator()) TxtB.Text = TxtB.Text.Remove(TxtB.Text.Length - 1);

            string senderName = ((Button)sender).Name;

            if (senderName == "BtnDiv") TxtB.Text += '/';
            if (senderName == "BtnMul") TxtB.Text += '*';
            if (senderName == "BtnSub") TxtB.Text += '-';
            if (senderName == "BtnAdd") TxtB.Text += '+';
        }

        private void BtnClearE_Click(object sender, EventArgs e)
        {
            TxtB.Text = string.Empty;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtB.Text)) return;

            TxtB.Text = TxtB.Text.Remove(TxtB.Text.Length - 1);
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            TxtB.Text = ParseMathString(TxtB.Text).ToString();
        }
    }
}
