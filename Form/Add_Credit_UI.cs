using System;
using System.Windows.Forms;
using TanjayPOS.Controller;
using TanjayPOS.DB;
using TanjayPOS.Model;
using TanjayPOS.Reusable_Code;
using WindowsFormsApp1.Data;

namespace TanjayPOS
{
    public partial class Add_Credit_UI : Form
    {
        Add_Credit_Controller controller;
        POS_Items_Model ItemsModel;
        Stock_Data_Model StockModel;
        CustomerList_Model CustomerModel = new CustomerList_Model();
        POS pos;
        DataHolder dh = DataHolder.Instance;
        public Add_Credit_UI()
        {
            InitializeComponent();
            InitSettings();
        }
        public void setItemsModel(POS_Items_Model ItemsModel) { this.ItemsModel = ItemsModel; }
        public void setStockModel(Stock_Data_Model StockModel) { this.StockModel = StockModel; }
        public void setPOS(POS pos) { this.pos = pos; }
        void InitSettings()
        {
            controller = new Add_Credit_Controller(this);
            new Credits_DB().RetrieveCustomerList(CustomerModel);
            AddToCredit();
            BT_Cancel.Click += new System.EventHandler(controller.Cancel);
            BT_AddCredit.Click += new System.EventHandler(controller.AddCredit);
        }
        public void AddToCredit()
        {
            for (int count=0;count< CustomerModel.getCustomer_Name().Count; count++)
            {
                CB_CustomerList.Items.Add(CustomerModel.getCustomer_Name()[count]+"/"+CustomerModel.getCustomer_id()[count]);
            }
        }
        public void AppendCredit()
        {
            //Update unit left in DB
            Update_UnitLeft update_unitLeft = new Update_UnitLeft(
                ItemsModel,
                StockModel
            );
            update_unitLeft.UpdateChecker();
            POS_DB pos_db = new POS_DB();
            for (int count = 0; count < ItemsModel.getItemName().Count; count++)
            {
                pos_db.AddToCredit(
                CB_CustomerList.Text.Split('/')[1],
                ItemsModel.getItemName()[count].ToString(),
                ItemsModel.getCode()[count].ToString(),
                ItemsModel.getPrice()[count].ToString(),
                DateTime.Now.ToString(),
                ItemsModel.getUnit()[count].ToString(),
                "Unpaid",
                dh.getUsername()+"/"+dh.getUserFullName(),
                RTB_Description.Text);
            }
            MessageBox.Show("Successfuly added " + ItemsModel.getItemName().Count+" items to"+ CB_CustomerList.Text.Split('/')[0]+" as credit!");
            ItemsModel.ClearCart();
            pos.AddItemsData();
        }
    }
}