using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TanjayPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitSettings();
        }
        void InitSettings()
        {
            new SetPlaceholder(usernameTB, "Username");
            new SetPlaceholder(PasswordBT, "Password");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBT_Click(object sender, EventArgs e)
        {

        }
    }
}
