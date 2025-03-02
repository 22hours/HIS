﻿namespace NewPMS
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SystemStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.RegisteredUsersLblTxt = new System.Windows.Forms.Label();
            this.PagesTodayLblTxt = new System.Windows.Forms.Label();
            this.TotalPagesLblTxt = new System.Windows.Forms.Label();
            this.PrintersLblTxt = new System.Windows.Forms.Label();
            this.UsersInLANLblTxt = new System.Windows.Forms.Label();
            this.SystemUpTimeLblTxt = new System.Windows.Forms.Label();
            this.RegisteredUsersLbl = new System.Windows.Forms.Label();
            this.PagesTodayLbl = new System.Windows.Forms.Label();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.PrintersLbl = new System.Windows.Forms.Label();
            this.UsersInLANLbl = new System.Windows.Forms.Label();
            this.SystemUpTimeLbl = new System.Windows.Forms.Label();
            this.DashBoardDataGrid = new System.Windows.Forms.DataGridView();
            this.GraphGroupBox = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuotaReqLbl = new System.Windows.Forms.LinkLabel();
            this.ChangePriQtLbl = new System.Windows.Forms.LinkLabel();
            this.ChangeUserQtLbl = new System.Windows.Forms.LinkLabel();
            this.DeletePrintersLbl = new System.Windows.Forms.LinkLabel();
            this.AddPrintersLbl = new System.Windows.Forms.LinkLabel();
            this.AddPrintToGrpLbl = new System.Windows.Forms.LinkLabel();
            this.AddUserToGrpLbl = new System.Windows.Forms.LinkLabel();
            this.CreateGrpLbl = new System.Windows.Forms.LinkLabel();
            this.DeleteUserLbl = new System.Windows.Forms.LinkLabel();
            this.AddUserLbl = new System.Windows.Forms.LinkLabel();
            this.BillingPerUserLbl = new System.Windows.Forms.LinkLabel();
            this.BillingPerPrinterLbl = new System.Windows.Forms.LinkLabel();
            this.JobsPerUserLbl = new System.Windows.Forms.LinkLabel();
            this.JobsPerPrinterLbl = new System.Windows.Forms.LinkLabel();
            this.PrinterLbl = new System.Windows.Forms.LinkLabel();
            this.UserLbl = new System.Windows.Forms.LinkLabel();
            this.SystemStatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardDataGrid)).BeginInit();
            this.GraphGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemStatusGroupBox
            // 
            this.SystemStatusGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SystemStatusGroupBox.AutoSize = true;
            this.SystemStatusGroupBox.Controls.Add(this.RegisteredUsersLblTxt);
            this.SystemStatusGroupBox.Controls.Add(this.PagesTodayLblTxt);
            this.SystemStatusGroupBox.Controls.Add(this.TotalPagesLblTxt);
            this.SystemStatusGroupBox.Controls.Add(this.PrintersLblTxt);
            this.SystemStatusGroupBox.Controls.Add(this.UsersInLANLblTxt);
            this.SystemStatusGroupBox.Controls.Add(this.SystemUpTimeLblTxt);
            this.SystemStatusGroupBox.Controls.Add(this.RegisteredUsersLbl);
            this.SystemStatusGroupBox.Controls.Add(this.PagesTodayLbl);
            this.SystemStatusGroupBox.Controls.Add(this.TotalPagesLbl);
            this.SystemStatusGroupBox.Controls.Add(this.PrintersLbl);
            this.SystemStatusGroupBox.Controls.Add(this.UsersInLANLbl);
            this.SystemStatusGroupBox.Controls.Add(this.SystemUpTimeLbl);
            this.SystemStatusGroupBox.Location = new System.Drawing.Point(281, 82);
            this.SystemStatusGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SystemStatusGroupBox.Name = "SystemStatusGroupBox";
            this.SystemStatusGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SystemStatusGroupBox.Size = new System.Drawing.Size(223, 227);
            this.SystemStatusGroupBox.TabIndex = 0;
            this.SystemStatusGroupBox.TabStop = false;
            this.SystemStatusGroupBox.Text = "System Status";
            this.SystemStatusGroupBox.Enter += new System.EventHandler(this.SystemStatusGroupBox_Enter);
            // 
            // RegisteredUsersLblTxt
            // 
            this.RegisteredUsersLblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisteredUsersLblTxt.AutoSize = true;
            this.RegisteredUsersLblTxt.Location = new System.Drawing.Point(143, 200);
            this.RegisteredUsersLblTxt.Name = "RegisteredUsersLblTxt";
            this.RegisteredUsersLblTxt.Size = new System.Drawing.Size(15, 15);
            this.RegisteredUsersLblTxt.TabIndex = 17;
            this.RegisteredUsersLblTxt.Text = "0";
            // 
            // PagesTodayLblTxt
            // 
            this.PagesTodayLblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagesTodayLblTxt.AutoSize = true;
            this.PagesTodayLblTxt.Location = new System.Drawing.Point(143, 165);
            this.PagesTodayLblTxt.Name = "PagesTodayLblTxt";
            this.PagesTodayLblTxt.Size = new System.Drawing.Size(15, 15);
            this.PagesTodayLblTxt.TabIndex = 16;
            this.PagesTodayLblTxt.Text = "0";
            // 
            // TotalPagesLblTxt
            // 
            this.TotalPagesLblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPagesLblTxt.AutoSize = true;
            this.TotalPagesLblTxt.Location = new System.Drawing.Point(143, 133);
            this.TotalPagesLblTxt.Name = "TotalPagesLblTxt";
            this.TotalPagesLblTxt.Size = new System.Drawing.Size(15, 15);
            this.TotalPagesLblTxt.TabIndex = 15;
            this.TotalPagesLblTxt.Text = "0";
            // 
            // PrintersLblTxt
            // 
            this.PrintersLblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintersLblTxt.AutoSize = true;
            this.PrintersLblTxt.Location = new System.Drawing.Point(143, 102);
            this.PrintersLblTxt.Name = "PrintersLblTxt";
            this.PrintersLblTxt.Size = new System.Drawing.Size(15, 15);
            this.PrintersLblTxt.TabIndex = 14;
            this.PrintersLblTxt.Text = "0";
            // 
            // UsersInLANLblTxt
            // 
            this.UsersInLANLblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersInLANLblTxt.AutoSize = true;
            this.UsersInLANLblTxt.Location = new System.Drawing.Point(143, 67);
            this.UsersInLANLblTxt.Name = "UsersInLANLblTxt";
            this.UsersInLANLblTxt.Size = new System.Drawing.Size(15, 15);
            this.UsersInLANLblTxt.TabIndex = 13;
            this.UsersInLANLblTxt.Text = "0";
            // 
            // SystemUpTimeLblTxt
            // 
            this.SystemUpTimeLblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemUpTimeLblTxt.AutoSize = true;
            this.SystemUpTimeLblTxt.Location = new System.Drawing.Point(143, 33);
            this.SystemUpTimeLblTxt.Name = "SystemUpTimeLblTxt";
            this.SystemUpTimeLblTxt.Size = new System.Drawing.Size(15, 15);
            this.SystemUpTimeLblTxt.TabIndex = 12;
            this.SystemUpTimeLblTxt.Text = "0";
            // 
            // RegisteredUsersLbl
            // 
            this.RegisteredUsersLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisteredUsersLbl.AutoSize = true;
            this.RegisteredUsersLbl.Location = new System.Drawing.Point(20, 200);
            this.RegisteredUsersLbl.Name = "RegisteredUsersLbl";
            this.RegisteredUsersLbl.Size = new System.Drawing.Size(119, 15);
            this.RegisteredUsersLbl.TabIndex = 5;
            this.RegisteredUsersLbl.Text = "Registered Users";
            // 
            // PagesTodayLbl
            // 
            this.PagesTodayLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagesTodayLbl.AutoSize = true;
            this.PagesTodayLbl.Location = new System.Drawing.Point(20, 165);
            this.PagesTodayLbl.Name = "PagesTodayLbl";
            this.PagesTodayLbl.Size = new System.Drawing.Size(95, 15);
            this.PagesTodayLbl.TabIndex = 4;
            this.PagesTodayLbl.Text = "Pages Today";
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.Location = new System.Drawing.Point(20, 133);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(86, 15);
            this.TotalPagesLbl.TabIndex = 3;
            this.TotalPagesLbl.Text = "Total Pages";
            // 
            // PrintersLbl
            // 
            this.PrintersLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintersLbl.AutoSize = true;
            this.PrintersLbl.Location = new System.Drawing.Point(20, 102);
            this.PrintersLbl.Name = "PrintersLbl";
            this.PrintersLbl.Size = new System.Drawing.Size(56, 15);
            this.PrintersLbl.TabIndex = 2;
            this.PrintersLbl.Text = "Printers";
            // 
            // UsersInLANLbl
            // 
            this.UsersInLANLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersInLANLbl.AutoSize = true;
            this.UsersInLANLbl.Location = new System.Drawing.Point(20, 65);
            this.UsersInLANLbl.Name = "UsersInLANLbl";
            this.UsersInLANLbl.Size = new System.Drawing.Size(92, 15);
            this.UsersInLANLbl.TabIndex = 1;
            this.UsersInLANLbl.Text = "Users In LAN";
            // 
            // SystemUpTimeLbl
            // 
            this.SystemUpTimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemUpTimeLbl.AutoSize = true;
            this.SystemUpTimeLbl.Location = new System.Drawing.Point(20, 33);
            this.SystemUpTimeLbl.Name = "SystemUpTimeLbl";
            this.SystemUpTimeLbl.Size = new System.Drawing.Size(109, 15);
            this.SystemUpTimeLbl.TabIndex = 0;
            this.SystemUpTimeLbl.Text = "System UpTime";
            // 
            // DashBoardDataGrid
            // 
            this.DashBoardDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DashBoardDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DashBoardDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DashBoardDataGrid.BackgroundColor = System.Drawing.Color.DimGray;
            this.DashBoardDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DashBoardDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DashBoardDataGrid.Location = new System.Drawing.Point(-3, 317);
            this.DashBoardDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashBoardDataGrid.Name = "DashBoardDataGrid";
            this.DashBoardDataGrid.RowTemplate.Height = 24;
            this.DashBoardDataGrid.Size = new System.Drawing.Size(935, 288);
            this.DashBoardDataGrid.TabIndex = 0;
            this.DashBoardDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DashBoardDataGrid_CellContentClick);
            // 
            // GraphGroupBox
            // 
            this.GraphGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GraphGroupBox.AutoSize = true;
            this.GraphGroupBox.Controls.Add(this.chart1);
            this.GraphGroupBox.Location = new System.Drawing.Point(488, 76);
            this.GraphGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GraphGroupBox.Name = "GraphGroupBox";
            this.GraphGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GraphGroupBox.Size = new System.Drawing.Size(437, 235);
            this.GraphGroupBox.TabIndex = 1;
            this.GraphGroupBox.TabStop = false;
            this.GraphGroupBox.Text = "Graph";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(7, 21);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))))};
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "PagesPrinted";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(400, 172);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topPanel
            // 
            this.topPanel.BorderColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(133)))), ((int)(((byte)(148)))));
            this.topPanel.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(170)))));
            this.topPanel.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.topPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.topPanel.Location = new System.Drawing.Point(-2, -1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(700, 50);
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
            this.shapeContainer1.Size = new System.Drawing.Size(925, 660);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bottomPanel.Controls.Add(this.okButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 612);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(925, 48);
            this.bottomPanel.TabIndex = 9;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(795, 10);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuotaReqLbl);
            this.groupBox1.Controls.Add(this.ChangePriQtLbl);
            this.groupBox1.Controls.Add(this.ChangeUserQtLbl);
            this.groupBox1.Controls.Add(this.DeletePrintersLbl);
            this.groupBox1.Controls.Add(this.AddPrintersLbl);
            this.groupBox1.Controls.Add(this.AddPrintToGrpLbl);
            this.groupBox1.Controls.Add(this.AddUserToGrpLbl);
            this.groupBox1.Controls.Add(this.CreateGrpLbl);
            this.groupBox1.Controls.Add(this.DeleteUserLbl);
            this.groupBox1.Controls.Add(this.AddUserLbl);
            this.groupBox1.Controls.Add(this.BillingPerUserLbl);
            this.groupBox1.Controls.Add(this.BillingPerPrinterLbl);
            this.groupBox1.Controls.Add(this.JobsPerUserLbl);
            this.groupBox1.Controls.Add(this.JobsPerPrinterLbl);
            this.groupBox1.Controls.Add(this.PrinterLbl);
            this.groupBox1.Controls.Add(this.UserLbl);
            this.groupBox1.Location = new System.Drawing.Point(4, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(271, 235);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabs";
            // 
            // QuotaReqLbl
            // 
            this.QuotaReqLbl.AutoSize = true;
            this.QuotaReqLbl.Location = new System.Drawing.Point(125, 43);
            this.QuotaReqLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuotaReqLbl.Name = "QuotaReqLbl";
            this.QuotaReqLbl.Size = new System.Drawing.Size(115, 15);
            this.QuotaReqLbl.TabIndex = 15;
            this.QuotaReqLbl.TabStop = true;
            this.QuotaReqLbl.Text = "Quota Requests";
            this.QuotaReqLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.QuotaReqLbl_LinkClicked);
            // 
            // ChangePriQtLbl
            // 
            this.ChangePriQtLbl.AutoSize = true;
            this.ChangePriQtLbl.Location = new System.Drawing.Point(125, 126);
            this.ChangePriQtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangePriQtLbl.Name = "ChangePriQtLbl";
            this.ChangePriQtLbl.Size = new System.Drawing.Size(149, 15);
            this.ChangePriQtLbl.TabIndex = 14;
            this.ChangePriQtLbl.TabStop = true;
            this.ChangePriQtLbl.Text = "Change Printer Quota";
            this.ChangePriQtLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePriQtLbl_LinkClicked);
            // 
            // ChangeUserQtLbl
            // 
            this.ChangeUserQtLbl.AutoSize = true;
            this.ChangeUserQtLbl.Location = new System.Drawing.Point(125, 107);
            this.ChangeUserQtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeUserQtLbl.Name = "ChangeUserQtLbl";
            this.ChangeUserQtLbl.Size = new System.Drawing.Size(138, 15);
            this.ChangeUserQtLbl.TabIndex = 13;
            this.ChangeUserQtLbl.TabStop = true;
            this.ChangeUserQtLbl.Text = "Change User Quota";
            this.ChangeUserQtLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeUserQtLbl_LinkClicked);
            // 
            // DeletePrintersLbl
            // 
            this.DeletePrintersLbl.AutoSize = true;
            this.DeletePrintersLbl.Location = new System.Drawing.Point(8, 208);
            this.DeletePrintersLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeletePrintersLbl.Name = "DeletePrintersLbl";
            this.DeletePrintersLbl.Size = new System.Drawing.Size(102, 15);
            this.DeletePrintersLbl.TabIndex = 12;
            this.DeletePrintersLbl.TabStop = true;
            this.DeletePrintersLbl.Text = "Delete Printers";
            this.DeletePrintersLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeletePrintersLbl_LinkClicked);
            // 
            // AddPrintersLbl
            // 
            this.AddPrintersLbl.AutoSize = true;
            this.AddPrintersLbl.Location = new System.Drawing.Point(8, 187);
            this.AddPrintersLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddPrintersLbl.Name = "AddPrintersLbl";
            this.AddPrintersLbl.Size = new System.Drawing.Size(86, 15);
            this.AddPrintersLbl.TabIndex = 11;
            this.AddPrintersLbl.TabStop = true;
            this.AddPrintersLbl.Text = "Add Printers";
            this.AddPrintersLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddPrintersLbl_LinkClicked);
            // 
            // AddPrintToGrpLbl
            // 
            this.AddPrintToGrpLbl.AutoSize = true;
            this.AddPrintToGrpLbl.Location = new System.Drawing.Point(125, 63);
            this.AddPrintToGrpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddPrintToGrpLbl.Name = "AddPrintToGrpLbl";
            this.AddPrintToGrpLbl.Size = new System.Drawing.Size(153, 15);
            this.AddPrintToGrpLbl.TabIndex = 10;
            this.AddPrintToGrpLbl.TabStop = true;
            this.AddPrintToGrpLbl.Text = "Add Printers To Group";
            this.AddPrintToGrpLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddPrintToGrpLbl_LinkClicked);
            // 
            // AddUserToGrpLbl
            // 
            this.AddUserToGrpLbl.AutoSize = true;
            this.AddUserToGrpLbl.Location = new System.Drawing.Point(125, 84);
            this.AddUserToGrpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddUserToGrpLbl.Name = "AddUserToGrpLbl";
            this.AddUserToGrpLbl.Size = new System.Drawing.Size(142, 15);
            this.AddUserToGrpLbl.TabIndex = 9;
            this.AddUserToGrpLbl.TabStop = true;
            this.AddUserToGrpLbl.Text = "Add Users To Group";
            this.AddUserToGrpLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddUserToGrpLbl_LinkClicked);
            // 
            // CreateGrpLbl
            // 
            this.CreateGrpLbl.AutoSize = true;
            this.CreateGrpLbl.Location = new System.Drawing.Point(125, 23);
            this.CreateGrpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateGrpLbl.Name = "CreateGrpLbl";
            this.CreateGrpLbl.Size = new System.Drawing.Size(102, 15);
            this.CreateGrpLbl.TabIndex = 8;
            this.CreateGrpLbl.TabStop = true;
            this.CreateGrpLbl.Text = "Create Groups";
            this.CreateGrpLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateGrpLbl_LinkClicked);
            // 
            // DeleteUserLbl
            // 
            this.DeleteUserLbl.AutoSize = true;
            this.DeleteUserLbl.Location = new System.Drawing.Point(8, 84);
            this.DeleteUserLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteUserLbl.Name = "DeleteUserLbl";
            this.DeleteUserLbl.Size = new System.Drawing.Size(83, 15);
            this.DeleteUserLbl.TabIndex = 7;
            this.DeleteUserLbl.TabStop = true;
            this.DeleteUserLbl.Text = "Delete User";
            this.DeleteUserLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteUserLbl_LinkClicked);
            // 
            // AddUserLbl
            // 
            this.AddUserLbl.AutoSize = true;
            this.AddUserLbl.Location = new System.Drawing.Point(8, 63);
            this.AddUserLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddUserLbl.Name = "AddUserLbl";
            this.AddUserLbl.Size = new System.Drawing.Size(67, 15);
            this.AddUserLbl.TabIndex = 6;
            this.AddUserLbl.TabStop = true;
            this.AddUserLbl.Text = "Add User";
            this.AddUserLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddUserLbl_LinkClicked);
            // 
            // BillingPerUserLbl
            // 
            this.BillingPerUserLbl.AutoSize = true;
            this.BillingPerUserLbl.Location = new System.Drawing.Point(8, 126);
            this.BillingPerUserLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BillingPerUserLbl.Name = "BillingPerUserLbl";
            this.BillingPerUserLbl.Size = new System.Drawing.Size(107, 15);
            this.BillingPerUserLbl.TabIndex = 5;
            this.BillingPerUserLbl.TabStop = true;
            this.BillingPerUserLbl.Text = "Billing Per User";
            this.BillingPerUserLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BillingPerUserLbl_LinkClicked);
            // 
            // BillingPerPrinterLbl
            // 
            this.BillingPerPrinterLbl.AutoSize = true;
            this.BillingPerPrinterLbl.Location = new System.Drawing.Point(8, 167);
            this.BillingPerPrinterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BillingPerPrinterLbl.Name = "BillingPerPrinterLbl";
            this.BillingPerPrinterLbl.Size = new System.Drawing.Size(118, 15);
            this.BillingPerPrinterLbl.TabIndex = 4;
            this.BillingPerPrinterLbl.TabStop = true;
            this.BillingPerPrinterLbl.Text = "Billing Per Printer";
            this.BillingPerPrinterLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BillingPerPrinterLbl_LinkClicked);
            // 
            // JobsPerUserLbl
            // 
            this.JobsPerUserLbl.AutoSize = true;
            this.JobsPerUserLbl.Location = new System.Drawing.Point(8, 105);
            this.JobsPerUserLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobsPerUserLbl.Name = "JobsPerUserLbl";
            this.JobsPerUserLbl.Size = new System.Drawing.Size(100, 15);
            this.JobsPerUserLbl.TabIndex = 3;
            this.JobsPerUserLbl.TabStop = true;
            this.JobsPerUserLbl.Text = "Jobs Per User";
            this.JobsPerUserLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JobsPerUserLbl_LinkClicked);
            // 
            // JobsPerPrinterLbl
            // 
            this.JobsPerPrinterLbl.AutoSize = true;
            this.JobsPerPrinterLbl.Location = new System.Drawing.Point(8, 147);
            this.JobsPerPrinterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JobsPerPrinterLbl.Name = "JobsPerPrinterLbl";
            this.JobsPerPrinterLbl.Size = new System.Drawing.Size(111, 15);
            this.JobsPerPrinterLbl.TabIndex = 2;
            this.JobsPerPrinterLbl.TabStop = true;
            this.JobsPerPrinterLbl.Text = "Jobs Per Printer";
            this.JobsPerPrinterLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JobsPerPrinterLbl_LinkClicked);
            // 
            // PrinterLbl
            // 
            this.PrinterLbl.AutoSize = true;
            this.PrinterLbl.Location = new System.Drawing.Point(8, 43);
            this.PrinterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrinterLbl.Name = "PrinterLbl";
            this.PrinterLbl.Size = new System.Drawing.Size(56, 15);
            this.PrinterLbl.TabIndex = 1;
            this.PrinterLbl.TabStop = true;
            this.PrinterLbl.Text = "Printers";
            this.PrinterLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrinterLbl_LinkClicked);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(8, 23);
            this.UserLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(45, 15);
            this.UserLbl.TabIndex = 0;
            this.UserLbl.TabStop = true;
            this.UserLbl.Text = "Users";
            this.UserLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UserLbl_LinkClicked);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.DashBoardDataGrid);
            this.Controls.Add(this.GraphGroupBox);
            this.Controls.Add(this.SystemStatusGroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.SystemStatusGroupBox.ResumeLayout(false);
            this.SystemStatusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardDataGrid)).EndInit();
            this.GraphGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SystemStatusGroupBox;
        private System.Windows.Forms.GroupBox GraphGroupBox;
        private System.Windows.Forms.Label SystemUpTimeLbl;
        private System.Windows.Forms.Label UsersInLANLbl;
        private System.Windows.Forms.Label RegisteredUsersLbl;
        private System.Windows.Forms.Label PagesTodayLbl;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.Label PrintersLbl;
        private System.Windows.Forms.Label RegisteredUsersLblTxt;
        private System.Windows.Forms.Label PagesTodayLblTxt;
        private System.Windows.Forms.Label TotalPagesLblTxt;
        private System.Windows.Forms.Label PrintersLblTxt;
        private System.Windows.Forms.Label UsersInLANLblTxt;
        private System.Windows.Forms.Label SystemUpTimeLblTxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DashBoardDataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape topPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel BillingPerPrinterLbl;
        private System.Windows.Forms.LinkLabel JobsPerUserLbl;
        private System.Windows.Forms.LinkLabel JobsPerPrinterLbl;
        private System.Windows.Forms.LinkLabel PrinterLbl;
        private System.Windows.Forms.LinkLabel UserLbl;
        private System.Windows.Forms.LinkLabel ChangeUserQtLbl;
        private System.Windows.Forms.LinkLabel DeletePrintersLbl;
        private System.Windows.Forms.LinkLabel AddPrintersLbl;
        private System.Windows.Forms.LinkLabel AddPrintToGrpLbl;
        private System.Windows.Forms.LinkLabel AddUserToGrpLbl;
        private System.Windows.Forms.LinkLabel CreateGrpLbl;
        private System.Windows.Forms.LinkLabel DeleteUserLbl;
        private System.Windows.Forms.LinkLabel AddUserLbl;
        private System.Windows.Forms.LinkLabel BillingPerUserLbl;
        private System.Windows.Forms.LinkLabel ChangePriQtLbl;
        private System.Windows.Forms.LinkLabel QuotaReqLbl;
    }
}