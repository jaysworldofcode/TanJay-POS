using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TanjayPOS;

namespace WindowsFormsApp1.Data
{
    public sealed class DataHolder
    {
        string ImagePath = @"D:\Source code\Tanjay POS\TanjayPOS\Image";
        MySqlConnection DB_Connection = null;
        private static DataHolder instance = null;
        private static readonly object padlock = new object();

        Stocks stocks;

        static Form MainForm;

        String Username = "admin";
        String Password = "admin";
        String UserFullName = "Juan Dela Cruz";
        public static DataHolder Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataHolder();
                    }
                    return instance;
                }
            }
        }
        DataHolder()
        {
        }
        public void setStocks(Stocks stocks) { this.stocks = stocks; }
        public Stocks getStocks() { return stocks; }
        public string getImagePath()
        {
            return ImagePath;
        }
        public void setDB_Connection(MySqlConnection conn)
        {
            DB_Connection = conn;
        }
        public MySqlConnection getConnection()
        {
            return DB_Connection;
        }
        public void setMainForm(Form set)
        {
            MainForm = set;
        }
        public Form getMainForm()
        {
            return MainForm;
        }
        public String getUsername()
        {
            return Username;
        }
        public String getPassword()
        {
            return Password;
        }
        public String getUserFullName()
        {
            return UserFullName;
        }
    }
}
