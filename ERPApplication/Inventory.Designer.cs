namespace ERPApplication
{
    partial class Inventory
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topbar = new System.Windows.Forms.Panel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoutTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.logoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.searchTBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.panelTransition.SetDecoration(this.topbar, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.topbar, BunifuAnimatorNS.DecorationType.None);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1086, 63);
            this.topbar.TabIndex = 2;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.sideMenu.Controls.Add(this.logo);
            this.sideMenu.Controls.Add(this.logoutTab);
            this.sideMenu.Controls.Add(this.HomeTab);
            this.sideMenu.Controls.Add(this.menuButton);
            this.panelTransition.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 63);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(253, 540);
            this.sideMenu.TabIndex = 3;
            // 
            // logo
            // 
            this.logoTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Location = new System.Drawing.Point(3, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(198, 76);
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // logoutTab
            // 
            this.logoutTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.logoutTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.logoutTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutTab.BorderRadius = 0;
            this.logoutTab.ButtonText = "Logout";
            this.logoutTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.logoutTab, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.logoutTab, BunifuAnimatorNS.DecorationType.None);
            this.logoutTab.DisabledColor = System.Drawing.Color.Gray;
            this.logoutTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutTab.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutTab.Iconimage")));
            this.logoutTab.Iconimage_right = null;
            this.logoutTab.Iconimage_right_Selected = null;
            this.logoutTab.Iconimage_Selected = null;
            this.logoutTab.IconMarginLeft = 0;
            this.logoutTab.IconMarginRight = 0;
            this.logoutTab.IconRightVisible = true;
            this.logoutTab.IconRightZoom = 0D;
            this.logoutTab.IconVisible = true;
            this.logoutTab.IconZoom = 90D;
            this.logoutTab.IsTab = false;
            this.logoutTab.Location = new System.Drawing.Point(1, 181);
            this.logoutTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logoutTab.Name = "logoutTab";
            this.logoutTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.logoutTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.logoutTab.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutTab.selected = false;
            this.logoutTab.Size = new System.Drawing.Size(252, 57);
            this.logoutTab.TabIndex = 6;
            this.logoutTab.Text = "Logout";
            this.logoutTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutTab.Textcolor = System.Drawing.Color.White;
            this.logoutTab.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutTab.Click += new System.EventHandler(this.logoutTab_Click);
            // 
            // HomeTab
            // 
            this.HomeTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.HomeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.HomeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeTab.BorderRadius = 0;
            this.HomeTab.ButtonText = "Home";
            this.HomeTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.HomeTab, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.HomeTab, BunifuAnimatorNS.DecorationType.None);
            this.HomeTab.DisabledColor = System.Drawing.Color.Gray;
            this.HomeTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.Iconcolor = System.Drawing.Color.Transparent;
            this.HomeTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("HomeTab.Iconimage")));
            this.HomeTab.Iconimage_right = null;
            this.HomeTab.Iconimage_right_Selected = null;
            this.HomeTab.Iconimage_Selected = null;
            this.HomeTab.IconMarginLeft = 0;
            this.HomeTab.IconMarginRight = 0;
            this.HomeTab.IconRightVisible = true;
            this.HomeTab.IconRightZoom = 0D;
            this.HomeTab.IconVisible = true;
            this.HomeTab.IconZoom = 90D;
            this.HomeTab.IsTab = true;
            this.HomeTab.Location = new System.Drawing.Point(0, 116);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.HomeTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.HomeTab.OnHoverTextColor = System.Drawing.Color.White;
            this.HomeTab.selected = true;
            this.HomeTab.Size = new System.Drawing.Size(252, 57);
            this.HomeTab.TabIndex = 1;
            this.HomeTab.Text = "Home";
            this.HomeTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeTab.Textcolor = System.Drawing.Color.White;
            this.HomeTab.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab.Click += new System.EventHandler(this.HomeTab_Click);
            // 
            // menuButton
            // 
            this.menuButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.panelTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(208, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(45, 39);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.logoTransition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation6;
            // 
            // searchTBox
            // 
            this.logoTransition.SetDecoration(this.searchTBox, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.searchTBox, BunifuAnimatorNS.DecorationType.None);
            this.searchTBox.Location = new System.Drawing.Point(379, 19);
            this.searchTBox.Name = "searchTBox";
            this.searchTBox.Size = new System.Drawing.Size(100, 20);
            this.searchTBox.TabIndex = 14;
            this.searchTBox.TextChanged += new System.EventHandler(this.searchTBox_TextChanged);
            // 
            // searchBtn
            // 
            this.logoTransition.SetDecoration(this.searchBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.searchBtn, BunifuAnimatorNS.DecorationType.None);
            this.searchBtn.Location = new System.Drawing.Point(485, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.logoTransition.SetDecoration(this.deleteBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.deleteBtn, BunifuAnimatorNS.DecorationType.None);
            this.deleteBtn.Location = new System.Drawing.Point(298, 19);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.logoTransition.SetDecoration(this.updateBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.updateBtn, BunifuAnimatorNS.DecorationType.None);
            this.updateBtn.Location = new System.Drawing.Point(217, 19);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.logoTransition.SetDecoration(this.insertBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.insertBtn, BunifuAnimatorNS.DecorationType.None);
            this.insertBtn.Location = new System.Drawing.Point(136, 19);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 10;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // textBox1
            // 
            this.logoTransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(161, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.logoTransition.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.textBox2.Location = new System.Drawing.Point(267, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.logoTransition.SetDecoration(this.textBox3, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox3, BunifuAnimatorNS.DecorationType.None);
            this.textBox3.Location = new System.Drawing.Point(373, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // textBox5
            // 
            this.logoTransition.SetDecoration(this.textBox5, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox5, BunifuAnimatorNS.DecorationType.None);
            this.textBox5.Location = new System.Drawing.Point(479, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // textBox7
            // 
            this.logoTransition.SetDecoration(this.textBox7, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox7, BunifuAnimatorNS.DecorationType.None);
            this.textBox7.Location = new System.Drawing.Point(691, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.logoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(179, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.logoTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(279, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Product Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.logoTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(409, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Volume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.logoTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(513, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Store";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.logoTransition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(623, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Catagory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.logoTransition.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(727, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tax";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.panelTransition.SetDecoration(this.dataGrid, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.dataGrid, BunifuAnimatorNS.DecorationType.None);
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(259, 69);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.Size = new System.Drawing.Size(815, 402);
            this.dataGrid.TabIndex = 31;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refreshbtn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.insertBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.searchTBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.panelTransition.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(259, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 104);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "s";
            // 
            // comboBox1
            // 
            this.panelTransition.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bike",
            "Car",
            "Cng",
            "Microbus",
            "Pickup",
            "Truck"});
            this.comboBox1.Location = new System.Drawing.Point(585, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.panelTransition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.panelTransition.DefaultAnimation = animation5;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topbar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Refreshbtn
            // 
            this.logoTransition.SetDecoration(this.Refreshbtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.Refreshbtn, BunifuAnimatorNS.DecorationType.None);
            this.Refreshbtn.Location = new System.Drawing.Point(566, 16);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 65;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.topbar);
            this.logoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel topbar;
        internal System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton logoutTab;
        internal Bunifu.Framework.UI.BunifuFlatButton HomeTab;
        internal Bunifu.Framework.UI.BunifuImageButton menuButton;
        private BunifuAnimatorNS.BunifuTransition logoTransition;
        private BunifuAnimatorNS.BunifuTransition panelTransition;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox searchTBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Refreshbtn;
    }
}