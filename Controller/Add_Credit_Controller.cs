namespace TanjayPOS.Controller
{
    class Add_Credit_Controller
    {
        Add_Credit_UI add_credit;
        public Add_Credit_Controller(Add_Credit_UI add_credit)
        {
            this.add_credit = add_credit;
        }
        public void AddCredit(object sender, System.EventArgs e)
        {
            add_credit.AppendCredit();
            add_credit.Close();
        }
        public void Cancel(object sender, System.EventArgs e)
        {
            add_credit.Close();
        }
    }
}
