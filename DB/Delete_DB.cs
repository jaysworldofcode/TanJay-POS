using System;
using WindowsFormsApp1.Data;

namespace TanjayPOS.DB
{
    class Delete_DB
    {
        DataHolder dh = DataHolder.Instance;
        public Delete_DB(
            String tableName, String columnName,
            String ID)
        {
            string query = "DELETE FROM " + tableName + " WHERE " + columnName + " = '" + ID + "'";
            var conn = dh.getConnection();
            var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            reader.Close();
        }
    }
}
