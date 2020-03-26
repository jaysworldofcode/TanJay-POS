using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanjayPOS.Reusable_Code
{
    public class ChangeListenerPanelToLabelPosition
    {
        Panel panel;
        Label label;
        int Adjustment, PaddingBottom,
            PaddingTop;

        public ChangeListenerPanelToLabelPosition(
            Panel setPanel, Label setLabel,
            int ToBeAdjust, Boolean shouldRight,
            int PaddingBottom, int PaddingTop)
        {
            this.PaddingBottom = PaddingBottom;
            this.PaddingTop = PaddingTop;
            if (shouldRight)
            {
                panel = setPanel;
                label = setLabel;
                Adjustment = ToBeAdjust;
                setPanel.Resize += new System.EventHandler(this.ResizeLayout_ResizeRight);
            }
            else
            {
                panel = setPanel;
                label = setLabel;
                Adjustment = ToBeAdjust;
                setPanel.Resize += new System.EventHandler(this.ResizeLayout_ResizeLeft);
            }
        }
        private void ResizeLayout_ResizeRight(object sender, System.EventArgs e)
        {
            label.Location = new Point(panel.Width - label.Width - Adjustment, (
                (panel.Height / 2) - (label.Height / 2)) + PaddingBottom - PaddingTop);
        }
        private void ResizeLayout_ResizeLeft(object sender, System.EventArgs e)
        {
            label.Location = new Point(
                (panel.Width/8) + Adjustment, ((panel.Height / 2) - (label.Height / 2)) + PaddingBottom - PaddingTop);
        }
    }
}
