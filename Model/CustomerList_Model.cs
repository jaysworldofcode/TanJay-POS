
using System.Collections;

namespace TanjayPOS.Model
{
    class CustomerList_Model
    {
        ArrayList customer_id = new ArrayList();
        ArrayList customer_name = new ArrayList();
        ArrayList customer_address = new ArrayList();
        ArrayList customer_contact_number = new ArrayList();

        public void AddRetrieveCustomerDB(
            string customer_id,
            string customer_name,
            string customer_address,
            string customer_contact_number)
        {
            this.customer_id.Add(customer_id);
            this.customer_name.Add(customer_name);
            this.customer_address.Add(customer_address);
            this.customer_contact_number.Add(customer_contact_number);
        }
        public void Clear()
        {
            customer_id.Clear();
            customer_name.Clear();
            customer_address.Clear();
            customer_contact_number.Clear();
        }
        public ArrayList getCustomer_id()
        {
            return customer_id;
        }
        public ArrayList getCustomer_Name()
        {
            return customer_name;
        }
        public ArrayList getCustomerAddress()
        {
            return customer_address;
        }
        public ArrayList getCustomerContactNumber()
        {
            return customer_contact_number;
        }
    }
}
