namespace TanjayPOS
{
    partial class POS
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
            this.components = new System.ComponentModel.Container();
            this.POS_Panel = new System.Windows.Forms.Panel();
            this.BT_Search = new System.Windows.Forms.Button();
            this.SetUnitLeft = new System.Windows.Forms.Label();
            this.SetPrice = new System.Windows.Forms.Label();
            this.SetDateReceived = new System.Windows.Forms.Label();
            this.SetDateExpiry = new System.Windows.Forms.Label();
            this.SetItemName = new System.Windows.Forms.Label();
            this.SetCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StocksList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.DGV_Items = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POS_ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_AddToCredit = new System.Windows.Forms.Button();
            this.BT_Pay = new System.Windows.Forms.Button();
            this.BT_ClearCart = new System.Windows.Forms.Button();
            this.BT_DeleteCart = new System.Windows.Forms.Button();
            this.BT_RegisterCustomer = new System.Windows.Forms.Button();
            this.BT_AddToStack = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.POS_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // POS_Panel
            // 
            this.POS_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POS_Panel.BackColor = System.Drawing.Color.White;
            this.POS_Panel.Controls.Add(this.BT_Search);
            this.POS_Panel.Controls.Add(this.SetUnitLeft);
            this.POS_Panel.Controls.Add(this.SetPrice);
            this.POS_Panel.Controls.Add(this.SetDateReceived);
            this.POS_Panel.Controls.Add(this.SetDateExpiry);
            this.POS_Panel.Controls.Add(this.SetItemName);
            this.POS_Panel.Controls.Add(this.SetCode);
            this.POS_Panel.Controls.Add(this.label8);
            this.POS_Panel.Controls.Add(this.label6);
            this.POS_Panel.Controls.Add(this.label5);
            this.POS_Panel.Controls.Add(this.label4);
            this.POS_Panel.Controls.Add(this.label3);
            this.POS_Panel.Controls.Add(this.StocksList);
            this.POS_Panel.Controls.Add(this.label7);
            this.POS_Panel.Controls.Add(this.label2);
            this.POS_Panel.Controls.Add(this.LabelTotal);
            this.POS_Panel.Controls.Add(this.DGV_Items);
            this.POS_Panel.Controls.Add(this.panel1);
            this.POS_Panel.Location = new System.Drawing.Point(-1, -1);
            this.POS_Panel.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.POS_Panel.Name = "POS_Panel";
            this.POS_Panel.Size = new System.Drawing.Size(820, 766);
            this.POS_Panel.TabIndex = 0;
            this.POS_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.POS_Panel_Paint);
            // 
            // BT_Search
            // 
            this.BT_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BT_Search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BT_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Search.Location = new System.Drawing.Point(461, 4);
            this.BT_Search.Name = "BT_Search";
            this.BT_Search.Size = new System.Drawing.Size(42, 27);
            this.BT_Search.TabIndex = 33;
            this.BT_Search.UseVisualStyleBackColor = true;
            // 
            // SetUnitLeft
            // 
            this.SetUnitLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SetUnitLeft.AutoSize = true;
            this.SetUnitLeft.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetUnitLeft.Location = new System.Drawing.Point(166, 238);
            this.SetUnitLeft.Name = "SetUnitLeft";
            this.SetUnitLeft.Size = new System.Drawing.Size(25, 19);
            this.SetUnitLeft.TabIndex = 32;
            this.SetUnitLeft.Text = "----";
            // 
            // SetPrice
            // 
            this.SetPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SetPrice.AutoSize = true;
            this.SetPrice.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPrice.Location = new System.Drawing.Point(166, 202);
            this.SetPrice.Name = "SetPrice";
            this.SetPrice.Size = new System.Drawing.Size(25, 19);
            this.SetPrice.TabIndex = 31;
            this.SetPrice.Text = "----";
            // 
            // SetDateReceived
            // 
            this.SetDateReceived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SetDateReceived.AutoSize = true;
            this.SetDateReceived.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDateReceived.Location = new System.Drawing.Point(166, 167);
            this.SetDateReceived.Name = "SetDateReceived";
            this.SetDateReceived.Size = new System.Drawing.Size(25, 19);
            this.SetDateReceived.TabIndex = 30;
            this.SetDateReceived.Text = "----";
            // 
            // SetDateExpiry
            // 
            this.SetDateExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SetDateExpiry.AutoSize = true;
            this.SetDateExpiry.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetDateExpiry.Location = new System.Drawing.Point(166, 132);
            this.SetDateExpiry.Name = "SetDateExpiry";
            this.SetDateExpiry.Size = new System.Drawing.Size(25, 19);
            this.SetDateExpiry.TabIndex = 29;
            this.SetDateExpiry.Text = "----";
            // 
            // SetItemName
            // 
            this.SetItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SetItemName.AutoSize = true;
            this.SetItemName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetItemName.Location = new System.Drawing.Point(166, 95);
            this.SetItemName.Name = "SetItemName";
            this.SetItemName.Size = new System.Drawing.Size(25, 19);
            this.SetItemName.TabIndex = 28;
            this.SetItemName.Text = "----";
            // 
            // SetCode
            // 
            this.SetCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SetCode.AutoSize = true;
            this.SetCode.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetCode.Location = new System.Drawing.Point(166, 58);
            this.SetCode.Name = "SetCode";
            this.SetCode.Size = new System.Drawing.Size(25, 19);
            this.SetCode.TabIndex = 27;
            this.SetCode.Text = "----";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Unit Left";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date Received";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Expiry Date";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Code";
            // 
            // StocksList
            // 
            this.StocksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StocksList.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksList.Location = new System.Drawing.Point(5, 4);
            this.StocksList.Name = "StocksList";
            this.StocksList.Size = new System.Drawing.Size(450, 27);
            this.StocksList.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Price";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 693);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total";
            // 
            // LabelTotal
            // 
            this.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(435, 707);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(64, 48);
            this.LabelTotal.TabIndex = 17;
            this.LabelTotal.Text = "----";
            // 
            // DGV_Items
            // 
            this.DGV_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DGV_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ITEM_NAME,
            this.PRICE,
            this.UNIT,
            this.TOTAL,
            this.POS_ITEM_ID});
            this.DGV_Items.Location = new System.Drawing.Point(1, 326);
            this.DGV_Items.Name = "DGV_Items";
            this.DGV_Items.Size = new System.Drawing.Size(499, 354);
            this.DGV_Items.TabIndex = 19;
            this.DGV_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Items_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.HeaderText = "ITEM NAME";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            // 
            // UNIT
            // 
            this.UNIT.HeaderText = "UNIT";
            this.UNIT.Name = "UNIT";
            this.UNIT.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // POS_ITEM_ID
            // 
            this.POS_ITEM_ID.HeaderText = "POS_ITEM_ID";
            this.POS_ITEM_ID.Name = "POS_ITEM_ID";
            this.POS_ITEM_ID.ReadOnly = true;
            this.POS_ITEM_ID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BT_AddToCredit);
            this.panel1.Controls.Add(this.BT_Pay);
            this.panel1.Controls.Add(this.BT_ClearCart);
            this.panel1.Controls.Add(this.BT_DeleteCart);
            this.panel1.Controls.Add(this.BT_RegisterCustomer);
            this.panel1.Controls.Add(this.BT_AddToStack);
            this.panel1.Location = new System.Drawing.Point(505, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 768);
            this.panel1.TabIndex = 16;
            // 
            // BT_AddToCredit
            // 
            this.BT_AddToCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_AddToCredit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BT_AddToCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddToCredit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddToCredit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_AddToCredit.Location = new System.Drawing.Point(1, 362);
            this.BT_AddToCredit.Margin = new System.Windows.Forms.Padding(0);
            this.BT_AddToCredit.Name = "BT_AddToCredit";
            this.BT_AddToCredit.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.BT_AddToCredit.Size = new System.Drawing.Size(313, 115);
            this.BT_AddToCredit.TabIndex = 5;
            this.BT_AddToCredit.Text = "Add to Credit";
            this.BT_AddToCredit.UseVisualStyleBackColor = true;
            // 
            // BT_Pay
            // 
            this.BT_Pay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Pay.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BT_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Pay.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Pay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Pay.Location = new System.Drawing.Point(1, 250);
            this.BT_Pay.Margin = new System.Windows.Forms.Padding(0);
            this.BT_Pay.Name = "BT_Pay";
            this.BT_Pay.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.BT_Pay.Size = new System.Drawing.Size(313, 114);
            this.BT_Pay.TabIndex = 4;
            this.BT_Pay.Text = "Pay";
            this.BT_Pay.UseVisualStyleBackColor = true;
            // 
            // BT_ClearCart
            // 
            this.BT_ClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_ClearCart.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BT_ClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ClearCart.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ClearCart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_ClearCart.Location = new System.Drawing.Point(155, 125);
            this.BT_ClearCart.Margin = new System.Windows.Forms.Padding(0);
            this.BT_ClearCart.Name = "BT_ClearCart";
            this.BT_ClearCart.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.BT_ClearCart.Size = new System.Drawing.Size(157, 126);
            this.BT_ClearCart.TabIndex = 3;
            this.BT_ClearCart.Text = "CLEAR CART";
            this.BT_ClearCart.UseVisualStyleBackColor = true;
            // 
            // BT_DeleteCart
            // 
            this.BT_DeleteCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_DeleteCart.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BT_DeleteCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_DeleteCart.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DeleteCart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_DeleteCart.Location = new System.Drawing.Point(1, 125);
            this.BT_DeleteCart.Margin = new System.Windows.Forms.Padding(0);
            this.BT_DeleteCart.Name = "BT_DeleteCart";
            this.BT_DeleteCart.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.BT_DeleteCart.Size = new System.Drawing.Size(157, 126);
            this.BT_DeleteCart.TabIndex = 2;
            this.BT_DeleteCart.Text = "DELETE CART ITEM";
            this.BT_DeleteCart.UseVisualStyleBackColor = true;
            // 
            // BT_RegisterCustomer
            // 
            this.BT_RegisterCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_RegisterCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BT_RegisterCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_RegisterCustomer.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_RegisterCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_RegisterCustomer.Location = new System.Drawing.Point(155, 0);
            this.BT_RegisterCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.BT_RegisterCustomer.Name = "BT_RegisterCustomer";
            this.BT_RegisterCustomer.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.BT_RegisterCustomer.Size = new System.Drawing.Size(157, 126);
            this.BT_RegisterCustomer.TabIndex = 1;
            this.BT_RegisterCustomer.Text = "REGISTER CUSTOMER";
            this.BT_RegisterCustomer.UseVisualStyleBackColor = true;
            // 
            // BT_AddToStack
            // 
            this.BT_AddToStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_AddToStack.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BT_AddToStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddToStack.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddToStack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_AddToStack.Location = new System.Drawing.Point(1, 0);
            this.BT_AddToStack.Margin = new System.Windows.Forms.Padding(0);
            this.BT_AddToStack.Name = "BT_AddToStack";
            this.BT_AddToStack.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.BT_AddToStack.Size = new System.Drawing.Size(157, 126);
            this.BT_AddToStack.TabIndex = 0;
            this.BT_AddToStack.Text = "ADD TO CART";
            this.BT_AddToStack.UseVisualStyleBackColor = true;
            this.BT_AddToStack.Click += new System.EventHandler(this.BT_AddToStack_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(819, 765);
            this.Controls.Add(this.POS_Panel);
            this.Name = "POS";
            this.Text = "POS";
            this.POS_Panel.ResumeLayout(false);
            this.POS_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Items)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel POS_Panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StocksList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_AddToCredit;
        private System.Windows.Forms.Button BT_Pay;
        private System.Windows.Forms.Button BT_ClearCart;
        private System.Windows.Forms.Button BT_DeleteCart;
        private System.Windows.Forms.Button BT_RegisterCustomer;
        private System.Windows.Forms.Button BT_AddToStack;
        private System.Data.DataSet dataSet1;
        public System.Windows.Forms.Label SetCode;
        public System.Windows.Forms.Label SetUnitLeft;
        public System.Windows.Forms.Label SetPrice;
        public System.Windows.Forms.Label SetDateReceived;
        public System.Windows.Forms.Label SetDateExpiry;
        public System.Windows.Forms.Label SetItemName;
        public System.Windows.Forms.DataGridView DGV_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn POS_ITEM_ID;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BT_Search;
    }
}