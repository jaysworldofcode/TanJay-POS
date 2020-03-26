using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TanjayPOS.Reusable_Code
{
    class EmptyFieldChecker
    {
        String PopUpMessageWarning = "";
        List<TextBox> TextBoxList = new List<TextBox>();
        public EmptyFieldChecker(String message)
        {
            PopUpMessageWarning = message;
        }
        public void AddTextFieldToBeCheck(TextBox AddTextBox)
        {
            TextBoxList.Add(AddTextBox);
        }
        public bool IsSomeTextBoxIsEmpty()
        {
            bool status = false;
            foreach (TextBox textbox in TextBoxList)
                if (String.IsNullOrEmpty(textbox.Text) || String.IsNullOrWhiteSpace(textbox.Text))
                    status = true;

            if(status)
                MessageBox.Show(PopUpMessageWarning);

            return status;
        }
    }
}
