namespace ProjectWithDesign.GUI
{
    partial class TableGUI
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
            this.panelManage = new System.Windows.Forms.Panel();
            this.panelChangeTable = new System.Windows.Forms.Panel();
            this.iconBack = new FontAwesome.Sharp.IconPictureBox();
            this.flAvailableTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTypeList = new System.Windows.Forms.ComboBox();
            this.btPay = new FontAwesome.Sharp.IconButton();
            this.btnChangeTable = new FontAwesome.Sharp.IconButton();
            this.lvwListFood = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lviBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.btAdd = new FontAwesome.Sharp.IconButton();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cmsDelFood = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAddFood = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelManage.SuspendLayout();
            this.panelChangeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.cmsDelFood.SuspendLayout();
            this.cmsAddFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManage
            // 
            this.panelManage.BackColor = System.Drawing.Color.OldLace;
            this.panelManage.Controls.Add(this.panelChangeTable);
            this.panelManage.Controls.Add(this.cboTypeList);
            this.panelManage.Controls.Add(this.btPay);
            this.panelManage.Controls.Add(this.btnChangeTable);
            this.panelManage.Controls.Add(this.lvwListFood);
            this.panelManage.Controls.Add(this.lviBill);
            this.panelManage.Controls.Add(this.panel2);
            this.panelManage.Controls.Add(this.label5);
            this.panelManage.Controls.Add(this.flTable);
            this.panelManage.Controls.Add(this.label3);
            this.panelManage.Controls.Add(this.nudDiscount);
            this.panelManage.Controls.Add(this.btAdd);
            this.panelManage.Controls.Add(this.nudCount);
            this.panelManage.Controls.Add(this.cboCategory);
            this.panelManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManage.Location = new System.Drawing.Point(0, 0);
            this.panelManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(1077, 562);
            this.panelManage.TabIndex = 1;
            // 
            // panelChangeTable
            // 
            this.panelChangeTable.BackColor = System.Drawing.Color.OldLace;
            this.panelChangeTable.Controls.Add(this.iconBack);
            this.panelChangeTable.Controls.Add(this.flAvailableTable);
            this.panelChangeTable.Controls.Add(this.label1);
            this.panelChangeTable.Location = new System.Drawing.Point(0, 0);
            this.panelChangeTable.Name = "panelChangeTable";
            this.panelChangeTable.Size = new System.Drawing.Size(1077, 580);
            this.panelChangeTable.TabIndex = 0;
            // 
            // iconBack
            // 
            this.iconBack.BackColor = System.Drawing.Color.OldLace;
            this.iconBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconBack.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBack.Location = new System.Drawing.Point(39, 33);
            this.iconBack.Name = "iconBack";
            this.iconBack.Size = new System.Drawing.Size(32, 32);
            this.iconBack.TabIndex = 26;
            this.iconBack.TabStop = false;
            this.iconBack.Click += new System.EventHandler(this.iconBack_Click);
            // 
            // flAvailableTable
            // 
            this.flAvailableTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flAvailableTable.Location = new System.Drawing.Point(178, 131);
            this.flAvailableTable.Name = "flAvailableTable";
            this.flAvailableTable.Size = new System.Drawing.Size(746, 299);
            this.flAvailableTable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(384, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn bàn muốn chuyển đến";
            // 
            // cboTypeList
            // 
            this.cboTypeList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeList.FormattingEnabled = true;
            this.cboTypeList.Items.AddRange(new object[] {
            "Danh sách liên kết",
            "Danh sách đặc",
            "Danh sách đơn"});
            this.cboTypeList.Location = new System.Drawing.Point(1, 2);
            this.cboTypeList.Name = "cboTypeList";
            this.cboTypeList.Size = new System.Drawing.Size(190, 27);
            this.cboTypeList.TabIndex = 50;
            this.cboTypeList.Text = "Danh sách liên kết";
            this.cboTypeList.SelectedIndexChanged += new System.EventHandler(this.cboTypeList_SelectedIndexChanged);
            // 
            // btPay
            // 
            this.btPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btPay.BackColor = System.Drawing.Color.MistyRose;
            this.btPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPay.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.btPay.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btPay.IconColor = System.Drawing.Color.Red;
            this.btPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btPay.Location = new System.Drawing.Point(822, 495);
            this.btPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(243, 55);
            this.btPay.TabIndex = 49;
            this.btPay.Text = "0đ";
            this.btPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPay.UseVisualStyleBackColor = false;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnChangeTable.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTable.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnChangeTable.IconColor = System.Drawing.Color.Black;
            this.btnChangeTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeTable.IconSize = 46;
            this.btnChangeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeTable.Location = new System.Drawing.Point(21, 287);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(168, 44);
            this.btnChangeTable.TabIndex = 2;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // lvwListFood
            // 
            this.lvwListFood.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lvwListFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwListFood.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwListFood.FullRowSelect = true;
            this.lvwListFood.HideSelection = false;
            this.lvwListFood.Location = new System.Drawing.Point(21, 336);
            this.lvwListFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwListFood.Name = "lvwListFood";
            this.lvwListFood.Size = new System.Drawing.Size(570, 223);
            this.lvwListFood.TabIndex = 47;
            this.lvwListFood.UseCompatibleStateImageBehavior = false;
            this.lvwListFood.View = System.Windows.Forms.View.Details;
            this.lvwListFood.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwListFood_MouseDown_1);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Danh Mục";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã Món";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Món Ăn";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn Giá";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn Vị";
            this.columnHeader6.Width = 76;
            // 
            // lviBill
            // 
            this.lviBill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lviBill.BackColor = System.Drawing.SystemColors.Window;
            this.lviBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colFoodName,
            this.colCount,
            this.colPrice,
            this.colTotalPrice});
            this.lviBill.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviBill.FullRowSelect = true;
            this.lviBill.GridLines = true;
            this.lviBill.HideSelection = false;
            this.lviBill.Location = new System.Drawing.Point(646, 72);
            this.lviBill.Name = "lviBill";
            this.lviBill.Size = new System.Drawing.Size(428, 397);
            this.lviBill.TabIndex = 43;
            this.lviBill.UseCompatibleStateImageBehavior = false;
            this.lviBill.View = System.Windows.Forms.View.Details;
            this.lviBill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lviBill_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Món";
            this.columnHeader1.Width = 72;
            // 
            // colFoodName
            // 
            this.colFoodName.Text = "Tên Món";
            this.colFoodName.Width = 102;
            // 
            // colCount
            // 
            this.colCount.Text = "Số Lượng";
            this.colCount.Width = 91;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn Giá";
            this.colPrice.Width = 66;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Text = "Tổng Giá Món";
            this.colTotalPrice.Width = 130;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(722, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 4);
            this.panel2.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Cambria", 32F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(769, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 51);
            this.label5.TabIndex = 44;
            this.label5.Text = "HOÁ ĐƠN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flTable
            // 
            this.flTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flTable.Location = new System.Drawing.Point(0, 24);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(640, 257);
            this.flTable.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(675, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Giảm giá(%)";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudDiscount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiscount.Location = new System.Drawing.Point(686, 523);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(83, 30);
            this.nudDiscount.TabIndex = 18;
            this.nudDiscount.ValueChanged += new System.EventHandler(this.nudDiscount_ValueChanged);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btAdd.BackColor = System.Drawing.Color.OldLace;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btAdd.IconColor = System.Drawing.SystemColors.WindowText;
            this.btAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btAdd.IconSize = 56;
            this.btAdd.Location = new System.Drawing.Point(538, 290);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(62, 48);
            this.btAdd.TabIndex = 14;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            this.btAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // nudCount
            // 
            this.nudCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nudCount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCount.Location = new System.Drawing.Point(488, 295);
            this.nudCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(46, 30);
            this.nudCount.TabIndex = 4;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.ForeColor = System.Drawing.Color.Black;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(251, 297);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(225, 27);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged_1);
            this.cboCategory.TextChanged += new System.EventHandler(this.cboCategory_TextChanged);
            // 
            // cmsDelFood
            // 
            this.cmsDelFood.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDelFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáMónToolStripMenuItem});
            this.cmsDelFood.Name = "cmsDelFood";
            this.cmsDelFood.Size = new System.Drawing.Size(123, 26);
            // 
            // xoáMónToolStripMenuItem
            // 
            this.xoáMónToolStripMenuItem.Name = "xoáMónToolStripMenuItem";
            this.xoáMónToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.xoáMónToolStripMenuItem.Text = "Xoá Món";
            this.xoáMónToolStripMenuItem.Click += new System.EventHandler(this.xoáMónToolStripMenuItem_Click);
            // 
            // cmsAddFood
            // 
            this.cmsAddFood.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAddFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMónToolStripMenuItem});
            this.cmsAddFood.Name = "cmsAddFood";
            this.cmsAddFood.Size = new System.Drawing.Size(133, 26);
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.thêmMónToolStripMenuItem.Text = "Thêm Món";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // TableGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1077, 562);
            this.Controls.Add(this.panelManage);
            this.Name = "TableGUI";
            this.Text = "Table";
            this.panelManage.ResumeLayout(false);
            this.panelManage.PerformLayout();
            this.panelChangeTable.ResumeLayout(false);
            this.panelChangeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.cmsDelFood.ResumeLayout(false);
            this.cmsAddFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManage;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.ComboBox cboCategory;
        private FontAwesome.Sharp.IconButton btAdd;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsDelFood;
        private System.Windows.Forms.ToolStripMenuItem xoáMónToolStripMenuItem;
        private System.Windows.Forms.ListView lvwListFood;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lviBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colFoodName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flTable;
        private FontAwesome.Sharp.IconButton btnChangeTable;
        private FontAwesome.Sharp.IconButton btPay;
        private System.Windows.Forms.Panel panelChangeTable;
        private System.Windows.Forms.FlowLayoutPanel flAvailableTable;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconBack;
        private System.Windows.Forms.ComboBox cboTypeList;
        private System.Windows.Forms.ContextMenuStrip cmsAddFood;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
    }
}