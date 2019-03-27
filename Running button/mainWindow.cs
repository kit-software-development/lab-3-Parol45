using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3_Parol45
{
    public partial class mainWindow : Form
    {
        // Начальные настройки, чтобы кнопка стояла посередине и ничего не слетало при изменении свойств.
        public mainWindow()
        {
            InitializeComponent();
            runningButton.Size = new Size(124, 30);
            MinimumSize = new Size(Width - ClientSize.Width + runningButton.Size.Width,
                                   Height - ClientSize.Height + runningButton.Size.Height);
            runningButton.Location =
                new Point(ClientSize.Width / 2 - runningButton.Width / 2,
                          ClientSize.Height / 2 - runningButton.Height / 2);
            saveState(this, new EventArgs());
        }

        // Создаю свой контекст для пропорционального изменения экрана.
        public Size inintialWinSize;
        public Point initialButPos;
        public FormWindowState initialWinState;
        
        // Проверка попадания курсора в прямоугольник на area больше кнопки
        // и соответствующее её смещение (шага в 1 пиксель достаточно, т. к. 
        // событие возникает обновления часто).
        private void onMouseMoved(object sender, MouseEventArgs e)
        {
            const int area = 30;
            int halfButW = runningButton.Width / 2,
                halfButH = runningButton.Height / 2,
                butX = runningButton.Location.X,
                butY = runningButton.Location.Y;
            if (Math.Abs(butX + halfButW - e.X) < area + halfButW && Math.Abs(butY + halfButH - e.Y) < area + halfButH)
            {
                if (Math.Abs(butX + halfButW - e.X) > halfButW)
                {
                    // Тут регулировать скорость кнопки (текущее - число area + 5, т. к. 
                    // скорость бега кнопки напрямую зависит от частоты возникнования события MouseMove)
                    butX = e.X + (butX - e.X < 0 ? -area - 5 - runningButton.Width : 5 + area);
                    if (butX + 2 * halfButW > ClientSize.Width)
                        butX = area / 5;
                    if (butX < 0)
                        butX = ClientSize.Width - 2 * halfButW - area / 5;
                }
                if (Math.Abs(butY + halfButH - e.Y) > halfButH)
                {
                    // Тута тоже
                    butY = e.Y + (butY - e.Y < 0 ? -area - 5 - runningButton.Height : 5 + area);
                    if (butY + 2 * halfButH > ClientSize.Height)
                        butY = area / 5;
                    if (butY < 0)
                        butY = ClientSize.Height - 2 * halfButH - area / 5;
                }
            }
            runningButton.Location = new Point(butX, butY);
            initialButPos = runningButton.Location;
        }   

        // Я не гений расчётов, поэтому кнопка съезжает слегка после постоянного усечения с float до int.
        // Т. к. нет отдельного события для нажатия на клавишу разворота на весь экран, 
        // пришлось изощриться с состояниями окна
        // Не сделал через layout, потому что margin и padding элементов не задаются в процентах, удобнее самому
        private void onWindowResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                int newX = (int)((initialButPos.X + runningButton.Width / 2) *
                             (1.0 * ClientSize.Width / inintialWinSize.Width)) - runningButton.Width / 2,
                    newY = (int)((initialButPos.Y + runningButton.Height / 2) *
                             (1.0 * ClientSize.Height / inintialWinSize.Height)) - runningButton.Height / 2;
                newX = newX <= 0 ? 0 : newX;
                newY = newY <= 0 ? 0 : newY;
                newX = newX >= ClientSize.Width - runningButton.Width ? ClientSize.Width - runningButton.Width : newX;
                newY = newY >= ClientSize.Height - runningButton.Height ? ClientSize.Height - runningButton.Height : newY;
                runningButton.Location = new Point(newX, newY);
            }
            if (WindowState == FormWindowState.Maximized || initialWinState != WindowState
                && WindowState != FormWindowState.Minimized)
            {
                saveState(sender, e);
            }
        }

        // Сохранение контекста после любого ресайза.
        private void saveState(object sender, EventArgs e)
        {
            inintialWinSize = ClientSize;
            initialButPos = runningButton.Location;
            initialWinState = WindowState;
        }

        // Обработка нажатия на кнопку с вызовом диалогового окна.
        private void onMouseClick(object sender, MouseEventArgs e)
        {
            winningDialogWin endGame = new winningDialogWin();
            endGame.Show();
        }
    }
}
