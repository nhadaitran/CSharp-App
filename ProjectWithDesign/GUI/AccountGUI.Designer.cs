namespace ProjectWithDesign.GUI
{
    partial class AccountGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUserName = new System.Windows.Forms.Panel();
            this.TxbNewName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditUserName = new FontAwesome.Sharp.IconButton();
            this.btnUsername = new FontAwesome.Sharp.IconButton();
            this.BtnPassword = new FontAwesome.Sharp.IconButton();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.btnEditPassword = new FontAwesome.Sharp.IconButton();
            this.TxbRenewPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvAccount = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.cboTypeList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelUserName.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.cboTypeList);
            this.panel1.Controls.Add(this.panelUserName);
            this.panel1.Controls.Add(this.btnUsername);
            this.panel1.Controls.Add(this.BtnPassword);
            this.panel1.Controls.Add(this.panelPassword);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lvAccount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 562);
            this.panel1.TabIndex = 15;
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.TxbNewName);
            this.panelUserName.Controls.Add(this.label10);
            this.panelUserName.Controls.Add(this.btnEditUserName);
            this.panelUserName.Location = new System.Drawing.Point(624, 349);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(412, 166);
            this.panelUserName.TabIndex = 31;
            // 
            // TxbNewName
            // 
            this.TxbNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbNewName.BackColor = System.Drawing.Color.White;
            this.TxbNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbNewName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNewName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxbNewName.Location = new System.Drawing.Point(186, 29);
            this.TxbNewName.Name = "TxbNewName";
            this.TxbNewName.Size = new System.Drawing.Size(223, 23);
            this.TxbNewName.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label10.Location = new System.Drawing.Point(3, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tên tài khoản mới ";
            // 
            // btnEditUserName
            // 
            this.btnEditUserName.FlatAppearance.BorderSize = 0;
            this.btnEditUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUserName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditUserName.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditUserName.IconColor = System.Drawing.Color.Black;
            this.btnEditUserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditUserName.IconSize = 36;
            this.btnEditUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUserName.Location = new System.Drawing.Point(302, 71);
            this.btnEditUserName.Name = "btnEditUserName";
            this.btnEditUserName.Size = new System.Drawing.Size(107, 36);
            this.btnEditUserName.TabIndex = 30;
            this.btnEditUserName.Text = "Sửa";
            this.btnEditUserName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditUserName.UseVisualStyleBackColor = true;
            this.btnEditUserName.Click += new System.EventHandler(this.btnEditUserName_Click);
            // 
            // btnUsername
            // 
            this.btnUsername.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUsername.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsername.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnUsername.IconColor = System.Drawing.Color.Black;
            this.btnUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsername.IconSize = 46;
            this.btnUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsername.Location = new System.Drawing.Point(857, 281);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(179, 44);
            this.btnUsername.TabIndex = 20;
            this.btnUsername.Text = "Tên tài khoản";
            this.btnUsername.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsername.UseVisualStyleBackColor = true;
            this.btnUsername.Click += new System.EventHandler(this.btnUsername_Click);
            // 
            // BtnPassword
            // 
            this.BtnPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPassword.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.BtnPassword.IconColor = System.Drawing.Color.Black;
            this.BtnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPassword.IconSize = 46;
            this.BtnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPassword.Location = new System.Drawing.Point(617, 281);
            this.BtnPassword.Name = "BtnPassword";
            this.BtnPassword.Size = new System.Drawing.Size(178, 44);
            this.BtnPassword.TabIndex = 19;
            this.BtnPassword.Text = "Mật khẩu";
            this.BtnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPassword.UseVisualStyleBackColor = true;
            this.BtnPassword.Click += new System.EventHandler(this.BtnPassword_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.btnEditPassword);
            this.panelPassword.Controls.Add(this.TxbRenewPassword);
            this.panelPassword.Controls.Add(this.txbNewPassword);
            this.panelPassword.Controls.Add(this.label8);
            this.panelPassword.Controls.Add(this.label4);
            this.panelPassword.Location = new System.Drawing.Point(624, 349);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(412, 166);
            this.panelPassword.TabIndex = 18;
            // 
            // btnEditPassword
            // 
            this.btnEditPassword.FlatAppearance.BorderSize = 0;
            this.btnEditPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditPassword.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditPassword.IconColor = System.Drawing.Color.Black;
            this.btnEditPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditPassword.IconSize = 36;
            this.btnEditPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPassword.Location = new System.Drawing.Point(302, 113);
            this.btnEditPassword.Name = "btnEditPassword";
            this.btnEditPassword.Size = new System.Drawing.Size(107, 36);
            this.btnEditPassword.TabIndex = 30;
            this.btnEditPassword.Text = "Sửa";
            this.btnEditPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPassword.UseVisualStyleBackColor = true;
            this.btnEditPassword.Click += new System.EventHandler(this.btnEditPassword_Click);
            // 
            // TxbRenewPassword
            // 
            this.TxbRenewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbRenewPassword.BackColor = System.Drawing.Color.White;
            this.TxbRenewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbRenewPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbRenewPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxbRenewPassword.Location = new System.Drawing.Point(186, 70);
            this.TxbRenewPassword.Name = "TxbRenewPassword";
            this.TxbRenewPassword.Size = new System.Drawing.Size(223, 23);
            this.TxbRenewPassword.TabIndex = 5;
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNewPassword.BackColor = System.Drawing.Color.White;
            this.txbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNewPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbNewPassword.Location = new System.Drawing.Point(186, 28);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(223, 23);
            this.txbNewPassword.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu mới ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.7167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.2833F));
            this.tableLayoutPanel1.Controls.Add(this.txbPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxbName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(624, 84);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 170);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPassword.BackColor = System.Drawing.Color.OldLace;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbPassword.Location = new System.Drawing.Point(195, 129);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(214, 23);
            this.txbPassword.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Tài khoản";
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsername.BackColor = System.Drawing.Color.OldLace;
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbUsername.Location = new System.Drawing.Point(195, 16);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(214, 23);
            this.txbUsername.TabIndex = 5;
            // 
            // TxbName
            // 
            this.TxbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbName.BackColor = System.Drawing.Color.OldLace;
            this.TxbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxbName.Location = new System.Drawing.Point(195, 72);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(214, 23);
            this.TxbName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // lvAccount
            // 
            this.lvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvAccount.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.lvAccount.FullRowSelect = true;
            this.lvAccount.HideSelection = false;
            this.lvAccount.Location = new System.Drawing.Point(93, 52);
            this.lvAccount.Name = "lvAccount";
            this.lvAccount.Size = new System.Drawing.Size(506, 463);
            this.lvAccount.TabIndex = 16;
            this.lvAccount.UseCompatibleStateImageBehavior = false;
            this.lvAccount.View = System.Windows.Forms.View.Details;
            this.lvAccount.SelectedIndexChanged += new System.EventHandler(this.lvAccount_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại Tài Khoản";
            this.columnHeader5.Width = 142;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Username";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mật Khẩu";
            this.columnHeader7.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên Tài Khoản";
            this.columnHeader8.Width = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(749, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "THÔNG TIN";
            // 
            // cboTypeList
            // 
            this.cboTypeList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeList.FormattingEnabled = true;
            this.cboTypeList.Items.AddRange(new object[] {
            "Danh sách liên kết",
            "Danh sách đặc",
            "Danh sách đơn"});
            this.cboTypeList.Location = new System.Drawing.Point(0, 0);
            this.cboTypeList.Name = "cboTypeList";
            this.cboTypeList.Size = new System.Drawing.Size(190, 27);
            this.cboTypeList.TabIndex = 33;
            this.cboTypeList.Text = "Danh sách liên kết";
            this.cboTypeList.SelectedIndexChanged += new System.EventHandler(this.cboTypeList_SelectedIndexChanged);
            // 
            // AccountGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 562);
            this.Controls.Add(this.panel1);
            this.Name = "AccountGUI";
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAccount;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnUsername;
        private FontAwesome.Sharp.IconButton BtnPassword;
        private System.Windows.Forms.TextBox TxbRenewPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelUserName;
        private System.Windows.Forms.TextBox TxbNewName;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnEditUserName;
        private FontAwesome.Sharp.IconButton btnEditPassword;
        private System.Windows.Forms.ComboBox cboTypeList;
    }
}