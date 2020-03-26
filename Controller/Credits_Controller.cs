using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using TanjayPOS.DB;

namespace TanjayPOS.Controller
{
    class Credits_Controller
    {
        int credit_id = 0;
        string to_be_paid = "";
        Credits credits;
        System.Windows.Forms.ContextMenu menu_pop_up;
        System.Windows.Forms.MenuItem MenuSetPaid;
        System.Windows.Forms.MenuItem MenuViewDescription;
        public Credits_Controller(Credits credits){ this.credits = credits; }
        public void AddToItems(object sender, System.EventArgs e)
        {
            if(
                String.IsNullOrEmpty(credits.TB_CustomerName.Text) ||
                String.IsNullOrEmpty(credits.TB_ContactNumber.Text) ||
                String.IsNullOrEmpty(credits.TB_Address.Text)
            ){
                MessageBox.Show("Some fields are empty!");
            } else {
                new Credits_DB().AddCustomer(
                    credits.TB_CustomerName.Text,
                    credits.TB_Address.Text,
                    credits.TB_ContactNumber.Text);
                credits.EmptyCustomertInfo();
                credits.AddCustomerListCB();
            }
        }
        public void RightClickActionInBalanceList(object sender, MouseEventArgs e)
        {
            MenuSetPaid = new System.Windows.Forms.MenuItem("Set as paid");
            MenuViewDescription = new System.Windows.Forms.MenuItem("View Description");
            if (e.Button == MouseButtons.Right)
            {
                menu_pop_up = new System.Windows.Forms.ContextMenu();
                menu_pop_up.MenuItems.Add(MenuSetPaid);
                menu_pop_up.MenuItems.Add(MenuViewDescription);
                int currentMouseOverRow = credits.DGV_BalanceList.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    MenuSetPaid.Click += new System.EventHandler(SetAsPaid);
                    MenuViewDescription.Click += new System.EventHandler(ViewDescription);
                    credit_id = int.Parse(credits.DGV_BalanceList.Rows[currentMouseOverRow].Cells[0].FormattedValue.ToString());
                    to_be_paid = credits.DGV_BalanceList.Rows[currentMouseOverRow].Cells[1].FormattedValue.ToString();
                }
                menu_pop_up.Show(credits.DGV_BalanceList, new Point(e.X, e.Y));
            }
        }
        public void SetAsPaidAll(object sender, System.EventArgs e)
        {
            credits.SetAllPaid(credits.getCustomer_ID());
        }
        public void SetAsPaid(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to set "+ to_be_paid+" as paid?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                credits.SetPaid(credit_id, credits.getCustomer_ID());
            }
        }
        public void ViewDescription(object sender, System.EventArgs e)
        {
            MessageBox.Show(
                credits.CreditModel.getDescription()[
                    credits.CreditModel.getCredit_ID().IndexOf(credit_id+"")].ToString(),
                "Credit description"
            );
        }
        public void SearchCustomerInfo(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(credits.CB_CustomersList.Text))
            {
                credits.SetSearchCustomerInfo(credits.CB_CustomersList.Text);
                credits.SetButtonsEnabled(false, true, true, true);
                credits.SetCustomerBalanceList(credits.getCustomer_ID());
            }
        }
        public void SetFilter(object sender, System.EventArgs e)
        {
            credits.FilterBalanceType(credits.CB_FilterType.Text.ToLower());
        }
        public void ClearCustomerData(object sender, System.EventArgs e)
        {
            credits.ClearData();
            credits.EmptyCustomertInfo();
            credits.SetButtonsEnabled(true, false, false, true);
        }
        public void DeleteCustomer(object sender, System.EventArgs e)
        {
            credits.DeleteCustomer(credits.getCustomer_ID());
        }
        public void UpdateCustomerData(object sender, System.EventArgs e)
        {
            credits.UpdateCustomerData(credits.getCustomer_ID());
        }
    }
}
