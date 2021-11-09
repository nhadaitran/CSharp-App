namespace ProjectWithDesign.GUI
{
    partial class BillGUI
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
            this.panelMange = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconPictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.lvwBill = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lvwListBill = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cmsAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelFood = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMange.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.cmsAction.SuspendLayout();
            this.cmsDelFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMange
            // 
            this.panelMange.BackColor = System.Drawing.Color.OldLace;
            this.panelMange.Controls.Add(this.panelInfo);
            this.panelMange.Controls.Add(this.label2);
            this.panelMange.Controls.Add(this.lvwListBill);
            this.panelMange.Controls.Add(this.label1);
            this.panelMange.Location = new System.Drawing.Point(4, -1);
            this.panelMange.Name = "panelMange";
            this.panelMange.Size = new System.Drawing.Size(1073, 563);
            this.panelMange.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.OldLace;
            this.panelInfo.Controls.Add(this.btnBack);
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Controls.Add(this.lvwBill);
            this.panelInfo.Location = new System.Drawing.Point(8, 22);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1053, 573);
            this.panelInfo.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.OldLace;
            this.btnBack.ForeColor = System.Drawing.Color.Coral;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnBack.IconColor = System.Drawing.Color.Coral;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 43;
            this.btnBack.Location = new System.Drawing.Point(39, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(375, 35);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(85, 32);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "label2";
            // 
            // lvwBill
            // 
            this.lvwBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader14,
            this.columnHeader13,
            this.columnHeader15,
            this.columnHeader16});
            this.lvwBill.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBill.FullRowSelect = true;
            this.lvwBill.HideSelection = false;
            this.lvwBill.Location = new System.Drawing.Point(212, 101);
            this.lvwBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwBill.Name = "lvwBill";
            this.lvwBill.Size = new System.Drawing.Size(659, 351);
            this.lvwBill.TabIndex = 1;
            this.lvwBill.UseCompatibleStateImageBehavior = false;
            this.lvwBill.View = System.Windows.Forms.View.Details;
            this.lvwBill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwBill_MouseDown);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã Món";
            this.columnHeader11.Width = 115;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tên Món";
            this.columnHeader14.Width = 148;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Số Lượng";
            this.columnHeader13.Width = 93;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Đơn Giá";
            this.columnHeader15.Width = 126;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tổng Giá Món";
            this.columnHeader16.Width = 141;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(335, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách hoá đơn trong nhà hàng";
            // 
            // lvwListBill
            // 
            this.lvwListBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12});
            this.lvwListBill.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwListBill.FullRowSelect = true;
            this.lvwListBill.HideSelection = false;
            this.lvwListBill.Location = new System.Drawing.Point(74, 101);
            this.lvwListBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvwListBill.Name = "lvwListBill";
            this.lvwListBill.Size = new System.Drawing.Size(973, 326);
            this.lvwListBill.TabIndex = 4;
            this.lvwListBill.UseCompatibleStateImageBehavior = false;
            this.lvwListBill.View = System.Windows.Forms.View.Details;
            this.lvwListBill.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwListBill_MouseDoubleClick);
            this.lvwListBill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwListBill_MouseDown);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã HĐ";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã Bàn";
            this.columnHeader7.Width = 118;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Thời Gian";
            this.columnHeader8.Width = 232;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giảm Giá";
            this.columnHeader9.Width = 126;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tổng Tiền";
            this.columnHeader10.Width = 138;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Trạng thái";
            this.columnHeader12.Width = 151;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(335, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách hoá đơn trong nhà hàng";
            // 
            // cmsAction
            // 
            this.cmsAction.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaBillToolStripMenuItem});
            this.cmsAction.Name = "cmsAction";
            this.cmsAction.Size = new System.Drawing.Size(114, 26);
            // 
            // xóaBillToolStripMenuItem
            // 
            this.xóaBillToolStripMenuItem.Name = "xóaBillToolStripMenuItem";
            this.xóaBillToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.xóaBillToolStripMenuItem.Text = "Xóa Bill";
            this.xóaBillToolStripMenuItem.Click += new System.EventHandler(this.xóaBillToolStripMenuItem_Click);
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
            // BillGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.panelMange);
            this.Name = "BillGUI";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.BillGUI_Load);
            this.panelMange.ResumeLayout(false);
            this.panelMange.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.cmsAction.ResumeLayout(false);
            this.cmsDelFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMange;
        private System.Windows.Forms.Panel panelInfo;
        private FontAwesome.Sharp.IconPictureBox btnBack;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListView lvwBill;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwListBill;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsAction;
        private System.Windows.Forms.ToolStripMenuItem xóaBillToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDelFood;
        private System.Windows.Forms.ToolStripMenuItem xoáMónToolStripMenuItem;
    }
}