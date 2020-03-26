using System.Collections;

namespace TanjayPOS.Test_Files
{

    public class StockData
    {
        ArrayList stock_id = new ArrayList();
        ArrayList code = new ArrayList();
        ArrayList date_received = new ArrayList();
        ArrayList date_expiry = new ArrayList();
        ArrayList item_name = new ArrayList();
        ArrayList price = new ArrayList();
        ArrayList unit_left = new ArrayList();

        public StockData()
        {
            stock_id.Add("1111");
            stock_id.Add("2222");
            stock_id.Add("3333");
            stock_id.Add("4444");
            stock_id.Add("5555");
            stock_id.Add("6666");
            stock_id.Add("7777");
            stock_id.Add("8888");
            stock_id.Add("9999");
            stock_id.Add("0000");

            code.Add("1111xxxx");
            code.Add("2222xxxx");
            code.Add("3333xxxx");
            code.Add("4444xxxx");
            code.Add("5555xxxx");
            code.Add("6666xxxx");
            code.Add("7777xxxx");
            code.Add("8888xxxx");
            code.Add("9999xxxx");
            code.Add("0000xxxx");

            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");
            date_received.Add("10/10/2019");

            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");
            date_expiry.Add("10/10/2020");

            item_name.Add("Silver Swan");
            item_name.Add("Datu Puti");
            item_name.Add("Pancit Canton");
            item_name.Add("Coca cola 1L");
            item_name.Add("Sprite 1L");
            item_name.Add("Quaker Oats");
            item_name.Add("Sunsilk 1pack");
            item_name.Add("Pampers");
            item_name.Add("Bear Brand 100g");
            item_name.Add("Kopiko 1pack");

            price.Add("12.00");
            price.Add("10.00");
            price.Add("15.00");
            price.Add("30.00");
            price.Add("30.00");
            price.Add("88.00");
            price.Add("65.00");
            price.Add("40.00");
            price.Add("25.00");
            price.Add("75.00");

            unit_left.Add("10");
            unit_left.Add("5");
            unit_left.Add("15");
            unit_left.Add("20");
            unit_left.Add("5");
            unit_left.Add("15");
            unit_left.Add("20");
            unit_left.Add("10");
            unit_left.Add("20");
            unit_left.Add("20");
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
