﻿using System.Windows.Forms;

namespace TanjayPOS.Reusable_Code
{
    class TextBoxAcceptsNumberOnly
    {
        public TextBoxAcceptsNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
               e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
