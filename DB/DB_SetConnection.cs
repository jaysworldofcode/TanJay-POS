using System;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.Data;

namespace TanjayPOS.DB
{
    //DB name 'pos_tanjay'
    class DB_SetConnection
    {
        DataHolder dh = DataHolder.Instance;
        MySqlConnection conn;
        public void CreateConnection(){
            string MyConStr = "Server=localhost;Database=pos_tanjay;Uid=root;Pwd=root;";

            conn = new MySqlConnection(MyConStr);
            dh.setDB_Connection(conn);
            conn.Open();
            Console.WriteLine("Database successfuly connected");
        }
    }
}
