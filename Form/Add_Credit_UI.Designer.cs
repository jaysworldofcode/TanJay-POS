namespace TanjayPOS
{
    partial class Add_Credit_UI
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
            this.CB_CustomerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_AddCredit = new System.Windows.Forms.Button();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RTB_Description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CB_CustomerList
            // 
            this.CB_CustomerList.FormattingEnabled = true;
            this.CB_CustomerList.Location = new System.Drawing.Point(33, 55);
            this.CB_CustomerList.Name = "CB_CustomerList";
            this.CB_CustomerList.Size = new System.Drawing.Size(483, 21);
            this.CB_CustomerList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // BT_AddCredit
            // 
            this.BT_AddCredit.Location = new System.Drawing.Point(155, 278);
            this.BT_AddCredit.Name = "BT_AddCredit";
            this.BT_AddCredit.Size = new System.Drawing.Size(175, 37);
            this.BT_AddCredit.TabIndex = 2;
            this.BT_AddCredit.Text = "Add Credit";
            this.BT_AddCredit.UseVisualStyleBackColor = true;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(341, 278);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(175, 37);
            this.BT_Cancel.TabIndex = 3;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // RTB_Description
            // 
            this.RTB_Description.Location = new System.Drawing.Point(33, 123);
            this.RTB_Description.Name = "RTB_Description";
            this.RTB_Description.Size = new System.Drawing.Size(483, 131);
            this.RTB_Description.TabIndex = 5;
            this.RTB_Description.Text = "";
            // 
            // Add_Credit_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 342);
            this.Controls.Add(this.RTB_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.BT_AddCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_CustomerList);
            this.Name = "Add_Credit_UI";
            this.Text = "Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_CustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_AddCredit;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTB_Description;
    }
}