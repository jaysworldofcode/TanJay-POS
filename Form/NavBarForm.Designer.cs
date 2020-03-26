namespace TanjayPOS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.PictureBox();
            this.CB_AccountInfo = new System.Windows.Forms.ComboBox();
            this.POS_BT = new System.Windows.Forms.Button();
            this.StocksBT = new System.Windows.Forms.Button();
            this.SaleReportBT = new System.Windows.Forms.Button();
            this.CreditsBT = new System.Windows.Forms.Button();
            this.FunctionsPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.Profile);
            this.flowLayoutPanel1.Controls.Add(this.CB_AccountInfo);
            this.flowLayoutPanel1.Controls.Add(this.POS_BT);
            this.flowLayoutPanel1.Controls.Add(this.StocksBT);
            this.flowLayoutPanel1.Controls.Add(this.SaleReportBT);
            this.flowLayoutPanel1.Controls.Add(this.CreditsBT);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 759);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 36);
            this.panel2.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Black;
            this.Menu.Location = new System.Drawing.Point(214, -6);
            this.Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Menu.Size = new System.Drawing.Size(47, 45);
            this.Menu.TabIndex = 2;
            this.Menu.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Profile.Location = new System.Drawing.Point(3, 45);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(264, 185);
            this.Profile.TabIndex = 1;
            this.Profile.TabStop = false;
            // 
            // CB_AccountInfo
            // 
            this.CB_AccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_AccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_AccountInfo.FormattingEnabled = true;
            this.CB_AccountInfo.Items.AddRange(new object[] {
            "Change password",
            "Logout"});
            this.CB_AccountInfo.Location = new System.Drawing.Point(3, 236);
            this.CB_AccountInfo.Name = "CB_AccountInfo";
            this.CB_AccountInfo.Size = new System.Drawing.Size(264, 21);
            this.CB_AccountInfo.TabIndex = 5;
            this.CB_AccountInfo.Text = "%USERNAME%";
            // 
            // POS_BT
            // 
            this.POS_BT.BackColor = System.Drawing.Color.White;
            this.POS_BT.FlatAppearance.BorderSize = 0;
            this.POS_BT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POS_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS_BT.ForeColor = System.Drawing.Color.Black;
            this.POS_BT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.POS_BT.Location = new System.Drawing.Point(0, 260);
            this.POS_BT.Margin = new System.Windows.Forms.Padding(0);
            this.POS_BT.Name = "POS_BT";
            this.POS_BT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.POS_BT.Size = new System.Drawing.Size(267, 88);
            this.POS_BT.TabIndex = 2;
            this.POS_BT.Text = "POS";
            this.POS_BT.UseVisualStyleBackColor = false;
            this.POS_BT.Click += new System.EventHandler(this.POS_BT_Click);
            // 
            // StocksBT
            // 
            this.StocksBT.BackColor = System.Drawing.Color.White;
            this.StocksBT.FlatAppearance.BorderSize = 0;
            this.StocksBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StocksBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksBT.ForeColor = System.Drawing.Color.Black;
            this.StocksBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StocksBT.Location = new System.Drawing.Point(0, 348);
            this.StocksBT.Margin = new System.Windows.Forms.Padding(0);
            this.StocksBT.Name = "StocksBT";
            this.StocksBT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.StocksBT.Size = new System.Drawing.Size(267, 88);
            this.StocksBT.TabIndex = 3;
            this.StocksBT.Text = "STOCKS";
            this.StocksBT.UseVisualStyleBackColor = false;
            this.StocksBT.Click += new System.EventHandler(this.StocksBT_Click);
            // 
            // SaleReportBT
            // 
            this.SaleReportBT.BackColor = System.Drawing.Color.White;
            this.SaleReportBT.FlatAppearance.BorderSize = 0;
            this.SaleReportBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleReportBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleReportBT.ForeColor = System.Drawing.Color.Black;
            this.SaleReportBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaleReportBT.Location = new System.Drawing.Point(0, 436);
            this.SaleReportBT.Margin = new System.Windows.Forms.Padding(0);
            this.SaleReportBT.Name = "SaleReportBT";
            this.SaleReportBT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SaleReportBT.Size = new System.Drawing.Size(267, 88);
            this.SaleReportBT.TabIndex = 4;
            this.SaleReportBT.Text = "SALE REPORT";
            this.SaleReportBT.UseVisualStyleBackColor = false;
            this.SaleReportBT.Click += new System.EventHandler(this.SaleReportBT_Click);
            // 
            // CreditsBT
            // 
            this.CreditsBT.BackColor = System.Drawing.Color.White;
            this.CreditsBT.FlatAppearance.BorderSize = 0;
            this.CreditsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsBT.ForeColor = System.Drawing.Color.Black;
            this.CreditsBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreditsBT.Location = new System.Drawing.Point(0, 524);
            this.CreditsBT.Margin = new System.Windows.Forms.Padding(0);
            this.CreditsBT.Name = "CreditsBT";
            this.CreditsBT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CreditsBT.Size = new System.Drawing.Size(267, 88);
            this.CreditsBT.TabIndex = 7;
            this.CreditsBT.Text = "CREDITS";
            this.CreditsBT.UseVisualStyleBackColor = false;
            this.CreditsBT.Click += new System.EventHandler(this.CreditsBT_Click);
            // 
            // FunctionsPanel
            // 
            this.FunctionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionsPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FunctionsPanel.Location = new System.Drawing.Point(267, 0);
            this.FunctionsPanel.Name = "FunctionsPanel";
            this.FunctionsPanel.Size = new System.Drawing.Size(818, 762);
            this.FunctionsPanel.TabIndex = 1;
            this.FunctionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FunctionsPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.FunctionsPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "MainForm";
            this.Text = "NavBarForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button POS_BT;
        private System.Windows.Forms.Button StocksBT;
        private System.Windows.Forms.Panel FunctionsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CB_AccountInfo;
        private System.Windows.Forms.PictureBox Profile;
        private System.Windows.Forms.Button CreditsBT;
        private System.Windows.Forms.Button SaleReportBT;
        private System.Windows.Forms.Button Menu;
    }
}