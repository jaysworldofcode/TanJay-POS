using System.Windows.Forms;
using TanjayPOS.DB;
using TanjayPOS.Reusable_Code;

namespace TanjayPOS.Model
{
    class AttachModel_Stock
    {
        Stock_Data_Model StockModel = new Stock_Data_Model();
        public AttachModel_Stock(Panel panel)
        {
            new Stocks_DB().RetrieveStocks(StockModel);
            panel.Controls.Clear();
            for (int x = 0; x < StockModel.getStockID().Count; x++)
            {
                panel.Controls.Add(
                     new StocksInfo(
                        StockModel.getStockID()[x].ToString(), StockModel.getCode()[x].ToString(),
                        StockModel.getDateReceived()[x].ToString(), StockModel.getDateExpiry()[x].ToString(),
                        StockModel.getItemName()[x].ToString(), StockModel.getPrice()[x].ToString(),
                        StockModel.getUnitLeft()[x].ToString(), panel.Width, 100, panel.Controls.Count,
                        panel)
                     );
            }
           // panel.Height = panel.Controls.Count * 100;
        }
    }
}
