using System;
using System.Collections;
using System.Windows;

namespace TanjayPOS.Model
{
    public class POS_Items_Model
    {
        ArrayList stock_id = new ArrayList();
        ArrayList code = new ArrayList();
        ArrayList date_received = new ArrayList();
        ArrayList date_expiry = new ArrayList();
        ArrayList item_name = new ArrayList();
        ArrayList price = new ArrayList();
        ArrayList unit_left = new ArrayList();
        ArrayList unit = new ArrayList();
        ArrayList pos_item_id = new ArrayList();

        int item_auto_increment = 0;

        public void AddTestData()
        {
            this.stock_id.Add("1");
            this.code.Add("11111");
            this.date_received.Add("11/11/11");
            this.date_expiry.Add("11/11/11");
            this.item_name.Add("Bear brand");
            this.price.Add("100");
            this.unit_left.Add("2");
            this.unit.Add("1");
            pos_item_id.Add("ID"+item_auto_increment);
            item_auto_increment++;
        }
        public void DeleteItemStock(int index)
        {
            stock_id.RemoveAt(index);
            code.RemoveAt(index);
            date_received.RemoveAt(index);
            date_expiry.RemoveAt(index);
            item_name.RemoveAt(index);
            price.RemoveAt(index);
            unit_left.RemoveAt(index);
            unit.RemoveAt(index);
            pos_item_id.RemoveAt(index);
        }
        public void ClearCart(){
            Console.WriteLine("POS Items model clear cart");
            stock_id.Clear();
            code.Clear();
            date_received.Clear();
            date_expiry.Clear();
            item_name.Clear();
            price.Clear();
            unit_left.Clear();
            unit.Clear();
            pos_item_id.Clear();
        }
        public void AddRetrieveStockDB(
            string stock_id, string code, string date_received, string date_expiry,
            string item_name, string price, string unit_left, string unit){
            this.stock_id.Add(stock_id);
            this.code.Add(code);
            this.date_received.Add(date_received);
            this.date_expiry.Add(date_expiry);
            this.item_name.Add(item_name);
            this.price.Add(price);
            this.unit_left.Add(unit_left);
            this.unit.Add(unit);
            pos_item_id.Add("ID" + item_auto_increment);
            item_auto_increment++;
        }
        public ArrayList getStockID()
        {
            return stock_id;
        }
        public ArrayList getCode()
        {
            return code;
        }
        public ArrayList getDateReceived()
        {
            return date_received;
        }
        public ArrayList getDateExpiry()
        {
            return date_expiry;
        }
        public ArrayList getItemName()
        {
            return item_name;
        }
        public ArrayList getPrice()
        {
            return price;
        }
        public ArrayList getUnitLeft()
        {
            return unit_left;
        }
        public ArrayList getUnit()
        {
            return unit;
        }
        public ArrayList getPOS_itemID()
        {
            return pos_item_id;
        }
    }
}
