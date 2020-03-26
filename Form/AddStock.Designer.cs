namespace TanjayPOS
{
    partial class AddStock
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
            this.Date_Receive = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date_Expiry = new System.Windows.Forms.DateTimePicker();
            this.Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitLeft = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Barcode_TF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // Date_Receive
            // 
            this.Date_Receive.Location = new System.Drawing.Point(130, 133);
            this.Date_Receive.Name = "Date_Receive";
            this.Date_Receive.Size = new System.Drawing.Size(266, 20);
            this.Date_Receive.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Expiry";
            // 
            // Date_Expiry
            // 
            this.Date_Expiry.Location = new System.Drawing.Point(130, 167);
            this.Date_Expiry.Name = "Date_Expiry";
            this.Date_Expiry.Size = new System.Drawing.Size(266, 20);
            this.Date_Expiry.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(130, 198);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(109, 20);
            this.Price.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price(₱)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(248, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit Left";
            // 
            // UnitLeft
            // 
            this.UnitLeft.Location = new System.Drawing.Point(303, 199);
            this.UnitLeft.Name = "UnitLeft";
            this.UnitLeft.Size = new System.Drawing.Size(93, 20);
            this.UnitLeft.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(115, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(274, 275);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(145, 38);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Barcode_TF
            // 
            this.Barcode_TF.Depth = 0;
            this.Barcode_TF.Hint = "Barcode";
            this.Barcode_TF.Location = new System.Drawing.Point(42, 51);
            this.Barcode_TF.MaxLength = 32767;
            this.Barcode_TF.MouseState = MaterialSkin.MouseState.HOVER;
            this.Barcode_TF.Name = "Barcode_TF";
            this.Barcode_TF.PasswordChar = '\0';
            this.Barcode_TF.SelectedText = "";
            this.Barcode_TF.SelectionLength = 0;
            this.Barcode_TF.SelectionStart = 0;
            this.Barcode_TF.Size = new System.Drawing.Size(354, 23);
            this.Barcode_TF.TabIndex = 12;
            this.Barcode_TF.TabStop = false;
            this.Barcode_TF.UseSystemPasswordChar = false;
            // 
            // ItemName
            // 
            this.ItemName.Depth = 0;
            this.ItemName.Hint = "Item Name";
            this.ItemName.Location = new System.Drawing.Point(42, 87);
            this.ItemName.MaxLength = 32767;
            this.ItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemName.Name = "ItemName";
            this.ItemName.PasswordChar = '\0';
            this.ItemName.SelectedText = "";
            this.ItemName.SelectionLength = 0;
            this.ItemName.SelectionStart = 0;
            this.ItemName.Size = new System.Drawing.Size(354, 23);
            this.ItemName.TabIndex = 13;
            this.ItemName.TabStop = false;
            this.ItemName.UseSystemPasswordChar = false;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(445, 334);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.Barcode_TF);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UnitLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_Expiry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_Receive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Date_Receive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Date_Expiry;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnitLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Barcode_TF;
        private MaterialSkin.Controls.MaterialSingleLineTextField ItemName;
    }
}