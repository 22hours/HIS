namespace NewPMS
{
    partial class BillingPerPrinter
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
            this.PrinterdataGridView = new System.Windows.Forms.DataGridView();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.CostOfPrinterLbl = new System.Windows.Forms.Label();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PrinterNameComboBox = new System.Windows.Forms.ComboBox();
            this.ShowBill = new System.Windows.Forms.Button();
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrinterdataGridView)).BeginInit();
            this.UserGroupBox.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrinterdataGridView
            // 
            this.PrinterdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrinterdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.PrinterdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrinterdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrinterdataGridView.Location = new System.Drawing.Point(-5, 174);
            this.PrinterdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrinterdataGridView.Name = "PrinterdataGridView";
            this.PrinterdataGridView.RowTemplate.Height = 24;
            this.PrinterdataGridView.Size = new System.Drawing.Size(801, 324);
            this.PrinterdataGridView.TabIndex = 5;
            this.PrinterdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrinterdataGridView_CellContentClick);
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserGroupBox.AutoSize = true;
            this.UserGroupBox.Controls.Add(this.CostOfPrinterLbl);
            this.UserGroupBox.Controls.Add(this.TodateTimePicker);
            this.UserGroupBox.Controls.Add(this.FromdateTimePicker);
            this.UserGroupBox.Controls.Add(this.PrinterNameComboBox);
            this.UserGroupBox.Location = new System.Drawing.Point(-3, 66);
            this.UserGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserGroupBox.Size = new System.Drawing.Size(795, 126);
            this.UserGroupBox.TabIndex = 4;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Select Appropriate Printer";
            // 
            // CostOfPrinterLbl
            // 
            this.CostOfPrinterLbl.AutoSize = true;
            this.CostOfPrinterLbl.Location = new System.Drawing.Point(307, 91);
            this.CostOfPrinterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostOfPrinterLbl.Name = "CostOfPrinterLbl";
            this.CostOfPrinterLbl.Size = new System.Drawing.Size(0, 15);
            this.CostOfPrinterLbl.TabIndex = 4;
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TodateTimePicker.Location = new System.Drawing.Point(497, 55);
            this.TodateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(243, 25);
            this.TodateTimePicker.TabIndex = 3;
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromdateTimePicker.Location = new System.Drawing.Point(233, 55);
            this.FromdateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(255, 25);
            this.FromdateTimePicker.TabIndex = 2;
            // 
            // PrinterNameComboBox
            // 
            this.PrinterNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrinterNameComboBox.FormattingEnabled = true;
            this.PrinterNameComboBox.Location = new System.Drawing.Point(17, 54);
            this.PrinterNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrinterNameComboBox.Name = "PrinterNameComboBox";
            this.PrinterNameComboBox.Size = new System.Drawing.Size(208, 23);
            this.PrinterNameComboBox.TabIndex = 0;
            // 
            // ShowBill
            // 
            this.ShowBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowBill.AutoSize = true;
            this.ShowBill.Location = new System.Drawing.Point(15, 9);
            this.ShowBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowBill.Name = "ShowBill";
            this.ShowBill.Size = new System.Drawing.Size(104, 29);
            this.ShowBill.TabIndex = 1;
            this.ShowBill.Text = "Show Bill";
            this.ShowBill.UseVisualStyleBackColor = true;
            this.ShowBill.Click += new System.EventHandler(this.ShowBill_Click);
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-2, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(598, 50);
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
            this.shapeContainer1.Size = new System.Drawing.Size(792, 545);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Controls.Add(this.ShowBill);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 497);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(792, 48);
            this.bottomPanel.TabIndex = 9;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(676, 9);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // BillingPerPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 545);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.PrinterdataGridView);
            this.Controls.Add(this.UserGroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillingPerPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingPerPrinter";
            this.Load += new System.EventHandler(this.BillingPerPrinter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrinterdataGridView)).EndInit();
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrinterdataGridView;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.Button ShowBill;
        private System.Windows.Forms.ComboBox PrinterNameComboBox;
        private System.Windows.Forms.Label CostOfPrinterLbl;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
    }
}