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
        // Хранение записанного выражения в переменной, а не в Label.Text в целях адекватного вывода на экран.
        string expr = " 0";

        // Эмпирическим путём вычисленное изначальное максимальное кол-во цифр на Label.
        int maxNums = 7;

        private int countSpaces(string input)
        {
            int spacesCount = 0;
            foreach (char ch in input)
                if (ch == ' ') spacesCount++;
            return spacesCount;
        }

        // Перезапись выражения в обратную польскую нотацию перед решением.
        private string toReversePolandNotation(string input)
        {
            Stack<string> items = new Stack<string>();
            string newInput = " ";
            int spacesCount = countSpaces(input);
            input += ' ';
            for (int i = 0; i < spacesCount; i++)
            {
                string item = input.Substring(1, input.IndexOf(' ', 1) - 1);
                input = input.Substring(input.IndexOf(' ', 1));
                if (char.IsDigit(item[0]))
                    newInput += item + ' ';
                else
                {
                    while (items.Count > 0
                            && ((new [] { "/", "*"}.Contains(items.Peek()) && new[] { "/", "*", "+", "-" }.Contains(item)) 
                                || new[] { "+", "-" }.Contains(item))
                           )
                        newInput += items.Pop() + ' ';
                    items.Push(item);
                }
            }
            while (items.Count >= 1)
                newInput += items.Pop() + ' ';
            return newInput;
        }

        // Решение выражения, записанного в польской обратной нотации.
        private double solve(string input)
        {
            int spacesCount = countSpaces(input);
            Stack<double> items = new Stack<double>();
            for (int i = 0; i < spacesCount - 1; i++)
            {
                string item = input.Substring(1, input.IndexOf(' ', 1) - 1);
                input = input.Substring(input.IndexOf(' ', 1));
                if (!new[] { "+", "-", "*", "/" }.Contains(item))
                    items.Push(Convert.ToDouble(item));
                else
                {
                    double secondOperand = items.Pop(), firstOperand = items.Pop();
                    switch (item)
                    {
                        case "+":
                            items.Push(firstOperand + secondOperand);
                            break;
                        case "-":
                            items.Push(firstOperand - secondOperand);
                            break;
                        case "*":
                            items.Push(firstOperand * secondOperand);
                            break;
                        case "/":
                            items.Push(firstOperand / secondOperand);
                            break;
                    }
                }
            }
            return items.Pop();
        }

        // KeyPreview - для перехвата нажатий клавиш формой, т. к. у нас не textbox.
        public mainWindow()
        {
            InitializeComponent();
            displayLabel.Text = expr;
            KeyPreview = true;
        }

        /* Усечение хранимого текста выражения до максимально возможного.
         * Попытки заставить это нормально работать (учитывать то, что операторы и пробелы
         * уже цифр) не увенчались успехом, но энивей это работает лучше, чем изначальный вариант
         * от мелкософта с пропаданием текста с Label или его застыванием.
         */
        private void showOnDisplay()
        {
            displayLabel.Text = expr.Substring(maxNums < expr.Length ? expr.Length - 1 - maxNums : 0);
        }

        /* Обработка события нажатия на клавишу с цифрой.
         * По задумке она может быть нажата всегда, кроме ситуации с бесконечностью
         * и удалять единственный 0 в конце выражения
         */
        private void onDigitButtonClick(object sender, EventArgs e)
        {
            if (expr.Substring(expr.LastIndexOf(' ')) == " 0")
                expr = expr.Substring(0, expr.Length - 1);
            if (expr != " ∞")
                expr += (sender as Button).Text;
            showOnDisplay();
        }

        /* Обработка события нажатия на клавишу разделителя.
         * Разделитель в числе может быть только один и идти после числа (первый if).
         * Если числа после введённого знака нет, то вставляется 0 (второй if).
         */
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

        /* Обработка события нажатия на клавишу стирания.
         * Если промежуточный результат не единственный 0, то
         * удаляется либо последний оператор, либо число соответственно.
         * Если же в результате не осталось ничего, то добавляется 0.
         */
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

        /* Обработка события нажатия на клавиши операторов.
         * Удаление последнего знака разделителя, который гарантированно стоит после числа,
         * и проверка, что это число (не стал делать стирание последнего написанного оператора,
         * потому что для этого существует клавиша CE).
         */
        private void onOperatorButtonClick(object sender, EventArgs e)
        {
            if (expr[expr.Length - 1] == ',')
                expr = expr.Substring(0, expr.Length - 1);
            if (char.IsDigit(expr[expr.Length - 1]))
                expr += ' ' + (sender as Button).Text + ' ';
            showOnDisplay();
        }

        /* Надстройка над обработкой клавиш операторов,
         * потому что минус может стоять перед числом и являться его частью. 
         */
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

        /* Расчёт написанного выражения.
         * Используется обратная польская запись.
         * Значения меньше 10^-8 не учитываются, потому что числа с плавающей точкой становятся
         * не нулями, а очень малыми значениями, которые выводятся а-ля 2,47Е-23. Это некрасиво.
         */
        private void onEqualButtonClick(object sender, EventArgs e)
        {
            if (expr[expr.Length - 1] == ' ')
                expr = expr.Substring(0, expr.Length - 3);
            string temp = solve(toReversePolandNotation(expr)).ToString();
            expr = ' ' + (temp == "NaN" ? "∞" : temp);
            Clipboard.SetText(expr);
            showOnDisplay();
        }

        // При изменении размеров окна изменяется макс. кол-во символов на Label. 
        private void onSizeChg(object sender, EventArgs e)
        {
            maxNums = 7 + (ClientSize.Width - 217) / 26;
            showOnDisplay();
        }

        /* Обработка события нажатия на клавишу клавиатуры
         * Каждый case имеет вид:
         *      - Перечисление клавиш, вызывающих событие
         *      - Создание события нажатия клавиши GUI
         *      - Установка флага, что событие обработано
         * Очень неприятный код, для подобных целей используют TextBox.
         */
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
