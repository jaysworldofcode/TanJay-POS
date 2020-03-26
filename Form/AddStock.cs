using System;
using System.Windows.Forms;
using TanjayPOS.DB;
using TanjayPOS.Reusable_Code;
using WindowsFormsApp1.Data;

namespace TanjayPOS
{
    public partial class AddStock : Form
    {
        DataHolder dh = DataHolder.Instance;
        AddStock_DB db_controller = new AddStock_DB();
        String Title = "";

        EmptyFieldChecker EmptyFieldChecker = new EmptyFieldChecker("Some input is empty!");

        String STOCK_ID, BARCODE, DATE_RECEIVED, DATE_EXPIRY, ITEM_NAME,
               PRICE, UNIT_LEFT;

        public AddStock(String Title)
        {
            InitializeComponent();
            this.Title = Title;
            InitSettings();
        }
        public void SetTextIfUpdate(
            String STOCK_ID, String BARCODE, String DATE_RECEIVED, String DATE_EXPIRY,
            String ITEM_NAME, String PRICE, String UNIT_LEFT)
        {
            this.STOCK_ID = STOCK_ID;
            this.BARCODE = BARCODE;
            this.DATE_RECEIVED = DATE_RECEIVED;
            this.DATE_EXPIRY = DATE_EXPIRY;
            this.ITEM_NAME = ITEM_NAME;
            this.PRICE = PRICE;
            this.UNIT_LEFT = UNIT_LEFT;

            Barcode_TF.Text = BARCODE;
            ItemName.Text = ITEM_NAME;
            Price.Text = PRICE;
            UnitLeft.Text = UNIT_LEFT;
            Date_Receive.Value = DateTime.Parse(Fix_Parsing_Date_Format(DATE_RECEIVED.Trim()));
            Date_Expiry.Value = DateTime.Parse(Fix_Parsing_Date_Format(DATE_EXPIRY.Trim()));
        }
        String Fix_Parsing_Date_Format(string date)
        {
            String[] SplitDate = date.Split('/');
            return SplitDate[1]+"/"+SplitDate[0]+"/"+SplitDate[2];            
        }
        void InitSettings()
        {
            this.Text = Title;
            dh.getMainForm().Enabled = false;

            this.ControlBox = false;
            EmptyFieldChecker.AddTextFieldToBeCheck(Price);
            EmptyFieldChecker.AddTextFieldToBeCheck(UnitLeft);

            Price.KeyPress += new KeyPressEventHandler(PriceKeyListener);
            UnitLeft.KeyPress += new KeyPressEventHandler(UnitLeftKeyListener);
        }
        private void PriceKeyListener(object sender, KeyPressEventArgs e)
        {
            new TextBoxAcceptsNumberOnly(sender, e);
        }
        private void UnitLeftKeyListener(object sender, KeyPressEventArgs e)
        {
            new TextBoxAcceptsNumberOnly(sender, e);
        }
        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("tester");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (EmptyFieldChecker.IsSomeTextBoxIsEmpty() == false)
            {
                if (String.IsNullOrEmpty(STOCK_ID) || String.IsNullOrWhiteSpace(STOCK_ID)){
                    db_controller.AddStocks(
                        Barcode_TF.Text,
                        DateTime.Parse(Date_Receive.Text).ToString("MM/dd/yyyy"),
                        DateTime.Parse(Date_Expiry.Text).ToString("MM/dd/yyyy"),
                        ItemName.Text,
                        Price.Text,
                        UnitLeft.Text
                        );
                    dh.getStocks().SetStockList();
                } else{

                }
                this.Close();
                dh.getMainForm().Enabled = true;
                dh.getMainForm().BringToFront();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            dh.getMainForm().Enabled = true;
            dh.getMainForm().BringToFront();
        }
    }
}
