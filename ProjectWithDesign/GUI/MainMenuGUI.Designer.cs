namespace ProjectWithDesign.GUI
{
    partial class MainMenuGUI
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
            FontAwesome.Sharp.IconButton btnTableFood;
            FontAwesome.Sharp.IconButton btnBill;
            FontAwesome.Sharp.IconButton btnCateNFood;
            FontAwesome.Sharp.IconButton btnAccount;
            FontAwesome.Sharp.IconButton btnLogout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuGUI));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconAcconut = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconTitle = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            btnTableFood = new FontAwesome.Sharp.IconButton();
            btnBill = new FontAwesome.Sharp.IconButton();
            btnCateNFood = new FontAwesome.Sharp.IconButton();
            btnAccount = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAcconut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTableFood
            // 
            btnTableFood.FlatAppearance.BorderSize = 0;
            btnTableFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTableFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTableFood.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            btnTableFood.IconColor = System.Drawing.Color.White;
            btnTableFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTableFood.IconSize = 32;
            btnTableFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTableFood.Location = new System.Drawing.Point(0, 107);
            btnTableFood.Name = "btnTableFood";
            btnTableFood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnTableFood.Size = new System.Drawing.Size(180, 65);
            btnTableFood.TabIndex = 7;
            btnTableFood.Text = "Bàn ăn";
            btnTableFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTableFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTableFood.UseVisualStyleBackColor = true;
            btnTableFood.Click += new System.EventHandler(this.btnTableFood_Click_1);
            // 
            // btnBill
            // 
            btnBill.FlatAppearance.BorderSize = 0;
            btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBill.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBill.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnBill.IconColor = System.Drawing.Color.White;
            btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBill.IconSize = 32;
            btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBill.Location = new System.Drawing.Point(0, 178);
            btnBill.Name = "btnBill";
            btnBill.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnBill.Size = new System.Drawing.Size(180, 65);
            btnBill.TabIndex = 8;
            btnBill.Text = "Bill";
            btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCateNFood
            // 
            btnCateNFood.FlatAppearance.BorderSize = 0;
            btnCateNFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCateNFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCateNFood.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            btnCateNFood.IconColor = System.Drawing.Color.White;
            btnCateNFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCateNFood.IconSize = 32;
            btnCateNFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCateNFood.Location = new System.Drawing.Point(0, 249);
            btnCateNFood.Name = "btnCateNFood";
            btnCateNFood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnCateNFood.Size = new System.Drawing.Size(180, 65);
            btnCateNFood.TabIndex = 9;
            btnCateNFood.Text = "Món ăn";
            btnCateNFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCateNFood.UseVisualStyleBackColor = true;
            btnCateNFood.Click += new System.EventHandler(this.btnCateNFood_Click);
            // 
            // btnAccount
            // 
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAccount.IconChar = FontAwesome.Sharp.IconChar.User;
            btnAccount.IconColor = System.Drawing.Color.White;
            btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccount.IconSize = 32;
            btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAccount.Location = new System.Drawing.Point(0, 320);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnAccount.Size = new System.Drawing.Size(180, 65);
            btnAccount.TabIndex = 10;
            btnAccount.Text = "Tài khoản";
            btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += new System.EventHandler(this.btnAccount_Click_1);
            // 
            // btnLogout
            // 
            btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = System.Drawing.Color.Red;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 32;
            btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogout.Location = new System.Drawing.Point(0, 582);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            btnLogout.Size = new System.Drawing.Size(180, 65);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Đăng xuất";
            btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(btnLogout);
            this.panelMenu.Controls.Add(btnAccount);
            this.panelMenu.Controls.Add(btnCateNFood);
            this.panelMenu.Controls.Add(btnBill);
            this.panelMenu.Controls.Add(btnTableFood);
            this.panelMenu.Controls.Add(this.btnMain);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMenu.Size = new System.Drawing.Size(180, 667);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.Location = new System.Drawing.Point(3, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(177, 108);
            this.btnMain.TabIndex = 5;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelTitleBar.Controls.Add(this.labelDate);
            this.panelTitleBar.Controls.Add(this.labelTime);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.iconAcconut);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.iconButton2);
            this.panelTitleBar.Controls.Add(this.iconTitle);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1093, 57);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelDate.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDate.Location = new System.Drawing.Point(522, 17);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(69, 28);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "DATE";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelTime.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTime.Location = new System.Drawing.Point(265, 19);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(68, 28);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "TIME";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(938, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin";
            // 
            // iconAcconut
            // 
            this.iconAcconut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconAcconut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.iconAcconut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconAcconut.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconAcconut.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconAcconut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAcconut.Location = new System.Drawing.Point(906, 21);
            this.iconAcconut.Name = "iconAcconut";
            this.iconAcconut.Size = new System.Drawing.Size(32, 32);
            this.iconAcconut.TabIndex = 7;
            this.iconAcconut.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1049, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(19, 23);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(1021, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 23);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "iconButton1";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(1070, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(23, 23);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconTitle
            // 
            this.iconTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.iconTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconTitle.IconColor = System.Drawing.Color.MediumPurple;
            this.iconTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTitle.IconSize = 40;
            this.iconTitle.Location = new System.Drawing.Point(45, 17);
            this.iconTitle.Name = "iconTitle";
            this.iconTitle.Size = new System.Drawing.Size(32, 32);
            this.iconTitle.TabIndex = 2;
            this.iconTitle.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(77, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(52, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(180, 57);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1093, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.label9);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Controls.Add(this.label7);
            this.panelDesktop.Controls.Add(this.label6);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelDesktop.Location = new System.Drawing.Point(180, 66);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1093, 601);
            this.panelDesktop.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trần Đại Nhã     DH51805207";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trần Bảo Phúc  DH51805372";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thành viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giáo viên hướng đẫn: THS.Nguyễn Ngọc Lâm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 6);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(258, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(691, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Công việc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(733, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh sách liên kết: Trần Bảo Phúc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(733, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Danh sách đơn và List: Trần Đại Nhã";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(733, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(332, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Thiết kế: Trần Đại Nhã và Trần Bảo Phúc";
            // 
            // MainMenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1273, 667);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuGUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Restaurant";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAcconut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTitle)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox iconTitle;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconAcconut;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}