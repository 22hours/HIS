namespace NewPMS
{
    partial class ChangeUserQuota
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
            this.UserNamecomboBox = new System.Windows.Forms.ComboBox();
            this.UserQuotagroupBox = new System.Windows.Forms.GroupBox();
            this.MacAddressLbl = new System.Windows.Forms.Label();
            this.MACAddressTxt = new System.Windows.Forms.Label();
            this.UpdateUserQuota = new System.Windows.Forms.Button();
            this.AllocatedQuotaTxt = new System.Windows.Forms.TextBox();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.QuotaLeftTxt = new System.Windows.Forms.Label();
            this.QuotaLeftLbl = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.Label();
            this.AllocatedQuotaLbl = new System.Windows.Forms.Label();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.UserQuotagroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNamecomboBox
            // 
            this.UserNamecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNamecomboBox.FormattingEnabled = true;
            this.UserNamecomboBox.Location = new System.Drawing.Point(16, 74);
            this.UserNamecomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserNamecomboBox.Name = "UserNamecomboBox";
            this.UserNamecomboBox.Size = new System.Drawing.Size(597, 23);
            this.UserNamecomboBox.TabIndex = 4;
            this.UserNamecomboBox.Text = "--Select User Here--";
            this.UserNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.UserNamecomboBox_SelectedIndexChanged);
            // 
            // UserQuotagroupBox
            // 
            this.UserQuotagroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserQuotagroupBox.AutoSize = true;
            this.UserQuotagroupBox.Controls.Add(this.MacAddressLbl);
            this.UserQuotagroupBox.Controls.Add(this.MACAddressTxt);
            this.UserQuotagroupBox.Controls.Add(this.UpdateUserQuota);
            this.UserQuotagroupBox.Controls.Add(this.AllocatedQuotaTxt);
            this.UserQuotagroupBox.Controls.Add(this.UserNameLbl);
            this.UserQuotagroupBox.Controls.Add(this.QuotaLeftTxt);
            this.UserQuotagroupBox.Controls.Add(this.QuotaLeftLbl);
            this.UserQuotagroupBox.Controls.Add(this.UserNameTxt);
            this.UserQuotagroupBox.Controls.Add(this.AllocatedQuotaLbl);
            this.UserQuotagroupBox.Location = new System.Drawing.Point(16, 105);
            this.UserQuotagroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserQuotagroupBox.Name = "UserQuotagroupBox";
            this.UserQuotagroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserQuotagroupBox.Size = new System.Drawing.Size(599, 283);
            this.UserQuotagroupBox.TabIndex = 15;
            this.UserQuotagroupBox.TabStop = false;
            this.UserQuotagroupBox.Text = "User Quota Update";
            this.UserQuotagroupBox.Visible = false;
            // 
            // MacAddressLbl
            // 
            this.MacAddressLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MacAddressLbl.AutoSize = true;
            this.MacAddressLbl.Location = new System.Drawing.Point(17, 60);
            this.MacAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MacAddressLbl.Name = "MacAddressLbl";
            this.MacAddressLbl.Size = new System.Drawing.Size(88, 15);
            this.MacAddressLbl.TabIndex = 4;
            this.MacAddressLbl.Text = "MacAddress";
            // 
            // MACAddressTxt
            // 
            this.MACAddressTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MACAddressTxt.AutoSize = true;
            this.MACAddressTxt.Location = new System.Drawing.Point(141, 60);
            this.MACAddressTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MACAddressTxt.Name = "MACAddressTxt";
            this.MACAddressTxt.Size = new System.Drawing.Size(15, 15);
            this.MACAddressTxt.TabIndex = 9;
            this.MACAddressTxt.Text = "0";
            // 
            // UpdateUserQuota
            // 
            this.UpdateUserQuota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateUserQuota.AutoSize = true;
            this.UpdateUserQuota.Location = new System.Drawing.Point(21, 212);
            this.UpdateUserQuota.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateUserQuota.Name = "UpdateUserQuota";
            this.UpdateUserQuota.Size = new System.Drawing.Size(439, 47);
            this.UpdateUserQuota.TabIndex = 0;
            this.UpdateUserQuota.Text = "Update User Quota";
            this.UpdateUserQuota.UseVisualStyleBackColor = true;
            this.UpdateUserQuota.Click += new System.EventHandler(this.UpdateUserQuota_Click_1);
            // 
            // AllocatedQuotaTxt
            // 
            this.AllocatedQuotaTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllocatedQuotaTxt.Location = new System.Drawing.Point(145, 120);
            this.AllocatedQuotaTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AllocatedQuotaTxt.Name = "AllocatedQuotaTxt";
            this.AllocatedQuotaTxt.Size = new System.Drawing.Size(313, 25);
            this.AllocatedQuotaTxt.TabIndex = 12;
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(17, 94);
            this.UserNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(73, 15);
            this.UserNameLbl.TabIndex = 5;
            this.UserNameLbl.Text = "UserName";
            // 
            // QuotaLeftTxt
            // 
            this.QuotaLeftTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuotaLeftTxt.AutoSize = true;
            this.QuotaLeftTxt.Location = new System.Drawing.Point(141, 168);
            this.QuotaLeftTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuotaLeftTxt.Name = "QuotaLeftTxt";
            this.QuotaLeftTxt.Size = new System.Drawing.Size(15, 15);
            this.QuotaLeftTxt.TabIndex = 11;
            this.QuotaLeftTxt.Text = "0";
            // 
            // QuotaLeftLbl
            // 
            this.QuotaLeftLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuotaLeftLbl.AutoSize = true;
            this.QuotaLeftLbl.Location = new System.Drawing.Point(17, 168);
            this.QuotaLeftLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuotaLeftLbl.Name = "QuotaLeftLbl";
            this.QuotaLeftLbl.Size = new System.Drawing.Size(72, 15);
            this.QuotaLeftLbl.TabIndex = 7;
            this.QuotaLeftLbl.Text = "QuotaLeft";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTxt.AutoSize = true;
            this.UserNameTxt.Location = new System.Drawing.Point(141, 94);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(15, 15);
            this.UserNameTxt.TabIndex = 10;
            this.UserNameTxt.Text = "0";
            // 
            // AllocatedQuotaLbl
            // 
            this.AllocatedQuotaLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllocatedQuotaLbl.AutoSize = true;
            this.AllocatedQuotaLbl.Location = new System.Drawing.Point(17, 123);
            this.AllocatedQuotaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllocatedQuotaLbl.Name = "AllocatedQuotaLbl";
            this.AllocatedQuotaLbl.Size = new System.Drawing.Size(108, 15);
            this.AllocatedQuotaLbl.TabIndex = 6;
            this.AllocatedQuotaLbl.Text = "AllocatedQuota";
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-3, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(497, 50);
            this.topPanel.Click += new System.EventHandler(this.topPanel_Click);
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.topPanel});
            this.shapeContainer1.Size = new System.Drawing.Size(659, 429);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 381);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(659, 48);
            this.bottomPanel.TabIndex = 17;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(543, 10);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ChangeUserQuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 429);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.UserQuotagroupBox);
            this.Controls.Add(this.UserNamecomboBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserQuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeUserQuota";
            this.Load += new System.EventHandler(this.ChangeUserQuota_Load);
            this.UserQuotagroupBox.ResumeLayout(false);
            this.UserQuotagroupBox.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserNamecomboBox;
        private System.Windows.Forms.GroupBox UserQuotagroupBox;
        private System.Windows.Forms.Label MacAddressLbl;
        private System.Windows.Forms.Label MACAddressTxt;
        private System.Windows.Forms.Button UpdateUserQuota;
        private System.Windows.Forms.TextBox AllocatedQuotaTxt;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label QuotaLeftTxt;
        private System.Windows.Forms.Label QuotaLeftLbl;
        private System.Windows.Forms.Label UserNameTxt;
        private System.Windows.Forms.Label AllocatedQuotaLbl;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}