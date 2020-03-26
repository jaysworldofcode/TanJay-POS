using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TanjayPOS.Model;
using WindowsFormsApp1.Data;

namespace TanjayPOS.DB
{
    class Credits_DB
    {
        DataHolder dh = DataHolder.Instance;
        public void AddCustomer(
                String CUSTOMER_NAME,
                String CUSTOMER_ADDRESS,
                String CUSTOMER_CONTACT_NUMBER )
        {
            MySqlConnection DB_Connection = dh.getConnection();
            String sql = "INSERT INTO CUSTOMER_TABLE (" +
                "CUSTOMER_NAME, CUSTOMER_ADDRESS," +
                "CUSTOMER_CONTACT_NUMBER) values(" +
                "?,?,?)";
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DB_Connection;
                cmd.CommandText = sql;

                cmd.Parameters.Add("CUSTOMER_NAME", MySqlDbType.VarChar).Value = CUSTOMER_NAME;
                cmd.Parameters.Add("CUSTOMER_ADDRESS", MySqlDbType.VarChar).Value = CUSTOMER_ADDRESS;
                cmd.Parameters.Add("CUSTOMER_CONTACT_NUMBER", MySqlDbType.VarChar).Value = CUSTOMER_CONTACT_NUMBER;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
            MessageBox.Show("Customer " + CUSTOMER_NAME + " successfuly added!");
        }
        public void RetrieveCustomerBalance(CreditList_Model model, string customer_id)
        {
            string query = "SELECT * FROM CREDIT_LOG WHERE CUSTOMER_ID='" + customer_id+"'";

            var conn = dh.getConnection();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var CREDIT_ID = reader["CREDIT_ID"];
                var CUSTOMER_ID = reader["CUSTOMER_ID"];
                var ITEM_NAME = reader["ITEM_NAME"];
                var CODE = reader["CODE"];
                var PRICE = reader["PRICE"];
                var DATE_ISSUED = reader["DATE_ISSUED"];
                var UNIT = reader["UNIT"];
                var STATUS = reader["STATUS"];
                var CASHIER = reader["CASHIER"];
                var DESCRIPTION = reader["DESCRIPTION"];

                model.AddCreditListDB(
                    CREDIT_ID.ToString(),
                    CUSTOMER_ID.ToString(),
                    ITEM_NAME.ToString(),
                    CODE.ToString(),
                    PRICE.ToString(),
                    DATE_ISSUED.ToString(),
                    UNIT.ToString(),
                    STATUS.ToString(),
                    CASHIER.ToString(),
                    DESCRIPTION.ToString()
                    );
            }
            reader.Close();
        }
        public void Delete_Customer(string customer_id)
        {
            string query = "DELETE FROM CUSTOMER_TABLE WHERE CUSTOMER_ID ="+customer_id+"";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = dh.getConnection();
            cmd.ExecuteNonQuery();
        }
        public void SetItemAsPaid(string id)
        {
            string query = "UPDATE CREDIT_LOG SET STATUS = 'Paid' WHERE CREDIT_ID = "+id+"";
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = dh.getConnection();
                cmd.ExecuteNonQuery();
        }
        public void UpdateCustomerInfo(
            string CUSTOMER_ID,
            string CUSTOMER_NAME,
            string CUSTOMER_ADDRESS,
            string CUSTOMER_CONTACT_NUMBER
            )
        {
            string query = "UPDATE CUSTOMER_TABLE SET " +
                "CUSTOMER_NAME = '" + CUSTOMER_NAME + "'," +
                "CUSTOMER_ADDRESS = '" + CUSTOMER_ADDRESS + "'," +
                "CUSTOMER_CONTACT_NUMBER = '" + CUSTOMER_CONTACT_NUMBER + "'" +
                " WHERE CUSTOMER_ID = " + CUSTOMER_ID + "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = dh.getConnection();
            cmd.ExecuteNonQuery();
        }
        public void RetrieveCustomerList(CustomerList_Model model)
        {
            string query = "SELECT * FROM CUSTOMER_TABLE";

            var conn = dh.getConnection();

            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var customer_id = reader["CUSTOMER_ID"];
                var customer_name = reader["CUSTOMER_NAME"];
                var customer_address = reader["CUSTOMER_ADDRESS"];
                var customer_contact_number = reader["CUSTOMER_CONTACT_NUMBER"];

                model.AddRetrieveCustomerDB(
                    customer_id.ToString(),
                    customer_name.ToString(),
                    customer_address.ToString(),
                    customer_contact_number.ToString());
            }
            reader.Close();
        }
    }
}
