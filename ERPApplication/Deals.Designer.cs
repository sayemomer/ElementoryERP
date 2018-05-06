namespace ERPApplication
{
    partial class Deals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deals));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topbar = new System.Windows.Forms.Panel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.homeTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.dashbar = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.logoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RefreshButton = new System.Windows.Forms.Button();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.dashbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.sideMenu.Controls.Add(this.logoutButton);
            this.sideMenu.Controls.Add(this.logo);
            this.sideMenu.Controls.Add(this.homeTab);
            this.sideMenu.Controls.Add(this.menuButton);
            this.panelTransition.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 63);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(253, 540);
            this.sideMenu.TabIndex = 4;
            // 
            // logoutButton
            // 
            this.logoutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.BorderRadius = 0;
            this.logoutButton.ButtonText = "Logout";
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.logoutButton, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.logoutButton, BunifuAnimatorNS.DecorationType.None);
            this.logoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutButton.Iconimage")));
            this.logoutButton.Iconimage_right = null;
            this.logoutButton.Iconimage_right_Selected = null;
            this.logoutButton.Iconimage_Selected = null;
            this.logoutButton.IconMarginLeft = 0;
            this.logoutButton.IconMarginRight = 0;
            this.logoutButton.IconRightVisible = true;
            this.logoutButton.IconRightZoom = 0D;
            this.logoutButton.IconVisible = true;
            this.logoutButton.IconZoom = 90D;
            this.logoutButton.IsTab = false;
            this.logoutButton.Location = new System.Drawing.Point(1, 234);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.logoutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.logoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutButton.selected = true;
            this.logoutButton.Size = new System.Drawing.Size(252, 57);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutButton.Textcolor = System.Drawing.Color.White;
            this.logoutButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Click += new System.EventHandler(this.logout_clicked);
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
            // homeTab
            // 
            this.homeTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.homeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.homeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeTab.BorderRadius = 0;
            this.homeTab.ButtonText = "Home";
            this.homeTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransition.SetDecoration(this.homeTab, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.homeTab, BunifuAnimatorNS.DecorationType.None);
            this.homeTab.DisabledColor = System.Drawing.Color.Gray;
            this.homeTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTab.Iconcolor = System.Drawing.Color.Transparent;
            this.homeTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("homeTab.Iconimage")));
            this.homeTab.Iconimage_right = null;
            this.homeTab.Iconimage_right_Selected = null;
            this.homeTab.Iconimage_Selected = null;
            this.homeTab.IconMarginLeft = 0;
            this.homeTab.IconMarginRight = 0;
            this.homeTab.IconRightVisible = true;
            this.homeTab.IconRightZoom = 0D;
            this.homeTab.IconVisible = true;
            this.homeTab.IconZoom = 90D;
            this.homeTab.IsTab = true;
            this.homeTab.Location = new System.Drawing.Point(5, 157);
            this.homeTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.homeTab.Name = "homeTab";
            this.homeTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.homeTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.homeTab.OnHoverTextColor = System.Drawing.Color.White;
            this.homeTab.selected = true;
            this.homeTab.Size = new System.Drawing.Size(252, 57);
            this.homeTab.TabIndex = 1;
            this.homeTab.Text = "Home";
            this.homeTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeTab.Textcolor = System.Drawing.Color.White;
            this.homeTab.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTab.Click += new System.EventHandler(this.homeTab_click);
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
            // dashbar
            // 
            this.dashbar.Controls.Add(this.RefreshButton);
            this.dashbar.Controls.Add(this.dataGrid);
            this.dashbar.Controls.Add(this.textBox7);
            this.dashbar.Controls.Add(this.textBox6);
            this.dashbar.Controls.Add(this.textBox5);
            this.dashbar.Controls.Add(this.textBox4);
            this.dashbar.Controls.Add(this.textBox3);
            this.dashbar.Controls.Add(this.textBox2);
            this.dashbar.Controls.Add(this.textBox1);
            this.dashbar.Controls.Add(this.searchBtn);
            this.dashbar.Controls.Add(this.searchTBox);
            this.dashbar.Controls.Add(this.deleteBtn);
            this.dashbar.Controls.Add(this.updateBtn);
            this.dashbar.Controls.Add(this.insertBtn);
            this.panelTransition.SetDecoration(this.dashbar, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.dashbar, BunifuAnimatorNS.DecorationType.None);
            this.dashbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashbar.Location = new System.Drawing.Point(253, 63);
            this.dashbar.Name = "dashbar";
            this.dashbar.Size = new System.Drawing.Size(833, 540);
            this.dashbar.TabIndex = 5;
            this.dashbar.Paint += new System.Windows.Forms.PaintEventHandler(this.dashbar_Paint);
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
            this.dataGrid.Location = new System.Drawing.Point(3, 6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.Size = new System.Drawing.Size(818, 427);
            this.dataGrid.TabIndex = 40;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // textBox7
            // 
            this.logoTransition.SetDecoration(this.textBox7, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox7, BunifuAnimatorNS.DecorationType.None);
            this.textBox7.Location = new System.Drawing.Point(690, 493);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 23;
            // 
            // textBox6
            // 
            this.logoTransition.SetDecoration(this.textBox6, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox6, BunifuAnimatorNS.DecorationType.None);
            this.textBox6.Location = new System.Drawing.Point(584, 493);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox5
            // 
            this.logoTransition.SetDecoration(this.textBox5, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox5, BunifuAnimatorNS.DecorationType.None);
            this.textBox5.Location = new System.Drawing.Point(478, 493);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.logoTransition.SetDecoration(this.textBox4, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox4, BunifuAnimatorNS.DecorationType.None);
            this.textBox4.Location = new System.Drawing.Point(372, 493);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.logoTransition.SetDecoration(this.textBox3, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox3, BunifuAnimatorNS.DecorationType.None);
            this.textBox3.Location = new System.Drawing.Point(266, 493);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.logoTransition.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.textBox2.Location = new System.Drawing.Point(160, 493);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.logoTransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(54, 493);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // searchBtn
            // 
            this.logoTransition.SetDecoration(this.searchBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.searchBtn, BunifuAnimatorNS.DecorationType.None);
            this.searchBtn.Location = new System.Drawing.Point(450, 450);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchTBox
            // 
            this.logoTransition.SetDecoration(this.searchTBox, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.searchTBox, BunifuAnimatorNS.DecorationType.None);
            this.searchTBox.Location = new System.Drawing.Point(344, 453);
            this.searchTBox.Name = "searchTBox";
            this.searchTBox.Size = new System.Drawing.Size(100, 20);
            this.searchTBox.TabIndex = 15;
            // 
            // deleteBtn
            // 
            this.logoTransition.SetDecoration(this.deleteBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.deleteBtn, BunifuAnimatorNS.DecorationType.None);
            this.deleteBtn.Location = new System.Drawing.Point(263, 451);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.logoTransition.SetDecoration(this.updateBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.updateBtn, BunifuAnimatorNS.DecorationType.None);
            this.updateBtn.Location = new System.Drawing.Point(182, 451);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.logoTransition.SetDecoration(this.insertBtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.insertBtn, BunifuAnimatorNS.DecorationType.None);
            this.insertBtn.Location = new System.Drawing.Point(101, 451);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 11;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
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
            // RefreshButton
            // 
            this.logoTransition.SetDecoration(this.RefreshButton, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.RefreshButton, BunifuAnimatorNS.DecorationType.None);
            this.RefreshButton.Location = new System.Drawing.Point(531, 451);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 41;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Deals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 603);
            this.Controls.Add(this.dashbar);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.topbar);
            this.logoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deals";
            this.Text = "Deals";
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.dashbar.ResumeLayout(false);
            this.dashbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel topbar;
        internal System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.PictureBox logo;
        internal Bunifu.Framework.UI.BunifuFlatButton homeTab;
        internal Bunifu.Framework.UI.BunifuImageButton menuButton;
        internal System.Windows.Forms.Panel dashbar;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private BunifuAnimatorNS.BunifuTransition logoTransition;
        private BunifuAnimatorNS.BunifuTransition panelTransition;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox searchTBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button RefreshButton;
    }
}