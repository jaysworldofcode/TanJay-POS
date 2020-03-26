using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace TanjayPOS.DB
{
    class POS_DB
    {
        DataHolder dh = DataHolder.Instance;
        MySqlConnection conn = null;
        public POS_DB()
        {
            conn = dh.getConnection();
        }
        public void UpdateDataUnitLeft(string barcode, string unit_left)
        {
            if (unit_left.Equals("0"))
            {
                string query = "UPDATE stocks_table SET UNIT_LEFT=@UnitLeft, EMPTY_EXPIRY=@ExpiryDate WHERE BARCODE =@Barcode";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@UnitLeft", unit_left);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("@ExpiryDate", DateTime.Now.AddDays(6).ToString());
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            } else {
                string query = "UPDATE stocks_table SET UNIT_LEFT=@UnitLeft WHERE BARCODE =@Barcode";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@UnitLeft", unit_left);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }
        public void AddToCredit(
            string CUSTOMER_ID,
            string ITEM_NAME,
            string CODE,
            string PRICE,
            string DATE_ISSUED,
            string UNIT,
            string STATUS,
            string CASHIER,
            string DESCRIPTION
            ){
            String sql = "INSERT INTO CREDIT_LOG (" +
                "CUSTOMER_ID, ITEM_NAME," +
                "CODE, PRICE," +
                "DATE_ISSUED, UNIT," +
                "STATUS, CASHIER, DESCRIPTION) values(" +
                "?,?,?,?,?,?,?,?,?)";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.Add("CUSTOMER_ID", MySqlDbType.VarChar).Value = CUSTOMER_ID;
                cmd.Parameters.Add("ITEM_NAME", MySqlDbType.VarChar).Value = ITEM_NAME;
                cmd.Parameters.Add("CODE", MySqlDbType.VarChar).Value = CODE;
                cmd.Parameters.Add("PRICE", MySqlDbType.VarChar).Value = PRICE;
                cmd.Parameters.Add("DATE_ISSUED", MySqlDbType.VarChar).Value = DATE_ISSUED;
                cmd.Parameters.Add("UNIT", MySqlDbType.VarChar).Value = UNIT;
                cmd.Parameters.Add("STATUS", MySqlDbType.VarChar).Value = STATUS;
                cmd.Parameters.Add("CASHIER", MySqlDbType.VarChar).Value = CASHIER;
                cmd.Parameters.Add("DESCRIPTION", MySqlDbType.VarChar).Value = DESCRIPTION;
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
