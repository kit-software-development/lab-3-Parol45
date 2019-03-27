using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_palette
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            onScroll(this, new EventArgs());
        }

        // Не знаю, как это комментировать
        private void onScroll(object sender, EventArgs e)
        {
            palette.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);
            colorTip.SetToolTip(palette, "#"
                + Convert.ToString(redBar.Value, 16).ToUpper().PadLeft(2, '0')
                + Convert.ToString(greenBar.Value, 16).ToUpper().PadLeft(2, '0')
                + Convert.ToString(blueBar.Value, 16).ToUpper().PadLeft(2, '0'));
            Clipboard.SetText(colorTip.GetToolTip(palette));
        }
    }
}
