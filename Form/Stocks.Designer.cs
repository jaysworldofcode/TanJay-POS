namespace TanjayPOS
{
    partial class Stocks
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
            this.ListPanel = new System.Windows.Forms.Panel();
            this.RowsPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NewStocktBT = new System.Windows.Forms.Button();
            this.ListPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.AutoScroll = true;
            this.ListPanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ListPanel.Controls.Add(this.RowsPanel);
            this.ListPanel.Location = new System.Drawing.Point(0, 63);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(818, 634);
            this.ListPanel.TabIndex = 3;
            this.ListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ListPanel_Paint);
            // 
            // RowsPanel
            // 
            this.RowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RowsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RowsPanel.Location = new System.Drawing.Point(0, -3);
            this.RowsPanel.Name = "RowsPanel";
            this.RowsPanel.Size = new System.Drawing.Size(852, 637);
            this.RowsPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.Maroon;
            this.MainPanel.Controls.Add(this.NewStocktBT);
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(818, 762);
            this.MainPanel.TabIndex = 0;
            // 
            // NewStocktBT
            // 
            this.NewStocktBT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NewStocktBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.NewStocktBT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NewStocktBT.FlatAppearance.BorderSize = 0;
            this.NewStocktBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewStocktBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStocktBT.ForeColor = System.Drawing.Color.White;
            this.NewStocktBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewStocktBT.Location = new System.Drawing.Point(557, 706);
            this.NewStocktBT.Name = "NewStocktBT";
            this.NewStocktBT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.NewStocktBT.Size = new System.Drawing.Size(250, 45);
            this.NewStocktBT.TabIndex = 4;
            this.NewStocktBT.Text = "New Stock";
            this.NewStocktBT.UseVisualStyleBackColor = false;
            this.NewStocktBT.Click += new System.EventHandler(this.NewStocktBT_Click_1);
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 765);
            this.Controls.Add(this.MainPanel);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.ListPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel RowsPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button NewStocktBT;
    }
}