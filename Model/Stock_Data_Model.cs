using System.Collections;

namespace TanjayPOS.Model
{
    public class Stock_Data_Model
    {
        ArrayList stock_id = new ArrayList();
        ArrayList code = new ArrayList();
        ArrayList date_received = new ArrayList();
        ArrayList date_expiry = new ArrayList();
        ArrayList item_name = new ArrayList();
        ArrayList price = new ArrayList();
        ArrayList unit_left = new ArrayList();

        public void AddRetrieveStockDB(
            string stock_id, string code, string date_received, string date_expiry,
            string item_name, string price, string unit_left
            ){
            this.stock_id.Add(stock_id);
            this.code.Add(code);
            this.date_received.Add(date_received);
            this.date_expiry.Add(date_expiry);
            this.item_name.Add(item_name);
            this.price.Add(price);
            this.unit_left.Add(unit_left);
        }
        public void Clear()
        {
            stock_id.Clear();
            code.Clear();
            date_received.Clear();
            date_expiry.Clear();
            item_name.Clear();
            price.Clear();
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
    }
}
