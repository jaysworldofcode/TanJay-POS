using System;
using System.Windows.Forms;
using TanjayPOS.DB;
using TanjayPOS.Model;
using Microsoft.VisualBasic;
using TanjayPOS.Reusable_Code;

namespace TanjayPOS.Controller
{
    class POS_Controller
    {
        TextBox StocksList;
        Stock_Data_Model StockModel;
        POS_Items_Model POS_Model;
        POS pos;
        public void SetTextBoxStocksList(TextBox StocksList) { this.StocksList = StocksList; }
        public void SetStockModel(Stock_Data_Model StockModel) { this.StockModel = StockModel; }
        public void SetPOS_Model(POS_Items_Model POS_Model) { this.POS_Model = POS_Model; }
        public void SetView(POS pos) { this.pos = pos; }
        public void GetStockData(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!String.IsNullOrEmpty(StocksList.Text) && StockModel.getCode().Contains(StocksList.Text.Split('/')[0])){
                    pos.SetCode.Text = StocksList.Text.Split('/')[0];
                    pos.SetItemName.Text = StockModel.getItemName()[StockModel.getCode().IndexOf(StocksList.Text.Split('/')[0])].ToString();
                    pos.SetDateExpiry.Text = StockModel.getDateExpiry()[StockModel.getCode().IndexOf(StocksList.Text.Split('/')[0])].ToString();
                    pos.SetDateReceived.Text = StockModel.getDateReceived()[StockModel.getCode().IndexOf(StocksList.Text.Split('/')[0])].ToString();
                    pos.SetPrice.Text = StockModel.getPrice()[StockModel.getCode().IndexOf(StocksList.Text.Split('/')[0])].ToString();
                    pos.SetUnitLeft.Text = StockModel.getUnitLeft()[StockModel.getCode().IndexOf(StocksList.Text.Split('/')[0])].ToString();
                }
            }
        }
        bool IsUnitLeftEnough(int UnitLeft, int UnitToBeDelete)
        {
            bool result = false;
            if((UnitLeft- UnitToBeDelete) < 0){
                result = false;
            }else{
                result = true;
            }
            return result;
        }
        public void RegisterCustomer(object sender, System.EventArgs e)
        {
            if (!(POS_Model.getItemName().Count == 0))
            {
                MessageBox.Show("Please finish all transaction first");
            }
        }
        public void AddToItems(object sender, System.EventArgs e)
        {
            string items = Interaction.InputBox("Enter total items", "", "1", 100, 100);
            int a = 0;
            if (int.TryParse(items, out a))
            {
                if (IsUnitLeftEnough(int.Parse(pos.SetUnitLeft.Text),int.Parse(items)))
                {
                    pos.InsertItem(pos.SetCode.Text, int.Parse(items));
                    pos.AddItemsData();
                } else {
                    MessageBox.Show("Unit left not enough");
                }
            } else{
                MessageBox.Show("Please enter a number");
            }
        }
        public void Pay(object sender, System.EventArgs e)
        {
            if (pos.isNoItems())
            {
                MessageBox.Show("No items");
            } else
            {
                pos.SetPay();
            }
        }
        public void AddToCredit(object sender, System.EventArgs e)
        {
            if (pos.isNoItems()){
                MessageBox.Show("No items, cannot append to credit");
            } else {
                Add_Credit_UI add_credit = new Add_Credit_UI();
                add_credit.setItemsModel(POS_Model);
                add_credit.setStockModel(StockModel);
                add_credit.setPOS(pos);
                add_credit.Show();
            }
        }
        public void DeleteCart(object sender, System.EventArgs e){
            try
            {
                string item_name = pos.DGV_Items.Rows[pos.DGV_Items.SelectedRows[0].Index].Cells[5].FormattedValue.ToString().Trim();
                int IndexToStockModel = StockModel.getCode().IndexOf(
                    POS_Model.getCode()[
                        POS_Model.getPOS_itemID().IndexOf(
                            pos.DGV_Items.Rows[pos.DGV_Items.SelectedRows[0].Index].Cells[5].FormattedValue.ToString())
                        ]
                    ); 
                StockModel.getUnitLeft()[IndexToStockModel] = 
                    int.Parse(StockModel.getUnitLeft()[StockModel.getStockID().IndexOf(pos.DGV_Items.Rows[pos.DGV_Items.SelectedRows[0].Index].Cells[0].FormattedValue.ToString())].ToString())+
                    int.Parse(pos.DGV_Items.Rows[pos.DGV_Items.SelectedRows[0].Index].Cells[3].FormattedValue.ToString());
                POS_Model.DeleteItemStock(
                    POS_Model.getPOS_itemID().IndexOf(
                          pos.DGV_Items.Rows[pos.DGV_Items.SelectedRows[0].Index].Cells[5].FormattedValue.ToString().Trim()
                        )
                    );
                MessageBox.Show("Item "+ item_name + " successfuly remove!");
                pos.AddItemsData();
            }
            catch (Exception ex){
                MessageBox.Show("Please choose a row");
            }
            pos.EmptyProductInfo();
        }
        public void ClearCart(object sender, System.EventArgs e)
        {
            pos.ClearCart();
            pos.EmptyProductInfo();
        }
    }
}
