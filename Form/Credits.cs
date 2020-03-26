using System;
using System.Drawing;
using System.Windows.Forms;
using TanjayPOS.Controller;
using TanjayPOS.DB;
using TanjayPOS.Model;
using WindowsFormsApp1.Data;

namespace TanjayPOS
{
    public partial class Credits : Form
    {
        DataHolder dh = DataHolder.Instance;
        Credits_Controller controller;
        CustomerList_Model CustomerModel = new CustomerList_Model();
        public CreditList_Model CreditModel = new CreditList_Model();
        int index = 0;
        double balance = 0;
        public string getCustomer_ID() { return CustomerModel.getCustomer_id()[index].ToString(); }
        public Credits(int width, int height)
        {
            InitializeComponent();
            InitSettings();
            //this.Size = new Size(width, height);
            this.Location = new Point(0, 0);
        }
        void InitSettings()
        {
            new Credits_DB().RetrieveCustomerList(CustomerModel);
            controller = new Credits_Controller(this);
            BT_Add.Click += new System.EventHandler(controller.AddToItems);
            BT_Search.Click += new System.EventHandler(controller.SearchCustomerInfo);
            BT_Search.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\magnify-gray-16x.png");
            BT_Clear.Click += new System.EventHandler(controller.ClearCustomerData);
            BT_Update.Click += new System.EventHandler(controller.UpdateCustomerData);
            BT_Delete.Click += new System.EventHandler(controller.DeleteCustomer);
            DGV_BalanceList.MouseClick += new MouseEventHandler(controller.RightClickActionInBalanceList);
            BT_SetAsPaidAll.MouseClick += new MouseEventHandler(controller.SetAsPaidAll);
            CB_FilterType.SelectedValueChanged += new System.EventHandler(controller.SetFilter);
            DGV_BalanceList.AllowUserToAddRows = false;
            TB_Count.ReadOnly = true;
            TB_TotalBalance.ReadOnly = true;
            AddCustomerListCB();
        }
        public void DeleteCustomer(string customer_id)
        {
            if (String.IsNullOrEmpty(TB_CustomerName.Text) ||
                String.IsNullOrEmpty(TB_ContactNumber.Text) ||
                String.IsNullOrEmpty(TB_Address.Text)){
                MessageBox.Show("Some fields is empty!");
            } else {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + TB_CustomerName.Text + "?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new Credits_DB().Delete_Customer(customer_id);
                    AddCustomerListCB();
                    CB_CustomersList.Text = "";
                    CB_FilterType.Text = "Filter by";
                    DGV_BalanceList.Rows.Clear();
                    SetButtonsEnabled(true, false, false, false);
                    MessageBox.Show(TB_CustomerName.Text + " successfuly deleted!");
                    EmptyCustomertInfo();
                }
            }
        }
        public void AddCustomerListCB()
        {
            CustomerModel.Clear();
            new Credits_DB().RetrieveCustomerList(CustomerModel);
            CB_CustomersList.Items.Clear();
            for (int count = 0; count < CustomerModel.getCustomer_id().Count; count++)
            {
                CB_CustomersList.Items.Add(CustomerModel.getCustomer_Name()[count]);
            }
        }
        public void EmptyCustomertInfo()
        {
            TB_CustomerName.Text = "";
            TB_Address.Text = "";
            TB_ContactNumber.Text = "";
        }
        public Panel getMainPanel()
        {
            return Credit_Panel;
        }
        public void FilterBalanceType(string filter_type)
        {
            DGV_BalanceList.Rows.Clear();
            if (filter_type.Equals("paid"))
            {
                for (int count = 0; count < CreditModel.getCredit_ID().Count; count++)
                {
                    if(CreditModel.getStatus()[count].ToString().ToUpper().Equals("PAID"))
                    {
                        DGV_BalanceList.Rows.Add(
                            CreditModel.getCredit_ID()[count],
                            CreditModel.getItem_Name()[count],
                            CreditModel.getCode()[count],
                            CreditModel.getPrice()[count],
                            CreditModel.getDate_Issued()[count],
                            CreditModel.getUnit()[count],
                            CreditModel.getStatus()[count],
                            CreditModel.getCashier()[count].ToString().Split('/')[1]
                        );
                    }
                }
            } else if(filter_type.Equals("unpaid"))
            {
                for (int count = 0; count < CreditModel.getCredit_ID().Count; count++)
                {
                    if (CreditModel.getStatus()[count].ToString().ToUpper().Equals("UNPAID"))
                    {
                        DGV_BalanceList.Rows.Add(
                            CreditModel.getCredit_ID()[count],
                            CreditModel.getItem_Name()[count],
                            CreditModel.getCode()[count],
                            CreditModel.getPrice()[count],
                            CreditModel.getDate_Issued()[count],
                            CreditModel.getUnit()[count],
                            CreditModel.getStatus()[count],
                            CreditModel.getCashier()[count].ToString().Split('/')[1]
                        );
                    }
                }

            } else {
                for (int count = 0; count < CreditModel.getCredit_ID().Count; count++)
                {
                    DGV_BalanceList.Rows.Add(
                        CreditModel.getCredit_ID()[count],
                        CreditModel.getItem_Name()[count],
                        CreditModel.getCode()[count],
                        CreditModel.getPrice()[count],
                        CreditModel.getDate_Issued()[count],
                        CreditModel.getUnit()[count],
                        CreditModel.getStatus()[count],
                        CreditModel.getCashier()[count].ToString().Split('/')[1]
                    );
                }
            }
            SetTotalBalance();
        }
        public void SetPaid(int id,string customer_id)
        {
            new Credits_DB().SetItemAsPaid(id + "");
            SetCustomerBalanceList(customer_id);
            FilterBalanceType("all");
        }
        public void SetAllPaid(string customer_id)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to set all balance as paid?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int count = 0; count < CreditModel.getCredit_ID().Count; count++)
                {
                    if (CreditModel.getStatus()[count].ToString().ToUpper().Equals("UNPAID"))
                    {
                        new Credits_DB().SetItemAsPaid(CreditModel.getCredit_ID()[count].ToString());
                    }
                }
                SetCustomerBalanceList(customer_id);
                FilterBalanceType("all");
            }
        }
        public void SetTotalBalance()
        {
            double balance = 0;
            for (int count = 0; count < CreditModel.getCredit_ID().Count; count++)
            {
                if (CreditModel.getStatus()[count].ToString().Equals("Unpaid")){
                    balance = balance + (
                        double.Parse(CreditModel.getPrice()[count].ToString())*
                        int.Parse(CreditModel.getUnit()[count].ToString()));
                }
            }
            TB_TotalBalance.Text = balance.ToString("N0");
            TB_Count.Text = DGV_BalanceList.Rows.Count.ToString();
        }
        public void SetCustomerBalanceList(string customer_id)
        {
            DGV_BalanceList.Rows.Clear();
            CreditModel.Clear();
            new Credits_DB().RetrieveCustomerBalance(CreditModel,customer_id);
            for (int count = 0; count < CreditModel.getCredit_ID().Count; count++)
            {
                DGV_BalanceList.Rows.Add(
                    CreditModel.getCredit_ID()[count],
                    CreditModel.getItem_Name()[count],
                    CreditModel.getCode()[count],
                    CreditModel.getPrice()[count],
                    CreditModel.getDate_Issued()[count],
                    CreditModel.getUnit()[count],
                    CreditModel.getStatus()[count],
                    CreditModel.getCashier()[count].ToString().Split('/')[1]
                );
            }
            SetTotalBalance();
        }
        public void SetSearchCustomerInfo(string name)
        {
            index = CustomerModel.getCustomer_Name().IndexOf(name);
            TB_CustomerName.Text = CustomerModel.getCustomer_Name()[index].ToString();
            TB_Address.Text = CustomerModel.getCustomerAddress()[index].ToString();
            TB_ContactNumber.Text = CustomerModel.getCustomerContactNumber()[index].ToString();
        }
        public void ClearData()
        {
            CreditModel.Clear();
            DGV_BalanceList.Rows.Clear();
            SetTotalBalance();
            CB_FilterType.SelectedItem = "All";
        }
        public void SetButtonsEnabled(bool add, bool update, bool delete, bool clear)
        {
            BT_Add.Enabled = add;
            BT_Update.Enabled = update;
            BT_Delete.Enabled = delete;
            BT_Clear.Enabled = clear;
        }
        public void UpdateCustomerData(string customer_id)
        {
            new Credits_DB().UpdateCustomerInfo(
                customer_id,
                TB_CustomerName.Text,
                TB_Address.Text,
                TB_ContactNumber.Text
            );
            AddCustomerListCB();
            CB_CustomersList.Text = "";
            MessageBox.Show(TB_CustomerName.Text + " successfuly updated!");
        }

        private void Credit_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TB_CustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
