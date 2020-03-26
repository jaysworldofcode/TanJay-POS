using System;
using TanjayPOS.Model;
using WindowsFormsApp1.Data;

namespace TanjayPOS.DB
{
    class Stocks_DB
    {
        DataHolder dh = DataHolder.Instance;
        public void RetrieveStocks(Stock_Data_Model model)
        {
            string query = "SELECT * FROM STOCKS_TABLE";

            var conn = dh.getConnection();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var stock_id = reader["STOCK_ID"];
                var barcode = reader["BARCODE"];
                var date_received = reader["DATE_RECEIVED"];
                var date_expiry = reader["DATE_EXPIRY"];
                var item_name = reader["ITEM_NAME"];
                var price = reader["PRICE"];
                var unit_left = reader["UNIT_LEFT"];

                Console.WriteLine("Stock added: "+
                    stock_id + " // " + barcode + " // " + date_received + " // " +
                    date_expiry + " // " + item_name + " // " + price + " // " +
                    price);
                model.AddRetrieveStockDB(
                    stock_id.ToString(), barcode.ToString(), date_received.ToString(),
                    date_expiry.ToString(), item_name.ToString(), price.ToString(),
                    unit_left.ToString()
                    );
            }
            reader.Close();
        }
    }
}
