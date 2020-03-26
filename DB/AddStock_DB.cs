using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace TanjayPOS.DB
{
    class AddStock_DB
    {
        DataHolder dh = DataHolder.Instance;

        public void AddStocks(
                String BARCODE,
                String DATE_RECEIVED,
                String DATE_EXPIRY,
                String ITEM_NAME,
                String PRICE,
                String UNIT_LEFT
        ){
            MySqlConnection DB_Connection = dh.getConnection();
            String sql = "INSERT INTO STOCKS_TABLE (" +
                "BARCODE, DATE_RECEIVED," +
                "DATE_EXPIRY, ITEM_NAME," +
                "PRICE, UNIT_LEFT) values(" +
                "?,?,?,?,?,?)";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DB_Connection;
                cmd.CommandText = sql;

                cmd.Parameters.Add("BARCODE", MySqlDbType.VarChar).Value = BARCODE;
                cmd.Parameters.Add("DATE_RECEIVED", MySqlDbType.VarChar).Value = DATE_RECEIVED;
                cmd.Parameters.Add("DATE_EXPIRY", MySqlDbType.VarChar).Value = DATE_EXPIRY;
                cmd.Parameters.Add("ITEM_NAME", MySqlDbType.VarChar).Value = ITEM_NAME;
                cmd.Parameters.Add("PRICE", MySqlDbType.VarChar).Value = PRICE;
                cmd.Parameters.Add("UNIT_LEFT", MySqlDbType.VarChar).Value = UNIT_LEFT;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            Console.WriteLine("Successfuly added " + ITEM_NAME + " to stocks");
        }
    }
}
