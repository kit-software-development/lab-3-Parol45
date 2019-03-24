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
    public partial class winningDialogWin : Form
    {
        public winningDialogWin()
        {
            InitializeComponent();
        }

        private void onDialogLoad(object sender, EventArgs e)
        {
            okButton.Location = new Point(ClientSize.Width / 2 - okButton.Width / 2, ClientSize.Height - okButton.Height - 10);
            dialogText.Location = new Point(ClientSize.Width / 2 - dialogText.Width / 2, 20);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
