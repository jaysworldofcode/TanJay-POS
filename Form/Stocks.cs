using System;
using System.Drawing;
using System.Windows.Forms;
using TanjayPOS.Model;
using WindowsFormsApp1.Data;

namespace TanjayPOS
{
    public partial class Stocks : Form
    {
        /* Creating test data in stock data
         *StockData StockData = new StockData();
         */
        DataHolder dh = DataHolder.Instance;
        public Stocks(int width, int height)
        {
            InitializeComponent();
            InitSettings();
        }
        public Panel getMainPanel()
        {
            return MainPanel;
        }
        void InitSettings()
        {
            // ListPanel.Resize += new System.EventHandler(this.Layout_Resize);
            SetStockList();
            NewStocktBT.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\add.png");
        }
        public void SetStockList()
        {
            RowsPanel.Controls.Clear();
            new AttachModel_Stock(RowsPanel); //Attach model to stock view
            ListPanel.HorizontalScroll.Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Layout_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
            RowsPanel.Width = ListPanel.Width;
        }
        private void ListPanel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void NewStocktBT_Click_1(object sender, EventArgs e)
        {
            new AddStock("New Stock").Show();
        }
    }
}
