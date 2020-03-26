using System;
using System.Drawing;
using System.Windows.Forms;
using TanjayPOS.Controller;
using TanjayPOS.DB;
using TanjayPOS.Model;
using TanjayPOS.Reusable_Code;
using WindowsFormsApp1.Data;

namespace TanjayPOS
{
    public partial class POS : Form
    {
        DataHolder dh = DataHolder.Instance;
        POS_Controller controller = new POS_Controller();
        POS_Items_Model ItemsModel = new POS_Items_Model();
        Stock_Data_Model StockModel = new Stock_Data_Model();
        public POS(int width, int height)
        {
            Console.Write("View: POS UI");
            InitializeComponent();
            //this.Size = new Size(width, height);
            InitSettings();
        }
        public Panel getMainPanel()
        {
            return POS_Panel;
        }
        void InitSettings()
        {
            controller.SetView(this);
            controller.SetTextBoxStocksList(StocksList);
            controller.SetStockModel(StockModel);
            controller.SetPOS_Model(ItemsModel);
            GetStocksModelAndStoreToAutoComplete();
            StocksList.KeyDown += new KeyEventHandler(controller.GetStockData);
            BT_ClearCart.Click += new System.EventHandler(controller.ClearCart);
            BT_ClearCart.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\clear-cart.png");
            BT_AddToStack.Click += new System.EventHandler(controller.AddToItems);
            BT_AddToStack.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\add-to-cart.png");
            BT_DeleteCart.Click += new System.EventHandler(controller.DeleteCart);
            BT_DeleteCart.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\delete-cart.png");
            BT_AddToCredit.Click += new System.EventHandler(controller.AddToCredit);
            BT_AddToCredit.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\pos-credit.png");
            BT_RegisterCustomer.Click += new System.EventHandler(controller.RegisterCustomer);
            BT_RegisterCustomer.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\add-customer.png");
            BT_Pay.Click += new System.EventHandler(controller.Pay);
            BT_Pay.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\pay.png");
            BT_Search.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\magnify-gray-16x.png");
            DGV_Items.AllowUserToAddRows = false;
            AddItemsData();
        }
        public void GetStocksModelAndStoreToAutoComplete()
        {
            StockModel.Clear();
            new Stocks_DB().RetrieveStocks(StockModel);
            StocksList.AutoCompleteMode = AutoCompleteMode.Suggest;
            StocksList.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            for (int x = 0; x < StockModel.getStockID().Count; x++)
            {
                col.Add(StockModel.getCode()[x].ToString() + "/" + StockModel.getItemName()[x].ToString());
                StocksList.AutoCompleteCustomSource = col;
                Console.WriteLine("Store " + StockModel.getCode()[x].ToString() + "/" + StockModel.getItemName()[x].ToString() + " to POS");
            }
        }
        public void InsertItem(String BarCode, int unit)
        {
            string item = StockModel.getItemName()[StockModel.getCode().IndexOf(BarCode)].ToString();
            int index = StockModel.getCode().IndexOf(BarCode);
            Console.WriteLine("Item " + item + " successfuly inserted!");
            ItemsModel.AddRetrieveStockDB(
                StockModel.getStockID()[index].ToString(),
                BarCode,
                StockModel.getDateReceived()[index].ToString(),
                StockModel.getDateExpiry()[index].ToString(),
                item,
                StockModel.getPrice()[index].ToString(),
                StockModel.getUnitLeft()[index].ToString(),
                unit + ""
            );
            StockModel.getUnitLeft()[index] = int.Parse(StockModel.getUnitLeft()[index].ToString()) - unit;
            EmptyProductInfo();
        }
        public void EmptyProductInfo()
        {
            SetCode.Text = "----";
            SetItemName.Text = "----";
            SetDateExpiry.Text = "----";
            SetDateReceived.Text = "----";
            SetPrice.Text = "----";
            SetUnitLeft.Text = "----";
            StocksList.Text = "";
            AddItemsData();
        }
        public void AddItemsData()
        {
            this.DGV_Items.Rows.Clear();
            for (int count = 0; count < ItemsModel.getItemName().Count; count++)
            {
                int id = int.Parse(ItemsModel.getStockID()[count].ToString());
                string ItemName = ItemsModel.getItemName()[count].ToString();
                string Price = ItemsModel.getPrice()[count].ToString();
                string Unit = ItemsModel.getUnit()[count].ToString();
                string Total = (Double.Parse(ItemsModel.getPrice()[count].ToString()) * int.Parse(ItemsModel.getPrice()[count].ToString())).ToString("N0");
                string POS_item_id = ItemsModel.getPOS_itemID()[count].ToString();
                DGV_Items.Rows.Add(
                    id, ItemName, Price, Unit, Total, POS_item_id 
                );
            }
            if(ItemsModel.getItemName().Count == 0){
                LabelTotal.Text = "----";
            }else{
                SetTotal();
            }
        }
        public void SetPay()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to process transaction?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Update_UnitLeft update_unitLeft = new Update_UnitLeft(
                    ItemsModel,
                    StockModel
                );
                update_unitLeft.UpdateChecker();
                ItemsModel.ClearCart();
                EmptyProductInfo();
                GetStocksModelAndStoreToAutoComplete();
            }
        }
        void SetTotal()
        {
            double SetOut = 0;
            for (int count = 0; count < ItemsModel.getItemName().Count; count++)
            {
                string Price = ItemsModel.getPrice()[count].ToString();
                string Unit = ItemsModel.getUnit()[count].ToString();
                if (Double.TryParse(LabelTotal.Text, out SetOut)){
                    LabelTotal.Text = ((Double.Parse(Price) * int.Parse(Unit))+Double.Parse(LabelTotal.Text)).ToString("N0");
                }else{
                    LabelTotal.Text = (Double.Parse(Price) * int.Parse(Unit)).ToString("N0");
                }
            }
        }
        public Boolean isNoItems()
        {
            bool result = false;
            if (DGV_Items.Rows.Count == 0){
                result = true;
            } else {
                result = false;
            }
            return result;
        }
        public void ClearCart(){
            ItemsModel.ClearCart();
            AddItemsData();
        }
        private void POS_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BT_AddToStack_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}