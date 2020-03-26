using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanjayPOS.Reusable_Code
{
    class ChangeListenerPanelToButtonPosition
    {
        Panel panel;
        Button button;
        int Adjustment;

        public ChangeListenerPanelToButtonPosition(
            Panel setPanel, Button setButton,int ToBeAdjust)
        {
            panel = setPanel;
            button = setButton;
            Adjustment = ToBeAdjust;
            setPanel.Resize += new System.EventHandler(this.ResizeLayout_Resize);
        }
        private void ResizeLayout_Resize(object sender, System.EventArgs e)
        {
            button.Location = new Point(panel.Width - button.Width - Adjustment, (panel.Height / 2) - (button.Height / 2));
        }
    }
}
