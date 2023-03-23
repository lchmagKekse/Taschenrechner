using System;
using System.Data;
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
            string senderName = ((Button)sender).Name;

            if (CheckForOperator()) TxtB.Text = TxtB.Text.Remove(TxtB.Text.Length - 1);
            if (string.IsNullOrWhiteSpace(TxtB.Text) && senderName != "BtnSub") return;       

            if (senderName == "BtnDiv") TxtB.Text += '/';
            if (senderName == "BtnMul") TxtB.Text += '*';
            if (senderName == "BtnSub") TxtB.Text += '-';
            if (senderName == "BtnAdd") TxtB.Text += '+';
        }

        private void ClearInputField(object sender, EventArgs e)
        {
            TxtB.Text = string.Empty;
        }

        private void ClearLastInput(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtB.Text)) return;

            TxtB.Text = TxtB.Text.Remove(TxtB.Text.Length - 1);
        }

        private void SolveExpression(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtB.Text)) return;

            DataTable table = new DataTable();

            try
            {
                var result = Convert.ToString(table.Compute(TxtB.Text, ""));
                TxtB.Text = result.Replace(',', '.');
            }
            catch
            {
                TxtB.Text = "Syntax Error :(";
            }
        }

        private void DotClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtB.Text)) return;
            if (CheckForOperator()) return;
            if (TxtB.Text[TxtB.TextLength - 1] == '.') return;

            TxtB.Text += '.';
        }
    }
}