namespace TanjayPOS
{
    partial class Credits
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
            this.Credit_Panel = new System.Windows.Forms.Panel();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_TotalBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_SetAsPaidAll = new System.Windows.Forms.Button();
            this.CB_FilterType = new System.Windows.Forms.ComboBox();
            this.DGV_BalanceList = new System.Windows.Forms.DataGridView();
            this.CREDIT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ISSUED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASHIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_ContactNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TB_Address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TB_CustomerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BT_Add = new System.Windows.Forms.Button();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Search = new System.Windows.Forms.Button();
            this.CB_CustomersList = new System.Windows.Forms.ComboBox();
            this.Credit_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BalanceList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Credit_Panel
            // 
            this.Credit_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Credit_Panel.BackColor = System.Drawing.Color.White;
            this.Credit_Panel.Controls.Add(this.TB_Count);
            this.Credit_Panel.Controls.Add(this.label6);
            this.Credit_Panel.Controls.Add(this.TB_TotalBalance);
            this.Credit_Panel.Controls.Add(this.label4);
            this.Credit_Panel.Controls.Add(this.BT_SetAsPaidAll);
            this.Credit_Panel.Controls.Add(this.CB_FilterType);
            this.Credit_Panel.Controls.Add(this.DGV_BalanceList);
            this.Credit_Panel.Controls.Add(this.panel2);
            this.Credit_Panel.Controls.Add(this.BT_Search);
            this.Credit_Panel.Controls.Add(this.CB_CustomersList);
            this.Credit_Panel.Location = new System.Drawing.Point(1, 1);
            this.Credit_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Credit_Panel.Name = "Credit_Panel";
            this.Credit_Panel.Size = new System.Drawing.Size(817, 763);
            this.Credit_Panel.TabIndex = 0;
            this.Credit_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Credit_Panel_Paint);
            // 
            // TB_Count
            // 
            this.TB_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Count.Location = new System.Drawing.Point(56, 725);
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(51, 22);
            this.TB_Count.TabIndex = 18;
            this.TB_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Count";
            // 
            // TB_TotalBalance
            // 
            this.TB_TotalBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_TotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TotalBalance.Location = new System.Drawing.Point(586, 725);
            this.TB_TotalBalance.Name = "TB_TotalBalance";
            this.TB_TotalBalance.Size = new System.Drawing.Size(206, 22);
            this.TB_TotalBalance.TabIndex = 14;
            this.TB_TotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 728);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Balance";
            // 
            // BT_SetAsPaidAll
            // 
            this.BT_SetAsPaidAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_SetAsPaidAll.BackColor = System.Drawing.Color.White;
            this.BT_SetAsPaidAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BT_SetAsPaidAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SetAsPaidAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SetAsPaidAll.ForeColor = System.Drawing.Color.DimGray;
            this.BT_SetAsPaidAll.Location = new System.Drawing.Point(611, 301);
            this.BT_SetAsPaidAll.Name = "BT_SetAsPaidAll";
            this.BT_SetAsPaidAll.Size = new System.Drawing.Size(195, 30);
            this.BT_SetAsPaidAll.TabIndex = 12;
            this.BT_SetAsPaidAll.Text = "SET AS PAID ALL";
            this.BT_SetAsPaidAll.UseVisualStyleBackColor = false;
            // 
            // CB_FilterType
            // 
            this.CB_FilterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_FilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FilterType.FormattingEnabled = true;
            this.CB_FilterType.Items.AddRange(new object[] {
            "All",
            "Paid",
            "Unpaid"});
            this.CB_FilterType.Location = new System.Drawing.Point(12, 301);
            this.CB_FilterType.Name = "CB_FilterType";
            this.CB_FilterType.Size = new System.Drawing.Size(107, 21);
            this.CB_FilterType.TabIndex = 11;
            this.CB_FilterType.Text = "Filter By";
            // 
            // DGV_BalanceList
            // 
            this.DGV_BalanceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_BalanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_BalanceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_BalanceList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DGV_BalanceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_BalanceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_BalanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BalanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CREDIT_ID,
            this.ITEM,
            this.CODE,
            this.PRICE,
            this.DATE_ISSUED,
            this.UNIT,
            this.STATUS,
            this.CASHIER});
            this.DGV_BalanceList.Location = new System.Drawing.Point(11, 339);
            this.DGV_BalanceList.Name = "DGV_BalanceList";
            this.DGV_BalanceList.Size = new System.Drawing.Size(803, 365);
            this.DGV_BalanceList.TabIndex = 10;
            // 
            // CREDIT_ID
            // 
            this.CREDIT_ID.HeaderText = "CREDIT_ID";
            this.CREDIT_ID.Name = "CREDIT_ID";
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            // 
            // CODE
            // 
            this.CODE.HeaderText = "CODE";
            this.CODE.Name = "CODE";
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            // 
            // DATE_ISSUED
            // 
            this.DATE_ISSUED.HeaderText = "DATE ISSUED";
            this.DATE_ISSUED.Name = "DATE_ISSUED";
            // 
            // UNIT
            // 
            this.UNIT.HeaderText = "UNIT";
            this.UNIT.Name = "UNIT";
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // CASHIER
            // 
            this.CASHIER.HeaderText = "CASHIER";
            this.CASHIER.Name = "CASHIER";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.TB_ContactNumber);
            this.panel2.Controls.Add(this.TB_Address);
            this.panel2.Controls.Add(this.TB_CustomerName);
            this.panel2.Controls.Add(this.BT_Add);
            this.panel2.Controls.Add(this.BT_Clear);
            this.panel2.Controls.Add(this.BT_Delete);
            this.panel2.Controls.Add(this.BT_Update);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 242);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TB_ContactNumber
            // 
            this.TB_ContactNumber.Depth = 0;
            this.TB_ContactNumber.Hint = "";
            this.TB_ContactNumber.Location = new System.Drawing.Point(145, 115);
            this.TB_ContactNumber.MaxLength = 32767;
            this.TB_ContactNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_ContactNumber.Name = "TB_ContactNumber";
            this.TB_ContactNumber.PasswordChar = '\0';
            this.TB_ContactNumber.SelectedText = "";
            this.TB_ContactNumber.SelectionLength = 0;
            this.TB_ContactNumber.SelectionStart = 0;
            this.TB_ContactNumber.Size = new System.Drawing.Size(387, 23);
            this.TB_ContactNumber.TabIndex = 14;
            this.TB_ContactNumber.TabStop = false;
            this.TB_ContactNumber.UseSystemPasswordChar = false;
            // 
            // TB_Address
            // 
            this.TB_Address.Depth = 0;
            this.TB_Address.Hint = "";
            this.TB_Address.Location = new System.Drawing.Point(145, 81);
            this.TB_Address.MaxLength = 32767;
            this.TB_Address.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.PasswordChar = '\0';
            this.TB_Address.SelectedText = "";
            this.TB_Address.SelectionLength = 0;
            this.TB_Address.SelectionStart = 0;
            this.TB_Address.Size = new System.Drawing.Size(387, 23);
            this.TB_Address.TabIndex = 13;
            this.TB_Address.TabStop = false;
            this.TB_Address.UseSystemPasswordChar = false;
            // 
            // TB_CustomerName
            // 
            this.TB_CustomerName.Depth = 0;
            this.TB_CustomerName.Hint = "";
            this.TB_CustomerName.Location = new System.Drawing.Point(145, 50);
            this.TB_CustomerName.MaxLength = 32767;
            this.TB_CustomerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TB_CustomerName.Name = "TB_CustomerName";
            this.TB_CustomerName.PasswordChar = '\0';
            this.TB_CustomerName.SelectedText = "";
            this.TB_CustomerName.SelectionLength = 0;
            this.TB_CustomerName.SelectionStart = 0;
            this.TB_CustomerName.Size = new System.Drawing.Size(387, 23);
            this.TB_CustomerName.TabIndex = 12;
            this.TB_CustomerName.TabStop = false;
            this.TB_CustomerName.UseSystemPasswordChar = false;
            this.TB_CustomerName.Click += new System.EventHandler(this.TB_CustomerName_Click);
            // 
            // BT_Add
            // 
            this.BT_Add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_Add.FlatAppearance.BorderSize = 0;
            this.BT_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Add.Location = new System.Drawing.Point(22, 183);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(129, 38);
            this.BT_Add.TabIndex = 11;
            this.BT_Add.Text = "Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            // 
            // BT_Clear
            // 
            this.BT_Clear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_Clear.BackColor = System.Drawing.Color.White;
            this.BT_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BT_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Clear.Location = new System.Drawing.Point(422, 183);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(129, 38);
            this.BT_Clear.TabIndex = 10;
            this.BT_Clear.Text = "Clear";
            this.BT_Clear.UseVisualStyleBackColor = false;
            // 
            // BT_Delete
            // 
            this.BT_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.BT_Delete.Enabled = false;
            this.BT_Delete.FlatAppearance.BorderSize = 0;
            this.BT_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Delete.ForeColor = System.Drawing.Color.White;
            this.BT_Delete.Location = new System.Drawing.Point(288, 183);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(129, 38);
            this.BT_Delete.TabIndex = 9;
            this.BT_Delete.Text = "Delete";
            this.BT_Delete.UseVisualStyleBackColor = false;
            // 
            // BT_Update
            // 
            this.BT_Update.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.BT_Update.Enabled = false;
            this.BT_Update.FlatAppearance.BorderSize = 0;
            this.BT_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Update.ForeColor = System.Drawing.Color.White;
            this.BT_Update.Location = new System.Drawing.Point(155, 183);
            this.BT_Update.Name = "BT_Update";
            this.BT_Update.Size = new System.Drawing.Size(129, 38);
            this.BT_Update.TabIndex = 8;
            this.BT_Update.Text = "Update";
            this.BT_Update.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact #";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // BT_Search
            // 
            this.BT_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Search.BackColor = System.Drawing.Color.Transparent;
            this.BT_Search.FlatAppearance.BorderSize = 0;
            this.BT_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Search.ForeColor = System.Drawing.Color.Gray;
            this.BT_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Search.Location = new System.Drawing.Point(442, 11);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(94, 36);
            this.BT_Search.TabIndex = 1;
            this.BT_Search.Text = "Search";
            this.BT_Search.UseVisualStyleBackColor = false;
            // 
            // CB_CustomersList
            // 
            this.CB_CustomersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_CustomersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_CustomersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_CustomersList.FormattingEnabled = true;
            this.CB_CustomersList.Location = new System.Drawing.Point(11, 17);
            this.CB_CustomersList.Name = "CB_CustomersList";
            this.CB_CustomersList.Size = new System.Drawing.Size(424, 24);
            this.CB_CustomersList.TabIndex = 0;
            this.CB_CustomersList.Text = "Customer name";
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(819, 765);
            this.Controls.Add(this.Credit_Panel);
            this.Name = "Credits";
            this.Text = "Credits";
            this.Credit_Panel.ResumeLayout(false);
            this.Credit_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BalanceList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Credit_Panel;
        private System.Windows.Forms.Button BT_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_Update;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_SetAsPaidAll;
        private System.Windows.Forms.TextBox TB_TotalBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BT_Add;
        public System.Windows.Forms.ComboBox CB_CustomersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDIT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ISSUED;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASHIER;
        public System.Windows.Forms.ComboBox CB_FilterType;
        public System.Windows.Forms.DataGridView DGV_BalanceList;
        public MaterialSkin.Controls.MaterialSingleLineTextField TB_CustomerName;
        public MaterialSkin.Controls.MaterialSingleLineTextField TB_Address;
        public MaterialSkin.Controls.MaterialSingleLineTextField TB_ContactNumber;
    }
}