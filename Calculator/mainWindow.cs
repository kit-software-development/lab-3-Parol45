using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class mainWindow : Form
    {

        string expr = " 0";
        int maxNums = 7;

        public mainWindow()
        {
            InitializeComponent();
            displayLabel.Text = expr;
            KeyPreview = true;
        }

        private void showOnDisplay()
        {
            displayLabel.Text = expr.Substring(maxNums < expr.Length ? expr.Length - 1 - maxNums : 0);
        }

        private void onDigitButtonClick(object sender, EventArgs e)
        {
            if (expr.Substring(expr.LastIndexOf(' ')) == " 0")
                expr = expr.Substring(0, expr.Length - 1);
            if (expr != " ∞")
                expr += (sender as Button).Text;
            showOnDisplay();
        }

        private void onSeparatorButtonClick(object sender, EventArgs e)
        {
            if (char.IsDigit(expr[expr.Length - 1])
                && !expr.Substring(expr.LastIndexOf(' ')).Contains(','))
                expr += (sender as Button).Text;
            if (expr[expr.Length - 1] == ' '
                || expr[expr.Length - 1] == '-')
                expr += '0' + (sender as Button).Text;
            showOnDisplay();
        }

        private void onClearButtonClick(object sender, EventArgs e)
        {
            if (expr != " 0")
            {
                if (expr[expr.Length - 1] == ' ')
                    expr = expr.Substring(0, expr.LastIndexOf(' ') - 2);
                else
                    expr = expr.Substring(0, expr.LastIndexOf(' ') + 1);
                if (expr == " ")
                    expr += '0';
            }
            showOnDisplay();
        }

        private void onOperatorButtonClick(object sender, EventArgs e)
        {
            if (expr[expr.Length - 1] == ',')
                expr = expr.Substring(0, expr.Length - 1);
            if (char.IsDigit(expr[expr.Length - 1]))
                expr += ' ' + (sender as Button).Text + ' ';
            showOnDisplay();
        }

        private void onSubstractButtonClick(object sender, EventArgs e)
        {
            if (expr[expr.Length - 1] == ' ')
            {
                expr += '-';
                showOnDisplay();
            }
            else
                onOperatorButtonClick(sender, e);
        }

        private void onEqualButtonClick(object sender, EventArgs e)
        {
            if (expr[expr.Length - 1] == ' ')
                expr = expr.Substring(0, expr.Length - 3);
            Stack<float> nums = new Stack<float>();
            Stack<char> opers = new Stack<char>();
            int spacesCount = 0;
            char oper;
            string expression = expr + ' ';
            foreach (char ch in expression)
                if (ch == ' ') spacesCount++;
            spacesCount = spacesCount / 2 - 1;
            nums.Push(Convert.ToSingle(expression.Substring(1, expression.IndexOf(' ', 1) - 1)));
            expression = expression.Substring(expression.IndexOf(' ', 1) + 1);
            for (int i = 0; i < spacesCount; i++)
            {
                oper = expression[0];
                expression = expression.Substring(1);
                while (opers.Count != 0
                    && (opers.Peek() == '/' || opers.Peek() == '*')
                    && (oper == '+' || oper == '-'))
                {
                    float secondOperand = nums.Pop(), firstOperand = nums.Pop();
                    switch (opers.Pop())
                    {
                        case '/':
                            nums.Push(firstOperand / secondOperand);
                            break;
                        case '*':
                            nums.Push(firstOperand * secondOperand);
                            break;
                    }
                }
                opers.Push(oper);
                nums.Push(Convert.ToSingle(expression.Substring(1, expression.IndexOf(' ', 1) - 1)));
                expression = expression.Substring(expression.IndexOf(' ', 1) + 1);
            }
            while (nums.Count != 1)
            {
                float secondOperand = nums.Pop(), firstOperand = nums.Pop();
                switch (opers.Pop())
                {
                    case '+':
                        nums.Push(firstOperand + secondOperand);
                        break;
                    case '-':
                        nums.Push(firstOperand - secondOperand);
                        break;
                    case '/':
                        nums.Push(firstOperand / secondOperand);
                        break;
                    case '*':
                        nums.Push(firstOperand * secondOperand);
                        break;
                }
            }
            string answer = (nums.Peek() < 0.0001 ? 0 : nums.Pop()).ToString();
            expr = ' ' + (answer == "NaN" ? "∞" : answer);
            Clipboard.SetText(expr);
            showOnDisplay();
        }

        private void onSizeChg(object sender, EventArgs e)
        {
            maxNums = 7 + (ClientSize.Width - 217) / 26;
            showOnDisplay();
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    zeroButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    oneButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    twoButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    threeButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    fourButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    fiveButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    sixButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    sevenButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    eightButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    nineButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Back:
                    clearButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.OemPeriod:
                case Keys.Decimal:
                    separatorButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    sumButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    substractionButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Multiply:
                    multipyButton.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.OemQuestion:
                case Keys.Divide:
                    divideButton.PerformClick();
                    e.Handled = true;
                    break;
            }
        }
    }
}
