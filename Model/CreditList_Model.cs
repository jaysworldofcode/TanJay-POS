using System.Collections;

namespace TanjayPOS.Model
{
    public class CreditList_Model
    {
        ArrayList credit_id = new ArrayList();
        ArrayList customer_id = new ArrayList();
        ArrayList item_name = new ArrayList();
        ArrayList code = new ArrayList();
        ArrayList price = new ArrayList();
        ArrayList date_issued = new ArrayList();
        ArrayList unit = new ArrayList();
        ArrayList status = new ArrayList();
        ArrayList cashier = new ArrayList();
        ArrayList description = new ArrayList();

        public void AddCreditListDB(
            string credit_id,
            string customer_id,
            string item_name,
            string code,
            string price,
            string date_issued,
            string unit,
            string status,
            string cashier,
            string description)
        {
            this.credit_id.Add(credit_id);
            this.customer_id.Add(customer_id);
            this.item_name.Add(item_name);
            this.code.Add(code);
            this.price.Add(price);
            this.date_issued.Add(date_issued);
            this.unit.Add(unit);
            this.status.Add(status);
            this.cashier.Add(cashier);
            this.description.Add(description);
        }
        public void Clear()
        {
            credit_id.Clear();
            customer_id.Clear();
            item_name.Clear();
            code.Clear();
            price.Clear();
            date_issued.Clear();
            unit.Clear();
            status.Clear();
            cashier.Clear();
        }
        public ArrayList getCredit_ID()
        {
            return credit_id;
        }
        public ArrayList getCustomer_ID()
        {
            return customer_id;
        }
        public ArrayList getItem_Name()
        {
            return item_name;
        }
        public ArrayList getCode()
        {
            return code;
        }
        public ArrayList getPrice()
        {
            return price;
        }
        public ArrayList getDate_Issued()
        {
            return date_issued;
        }
        public ArrayList getUnit()
        {
            return unit;
        }
        public ArrayList getStatus()
        {
            return status;
        }
        public ArrayList getCashier()
        {
            return cashier;
        }
        public ArrayList getDescription()
        {
            return description;
        }
    }
}
