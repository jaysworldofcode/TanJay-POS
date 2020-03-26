using System;
using System.Drawing;
using System.Windows.Forms;
using TanjayPOS.DB;
using TanjayPOS.Model;
using WindowsFormsApp1.Data;

namespace TanjayPOS.Reusable_Code
{

    public class StocksInfo : Panel
    {
        DataHolder dh = DataHolder.Instance;
        String stock_id = "";
        String code = "";
        String date_received = "";
        String date_expiry = "";
        String item_name = "";
        String price = "";
        String unit_left = "";
        Button UpdateBT, DeleteBT;
        Label PriceAndUnitLeftLabel, ProductnameLabel,
              DateReceivedLabelAndDateExpiryLabel, CodeLabel;
        int countRows = 0;
        Panel panel;
        public StocksInfo(
            String stock_id, String code, String date_received, String date_expiry,
            String item_name, String price, String unit_left,
            int PanelWidth, int PanelHeight, int countRows,Panel panel)
        {
            this.stock_id = stock_id;
            this.code = code;
            this.date_received = date_received;
            this.date_expiry = date_expiry;
            this.item_name = item_name;
            this.price = price;
            this.unit_left = unit_left;
            this.panel = panel;
            Console.WriteLine("Append in table " + item_name);
            this.countRows = countRows;
            initPanel(PanelWidth, PanelHeight);
            setUI();
        }

        void initPanel(int Width, int Height)
        {
            this.Size = new Size(Width, Height);
            this.BackColor = Color.White;
            this.Location = new Point(0, (100 * countRows));
            this.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Console.WriteLine("Item " + item_name + ", X = " + 0 + " And Y = " + (100 * countRows));
        }
        void setUI()
        {
            PriceAndUnitLeftLabel = new Label();
            PriceAndUnitLeftLabel.Text = price + "/" + unit_left;
            PriceAndUnitLeftLabel.Size = new Size(100, 50);
            PriceAndUnitLeftLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            PriceAndUnitLeftLabel.BackColor = System.Drawing.Color.Transparent;
            new ChangeListenerPanelToLabelPosition(this, PriceAndUnitLeftLabel, 300,true,0,0);
            this.Controls.Add(PriceAndUnitLeftLabel);

            ProductnameLabel = new Label();
            ProductnameLabel.Text = item_name+"";
            ProductnameLabel.Size = new Size(400, 30);
            ProductnameLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            ProductnameLabel.BackColor = System.Drawing.Color.Transparent;
            new ChangeListenerPanelToLabelPosition(this, ProductnameLabel, 0, false,0,20);
            this.Controls.Add(ProductnameLabel);

            DateReceivedLabelAndDateExpiryLabel = new Label();
            DateReceivedLabelAndDateExpiryLabel.Text = date_received + " - " + date_expiry;
            DateReceivedLabelAndDateExpiryLabel.Size = new Size(400, 15);
            DateReceivedLabelAndDateExpiryLabel.Font = new Font("Arial", 10, FontStyle.Italic);
            DateReceivedLabelAndDateExpiryLabel.BackColor = System.Drawing.Color.Transparent;
            new ChangeListenerPanelToLabelPosition(this, DateReceivedLabelAndDateExpiryLabel, 0, false, 0, 0);
            this.Controls.Add(DateReceivedLabelAndDateExpiryLabel);

            CodeLabel = new Label();
            CodeLabel.Text = code+"";
            CodeLabel.Size = new Size(400, 15);
            CodeLabel.Font = new Font("Arial", 10, FontStyle.Italic | FontStyle.Bold);
            CodeLabel.BackColor = System.Drawing.Color.Transparent;
            new ChangeListenerPanelToLabelPosition(this, CodeLabel, 0, false, 20, 0);
            this.Controls.Add(CodeLabel);

            UpdateBT = new Button();
            UpdateBT.Size = new Size(100, 40);
            new ChangeListenerPanelToButtonPosition(this, UpdateBT, 180);
            UpdateBT.BackColor = Color.SkyBlue;
            UpdateBT.Text = "Update";
            UpdateBT.Click += new System.EventHandler(this.UpdateStock);
            this.Controls.Add(UpdateBT);

            DeleteBT = new Button();
            DeleteBT.Size = new Size(100, 40);
            new ChangeListenerPanelToButtonPosition(this, DeleteBT, 60);
            DeleteBT.BackColor = Color.Red;
            DeleteBT.Text = "Delete";
            DeleteBT.Click += new System.EventHandler(this.DeleteStock);
            this.Controls.Add(DeleteBT);
        }
        private void UpdateStock(object sender, System.EventArgs e)
        {
            AddStock stock = new AddStock("Update stock");
            stock.SetTextIfUpdate(
                    stock_id, code, date_received, date_expiry,
                    item_name, price, unit_left
                );
            new AttachModel_Stock(panel);
            stock.Show();
        }
        private void DeleteStock(object sender, System.EventArgs e)
        {
            new Delete_DB("STOCKS_TABLE", "STOCK_ID", stock_id);
            new AttachModel_Stock(panel);
            MessageBox.Show(item_name+" sucessfuly deleted!");
        }
    }
}
