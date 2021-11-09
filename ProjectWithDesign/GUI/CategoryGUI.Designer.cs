namespace ProjectWithDesign.GUI
{
    partial class CategoryGUI
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
            this.lvFood = new System.Windows.Forms.ListView();
            this.colIfFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdFoodCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFoodCategory = new System.Windows.Forms.ListView();
            this.colIdCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNameCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.iconFind = new FontAwesome.Sharp.IconPictureBox();
            this.panelLayoutManage = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelAddCate = new System.Windows.Forms.Panel();
            this.panelIDCate = new System.Windows.Forms.Panel();
            this.btnEditCate = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDCat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnmeCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbFoodOrCate = new System.Windows.Forms.CheckBox();
            this.tbnAddFoodNCate = new FontAwesome.Sharp.IconButton();
            this.panelIDFood = new System.Windows.Forms.Panel();
            this.btnEditFood = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIDmenu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAddFood = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtUnitCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.nudPriceFood = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCatFoodmenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFoodmenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconBack = new FontAwesome.Sharp.IconPictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delFood = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaLoạiĐồĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinLoạiĐồĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboTypeList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconFind)).BeginInit();
            this.panelLayoutManage.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelAddCate.SuspendLayout();
            this.panelIDCate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelIDFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelAddFood.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFood)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBack)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFood
            // 
            this.lvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIfFood,
            this.colIdFoodCategory,
            this.colFoodName,
            this.colPrice,
            this.colUnit});
            this.lvFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFood.FullRowSelect = true;
            this.lvFood.HideSelection = false;
            this.lvFood.Location = new System.Drawing.Point(553, 70);
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(624, 403);
            this.lvFood.TabIndex = 22;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            this.lvFood.View = System.Windows.Forms.View.Details;
            this.lvFood.SelectedIndexChanged += new System.EventHandler(this.lvFood_SelectedIndexChanged);
            this.lvFood.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvFood_MouseDown);
            // 
            // colIfFood
            // 
            this.colIfFood.Text = "Mã thức ăn";
            this.colIfFood.Width = 107;
            // 
            // colIdFoodCategory
            // 
            this.colIdFoodCategory.Text = "Mã loại thức ăn";
            this.colIdFoodCategory.Width = 113;
            // 
            // colFoodName
            // 
            this.colFoodName.Text = "Tên món";
            this.colFoodName.Width = 98;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Giá";
            this.colPrice.Width = 58;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Đợn vị tính";
            this.colUnit.Width = 90;
            // 
            // lvFoodCategory
            // 
            this.lvFoodCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdCategory,
            this.colNameCategory});
            this.lvFoodCategory.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFoodCategory.FullRowSelect = true;
            this.lvFoodCategory.HideSelection = false;
            this.lvFoodCategory.Location = new System.Drawing.Point(196, 70);
            this.lvFoodCategory.Name = "lvFoodCategory";
            this.lvFoodCategory.Size = new System.Drawing.Size(260, 403);
            this.lvFoodCategory.TabIndex = 20;
            this.lvFoodCategory.UseCompatibleStateImageBehavior = false;
            this.lvFoodCategory.View = System.Windows.Forms.View.Details;
            this.lvFoodCategory.SelectedIndexChanged += new System.EventHandler(this.lvFoodCategory_SelectedIndexChanged);
            this.lvFoodCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvFoodCategory_MouseDown);
            // 
            // colIdCategory
            // 
            this.colIdCategory.Text = "Mã loại";
            this.colIdCategory.Width = 67;
            // 
            // colNameCategory
            // 
            this.colNameCategory.Text = "Tên loại";
            this.colNameCategory.Width = 154;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 36;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(196, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 34);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.txtFind.Location = new System.Drawing.Point(772, 21);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(350, 30);
            this.txtFind.TabIndex = 26;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // iconFind
            // 
            this.iconFind.BackColor = System.Drawing.Color.OldLace;
            this.iconFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconFind.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconFind.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFind.IconSize = 36;
            this.iconFind.Location = new System.Drawing.Point(1130, 17);
            this.iconFind.Name = "iconFind";
            this.iconFind.Size = new System.Drawing.Size(43, 36);
            this.iconFind.TabIndex = 27;
            this.iconFind.TabStop = false;
            this.iconFind.MouseLeave += new System.EventHandler(this.iconFind_MouseLeave);
            this.iconFind.MouseHover += new System.EventHandler(this.iconFind_MouseHover);
            // 
            // panelLayoutManage
            // 
            this.panelLayoutManage.Controls.Add(this.btnAdd);
            this.panelLayoutManage.Controls.Add(this.lvFood);
            this.panelLayoutManage.Controls.Add(this.lvFoodCategory);
            this.panelLayoutManage.Controls.Add(this.iconFind);
            this.panelLayoutManage.Controls.Add(this.txtFind);
            this.panelLayoutManage.Location = new System.Drawing.Point(-166, 37);
            this.panelLayoutManage.Name = "panelLayoutManage";
            this.panelLayoutManage.Size = new System.Drawing.Size(1180, 525);
            this.panelLayoutManage.TabIndex = 29;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.panelAddCate);
            this.panelAdd.Controls.Add(this.rdbFoodOrCate);
            this.panelAdd.Controls.Add(this.tbnAddFoodNCate);
            this.panelAdd.Controls.Add(this.panelIDFood);
            this.panelAdd.Controls.Add(this.panelAddFood);
            this.panelAdd.Controls.Add(this.iconBack);
            this.panelAdd.Location = new System.Drawing.Point(1, 33);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(1048, 492);
            this.panelAdd.TabIndex = 28;
            // 
            // panelAddCate
            // 
            this.panelAddCate.Controls.Add(this.panelIDCate);
            this.panelAddCate.Controls.Add(this.panel1);
            this.panelAddCate.Location = new System.Drawing.Point(339, 27);
            this.panelAddCate.Name = "panelAddCate";
            this.panelAddCate.Size = new System.Drawing.Size(498, 115);
            this.panelAddCate.TabIndex = 30;
            // 
            // panelIDCate
            // 
            this.panelIDCate.Controls.Add(this.btnEditCate);
            this.panelIDCate.Controls.Add(this.label7);
            this.panelIDCate.Controls.Add(this.txtIDCat);
            this.panelIDCate.Location = new System.Drawing.Point(48, 12);
            this.panelIDCate.Margin = new System.Windows.Forms.Padding(2);
            this.panelIDCate.Name = "panelIDCate";
            this.panelIDCate.Size = new System.Drawing.Size(434, 49);
            this.panelIDCate.TabIndex = 29;
            // 
            // btnEditCate
            // 
            this.btnEditCate.FlatAppearance.BorderSize = 0;
            this.btnEditCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditCate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditCate.IconColor = System.Drawing.Color.Black;
            this.btnEditCate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCate.IconSize = 36;
            this.btnEditCate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCate.Location = new System.Drawing.Point(324, 6);
            this.btnEditCate.Name = "btnEditCate";
            this.btnEditCate.Size = new System.Drawing.Size(107, 36);
            this.btnEditCate.TabIndex = 29;
            this.btnEditCate.Text = "Sửa";
            this.btnEditCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCate.UseVisualStyleBackColor = true;
            this.btnEditCate.Click += new System.EventHandler(this.btnEditCate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID:";
            // 
            // txtIDCat
            // 
            this.txtIDCat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCat.Location = new System.Drawing.Point(117, 13);
            this.txtIDCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDCat.Name = "txtIDCat";
            this.txtIDCat.ReadOnly = true;
            this.txtIDCat.Size = new System.Drawing.Size(180, 30);
            this.txtIDCat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtnmeCat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 49);
            this.panel1.TabIndex = 7;
            // 
            // txtnmeCat
            // 
            this.txtnmeCat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmeCat.Location = new System.Drawing.Point(117, 10);
            this.txtnmeCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtnmeCat.Name = "txtnmeCat";
            this.txtnmeCat.Size = new System.Drawing.Size(181, 30);
            this.txtnmeCat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Loại:";
            // 
            // rdbFoodOrCate
            // 
            this.rdbFoodOrCate.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbFoodOrCate.AutoSize = true;
            this.rdbFoodOrCate.BackColor = System.Drawing.Color.DarkViolet;
            this.rdbFoodOrCate.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFoodOrCate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbFoodOrCate.Location = new System.Drawing.Point(120, 21);
            this.rdbFoodOrCate.Name = "rdbFoodOrCate";
            this.rdbFoodOrCate.Size = new System.Drawing.Size(95, 35);
            this.rdbFoodOrCate.TabIndex = 30;
            this.rdbFoodOrCate.Text = "Thức ăn";
            this.rdbFoodOrCate.UseVisualStyleBackColor = false;
            this.rdbFoodOrCate.CheckedChanged += new System.EventHandler(this.rdbFoodOrCate_CheckedChanged);
            // 
            // tbnAddFoodNCate
            // 
            this.tbnAddFoodNCate.FlatAppearance.BorderSize = 0;
            this.tbnAddFoodNCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnAddFoodNCate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnAddFoodNCate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbnAddFoodNCate.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.tbnAddFoodNCate.IconColor = System.Drawing.Color.Black;
            this.tbnAddFoodNCate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tbnAddFoodNCate.IconSize = 36;
            this.tbnAddFoodNCate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnAddFoodNCate.Location = new System.Drawing.Point(884, 24);
            this.tbnAddFoodNCate.Name = "tbnAddFoodNCate";
            this.tbnAddFoodNCate.Size = new System.Drawing.Size(107, 36);
            this.tbnAddFoodNCate.TabIndex = 32;
            this.tbnAddFoodNCate.Text = "Thêm";
            this.tbnAddFoodNCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbnAddFoodNCate.UseVisualStyleBackColor = true;
            this.tbnAddFoodNCate.Click += new System.EventHandler(this.tbnAddFoodNCate_Click);
            // 
            // panelIDFood
            // 
            this.panelIDFood.Controls.Add(this.btnEditFood);
            this.panelIDFood.Controls.Add(this.panel6);
            this.panelIDFood.Location = new System.Drawing.Point(336, 37);
            this.panelIDFood.Name = "panelIDFood";
            this.panelIDFood.Size = new System.Drawing.Size(519, 55);
            this.panelIDFood.TabIndex = 31;
            // 
            // btnEditFood
            // 
            this.btnEditFood.FlatAppearance.BorderSize = 0;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditFood.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditFood.IconColor = System.Drawing.Color.Black;
            this.btnEditFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditFood.IconSize = 36;
            this.btnEditFood.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditFood.Location = new System.Drawing.Point(396, 10);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(107, 36);
            this.btnEditFood.TabIndex = 28;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtIDmenu);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(50, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 54);
            this.panel6.TabIndex = 2;
            // 
            // txtIDmenu
            // 
            this.txtIDmenu.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDmenu.Location = new System.Drawing.Point(117, 13);
            this.txtIDmenu.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDmenu.Name = "txtIDmenu";
            this.txtIDmenu.ReadOnly = true;
            this.txtIDmenu.Size = new System.Drawing.Size(181, 30);
            this.txtIDmenu.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(2, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // panelAddFood
            // 
            this.panelAddFood.Controls.Add(this.panel11);
            this.panelAddFood.Controls.Add(this.panel9);
            this.panelAddFood.Controls.Add(this.panel8);
            this.panelAddFood.Controls.Add(this.panel7);
            this.panelAddFood.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAddFood.Location = new System.Drawing.Point(364, 24);
            this.panelAddFood.Name = "panelAddFood";
            this.panelAddFood.Size = new System.Drawing.Size(365, 351);
            this.panelAddFood.TabIndex = 29;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtUnitCount);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(22, 222);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(306, 41);
            this.panel11.TabIndex = 7;
            // 
            // txtUnitCount
            // 
            this.txtUnitCount.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCount.Location = new System.Drawing.Point(135, 8);
            this.txtUnitCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitCount.Name = "txtUnitCount";
            this.txtUnitCount.Size = new System.Drawing.Size(161, 30);
            this.txtUnitCount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn vị tính:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.nudPriceFood);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(22, 169);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(306, 49);
            this.panel9.TabIndex = 9;
            // 
            // nudPriceFood
            // 
            this.nudPriceFood.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPriceFood.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nudPriceFood.Location = new System.Drawing.Point(117, 9);
            this.nudPriceFood.Margin = new System.Windows.Forms.Padding(2);
            this.nudPriceFood.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.nudPriceFood.Name = "nudPriceFood";
            this.nudPriceFood.Size = new System.Drawing.Size(179, 30);
            this.nudPriceFood.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(2, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtCatFoodmenu);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(22, 116);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(306, 49);
            this.panel8.TabIndex = 8;
            // 
            // txtCatFoodmenu
            // 
            this.txtCatFoodmenu.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatFoodmenu.FormattingEnabled = true;
            this.txtCatFoodmenu.Location = new System.Drawing.Point(117, 8);
            this.txtCatFoodmenu.Margin = new System.Windows.Forms.Padding(2);
            this.txtCatFoodmenu.Name = "txtCatFoodmenu";
            this.txtCatFoodmenu.Size = new System.Drawing.Size(181, 30);
            this.txtCatFoodmenu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(2, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Mục:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtFoodmenu);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(22, 63);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(306, 49);
            this.panel7.TabIndex = 6;
            // 
            // txtFoodmenu
            // 
            this.txtFoodmenu.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodmenu.Location = new System.Drawing.Point(117, 10);
            this.txtFoodmenu.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodmenu.Name = "txtFoodmenu";
            this.txtFoodmenu.Size = new System.Drawing.Size(181, 30);
            this.txtFoodmenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Món:";
            // 
            // iconBack
            // 
            this.iconBack.BackColor = System.Drawing.Color.OldLace;
            this.iconBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconBack.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBack.Location = new System.Drawing.Point(29, 24);
            this.iconBack.Name = "iconBack";
            this.iconBack.Size = new System.Drawing.Size(32, 32);
            this.iconBack.TabIndex = 26;
            this.iconBack.TabStop = false;
            this.iconBack.Click += new System.EventHandler(this.iconBack_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delFood,
            this.sửaThôngTinMónĂnToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // delFood
            // 
            this.delFood.Name = "delFood";
            this.delFood.Size = new System.Drawing.Size(189, 22);
            this.delFood.Text = "Xóa món ăn";
            this.delFood.Click += new System.EventHandler(this.delFood_Click);
            // 
            // sửaThôngTinMónĂnToolStripMenuItem
            // 
            this.sửaThôngTinMónĂnToolStripMenuItem.Name = "sửaThôngTinMónĂnToolStripMenuItem";
            this.sửaThôngTinMónĂnToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sửaThôngTinMónĂnToolStripMenuItem.Text = "Sửa thông tin món ăn";
            this.sửaThôngTinMónĂnToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinMónĂnToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaLoạiĐồĂnToolStripMenuItem,
            this.sửaThôngTinLoạiĐồĂnToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(201, 48);
            // 
            // xóaLoạiĐồĂnToolStripMenuItem
            // 
            this.xóaLoạiĐồĂnToolStripMenuItem.Name = "xóaLoạiĐồĂnToolStripMenuItem";
            this.xóaLoạiĐồĂnToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.xóaLoạiĐồĂnToolStripMenuItem.Text = "Xóa loại đồ ăn";
            this.xóaLoạiĐồĂnToolStripMenuItem.Click += new System.EventHandler(this.xóaLoạiĐồĂnToolStripMenuItem_Click);
            // 
            // sửaThôngTinLoạiĐồĂnToolStripMenuItem
            // 
            this.sửaThôngTinLoạiĐồĂnToolStripMenuItem.Name = "sửaThôngTinLoạiĐồĂnToolStripMenuItem";
            this.sửaThôngTinLoạiĐồĂnToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sửaThôngTinLoạiĐồĂnToolStripMenuItem.Text = "Sửa thông tin loại đồ ăn";
            this.sửaThôngTinLoạiĐồĂnToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinLoạiĐồĂnToolStripMenuItem_Click);
            // 
            // cboTypeList
            // 
            this.cboTypeList.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeList.FormattingEnabled = true;
            this.cboTypeList.Items.AddRange(new object[] {
            "Danh sách liên kết",
            "Danh sách đặc",
            "Danh sách đơn"});
            this.cboTypeList.Location = new System.Drawing.Point(1, 0);
            this.cboTypeList.Name = "cboTypeList";
            this.cboTypeList.Size = new System.Drawing.Size(190, 27);
            this.cboTypeList.TabIndex = 30;
            this.cboTypeList.Text = "Danh sách liên kết";
            this.cboTypeList.SelectedIndexChanged += new System.EventHandler(this.cboTypeList_SelectedIndexChanged);
            // 
            // CategoryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1077, 562);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.cboTypeList);
            this.Controls.Add(this.panelLayoutManage);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CategoryGUI";
            this.Text = "Category and Food";
            ((System.ComponentModel.ISupportInitialize)(this.iconFind)).EndInit();
            this.panelLayoutManage.ResumeLayout(false);
            this.panelLayoutManage.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelAddCate.ResumeLayout(false);
            this.panelIDCate.ResumeLayout(false);
            this.panelIDCate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelIDFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelAddFood.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFood)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBack)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.ColumnHeader colIfFood;
        private System.Windows.Forms.ColumnHeader colIdFoodCategory;
        private System.Windows.Forms.ColumnHeader colFoodName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ListView lvFoodCategory;
        private System.Windows.Forms.ColumnHeader colIdCategory;
        private System.Windows.Forms.ColumnHeader colNameCategory;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.TextBox txtFind;
        private FontAwesome.Sharp.IconPictureBox iconFind;
        private System.Windows.Forms.Panel panelLayoutManage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delFood;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem xóaLoạiĐồĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinLoạiĐồĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinMónĂnToolStripMenuItem;
        private System.Windows.Forms.Panel panelAdd;
        private FontAwesome.Sharp.IconPictureBox iconBack;
        private FontAwesome.Sharp.IconButton tbnAddFoodNCate;
        private System.Windows.Forms.Panel panelIDFood;
        private FontAwesome.Sharp.IconButton btnEditFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIDmenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelAddCate;
        private System.Windows.Forms.Panel panelIDCate;
        private FontAwesome.Sharp.IconButton btnEditCate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDCat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnmeCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAddFood;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtUnitCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown nudPriceFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox txtCatFoodmenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtFoodmenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rdbFoodOrCate;
        private System.Windows.Forms.ComboBox cboTypeList;
    }
}