using System;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace TanjayPOS
{
    public partial class MainForm : Form
    {
        DataHolder dh = DataHolder.Instance;
        public MainForm()
        {
            InitializeComponent();
            InitSettings();
        }
        void InitSettings()
        {
            dh.setMainForm(this);
            CB_AccountInfo.Text = dh.getUserFullName();
            //DashboardBT.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\dashboard_main.png");
            POS_BT.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\pos.png");
            StocksBT.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\stocks.png");
            SaleReportBT.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\report.png");
            CreditsBT.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\credit.png");
            Profile.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\user.png");
            Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            Menu.Image = System.Drawing.Image.FromFile(dh.getImagePath() + "\\menu.png");
            //nBT_Logout.Paint += new PaintEventHandler(UserControl1_Paint);
        }
        private void StocksBT_Click(object sender, EventArgs e)
        {
            FunctionsPanel.Controls.Clear();
            Stocks stocks = new Stocks(
                FunctionsPanel.Width,
                FunctionsPanel.Height
            );
            dh.setStocks(stocks);
            FunctionsPanel.Controls.Add(stocks.getMainPanel());
        }
        private void DashboardBT_Click(object sender, EventArgs e)
        {

        }
        private void POS_BT_Click(object sender, EventArgs e)
        {
            FunctionsPanel.Controls.Clear();
            FunctionsPanel.Controls.Add(new POS(
                FunctionsPanel.Width,
                FunctionsPanel.Height
            ).getMainPanel());
        }
        private void CreditsBT_Click(object sender, EventArgs e)
        {
            FunctionsPanel.Controls.Clear();
            FunctionsPanel.Controls.Add(new Credits(
                FunctionsPanel.Width,
                FunctionsPanel.Height
            ).getMainPanel());
        }
        private void SaleReportBT_Click(object sender, EventArgs e)
        {
            FunctionsPanel.Controls.Clear();
            FunctionsPanel.Controls.Add(new SalesReport().getMainPanel());
        }
        private void FunctionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
