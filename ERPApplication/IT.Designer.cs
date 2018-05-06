namespace ERPApplication
{
    partial class IT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topbar = new System.Windows.Forms.Panel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.PasswordTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoutTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HomeTab12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.updateBtnP = new System.Windows.Forms.Button();
            this.paswrdSetTBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassSetBtn = new System.Windows.Forms.Button();
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1107, 63);
            this.topbar.TabIndex = 3;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.sideMenu.Controls.Add(this.PasswordTab);
            this.sideMenu.Controls.Add(this.logo);
            this.sideMenu.Controls.Add(this.logoutTab);
            this.sideMenu.Controls.Add(this.HomeTab12);
            this.sideMenu.Controls.Add(this.menuButton);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 63);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(253, 429);
            this.sideMenu.TabIndex = 4;
            // 
            // PasswordTab
            // 
            this.PasswordTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.PasswordTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.PasswordTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordTab.BorderRadius = 0;
            this.PasswordTab.ButtonText = "Set Password";
            this.PasswordTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordTab.DisabledColor = System.Drawing.Color.Gray;
            this.PasswordTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTab.Iconcolor = System.Drawing.Color.Transparent;
            this.PasswordTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("PasswordTab.Iconimage")));
            this.PasswordTab.Iconimage_right = null;
            this.PasswordTab.Iconimage_right_Selected = null;
            this.PasswordTab.Iconimage_Selected = null;
            this.PasswordTab.IconMarginLeft = 0;
            this.PasswordTab.IconMarginRight = 0;
            this.PasswordTab.IconRightVisible = true;
            this.PasswordTab.IconRightZoom = 0D;
            this.PasswordTab.IconVisible = true;
            this.PasswordTab.IconZoom = 90D;
            this.PasswordTab.IsTab = false;
            this.PasswordTab.Location = new System.Drawing.Point(0, 183);
            this.PasswordTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PasswordTab.Name = "PasswordTab";
            this.PasswordTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.PasswordTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.PasswordTab.OnHoverTextColor = System.Drawing.Color.White;
            this.PasswordTab.selected = false;
            this.PasswordTab.Size = new System.Drawing.Size(252, 57);
            this.PasswordTab.TabIndex = 8;
            this.PasswordTab.Text = "Set Password";
            this.PasswordTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordTab.Textcolor = System.Drawing.Color.White;
            this.PasswordTab.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTab.Click += new System.EventHandler(this.PasswordTab_clicked);
            // 
            // logo
            // 
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
            this.logoutTab.Location = new System.Drawing.Point(0, 248);
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
            this.logoutTab.Click += new System.EventHandler(this.logoutTab_clicked);
            // 
            // HomeTab12
            // 
            this.HomeTab12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.HomeTab12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.HomeTab12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeTab12.BorderRadius = 0;
            this.HomeTab12.ButtonText = "Home";
            this.HomeTab12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeTab12.DisabledColor = System.Drawing.Color.Gray;
            this.HomeTab12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab12.Iconcolor = System.Drawing.Color.Transparent;
            this.HomeTab12.Iconimage = ((System.Drawing.Image)(resources.GetObject("HomeTab12.Iconimage")));
            this.HomeTab12.Iconimage_right = null;
            this.HomeTab12.Iconimage_right_Selected = null;
            this.HomeTab12.Iconimage_Selected = null;
            this.HomeTab12.IconMarginLeft = 0;
            this.HomeTab12.IconMarginRight = 0;
            this.HomeTab12.IconRightVisible = true;
            this.HomeTab12.IconRightZoom = 0D;
            this.HomeTab12.IconVisible = true;
            this.HomeTab12.IconZoom = 90D;
            this.HomeTab12.IsTab = true;
            this.HomeTab12.Location = new System.Drawing.Point(0, 118);
            this.HomeTab12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.HomeTab12.Name = "HomeTab12";
            this.HomeTab12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.HomeTab12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.HomeTab12.OnHoverTextColor = System.Drawing.Color.White;
            this.HomeTab12.selected = true;
            this.HomeTab12.Size = new System.Drawing.Size(252, 57);
            this.HomeTab12.TabIndex = 1;
            this.HomeTab12.Text = "Home";
            this.HomeTab12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeTab12.Textcolor = System.Drawing.Color.White;
            this.HomeTab12.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTab12.Click += new System.EventHandler(this.HomeTab12_clicked);
            // 
            // menuButton
            // 
            this.menuButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(208, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(45, 39);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Zoom = 10;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(259, 63);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.Size = new System.Drawing.Size(836, 305);
            this.dataGrid.TabIndex = 32;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridcell_clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassSetBtn);
            this.groupBox1.Controls.Add(this.Refreshbtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.updateBtnP);
            this.groupBox1.Controls.Add(this.paswrdSetTBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(259, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 106);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(427, 19);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 66;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Password";
            // 
            // updateBtnP
            // 
            this.updateBtnP.Location = new System.Drawing.Point(134, 16);
            this.updateBtnP.Name = "updateBtnP";
            this.updateBtnP.Size = new System.Drawing.Size(75, 23);
            this.updateBtnP.TabIndex = 11;
            this.updateBtnP.Text = "Update";
            this.updateBtnP.UseVisualStyleBackColor = true;
            this.updateBtnP.Click += new System.EventHandler(this.updateBtnP_clicked);
            // 
            // paswrdSetTBox
            // 
            this.paswrdSetTBox.Location = new System.Drawing.Point(321, 19);
            this.paswrdSetTBox.Name = "paswrdSetTBox";
            this.paswrdSetTBox.Size = new System.Drawing.Size(100, 20);
            this.paswrdSetTBox.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Employee Id";
            // 
            // PassSetBtn
            // 
            this.PassSetBtn.Location = new System.Drawing.Point(508, 19);
            this.PassSetBtn.Name = "PassSetBtn";
            this.PassSetBtn.Size = new System.Drawing.Size(75, 23);
            this.PassSetBtn.TabIndex = 67;
            this.PassSetBtn.Text = "Create pass";
            this.PassSetBtn.UseVisualStyleBackColor = true;
            this.PassSetBtn.Click += new System.EventHandler(this.PassSetBtn_Click);
            // 
            // IT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IT";
            this.Text = "IT";
            this.Load += new System.EventHandler(this.IT_Load);
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
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Panel topbar;
        internal System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton logoutTab;
        internal Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateBtnP;
        private System.Windows.Forms.TextBox paswrdSetTBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton PasswordTab;
        private System.Windows.Forms.Button Refreshbtn;
        public Bunifu.Framework.UI.BunifuFlatButton HomeTab12;
        private System.Windows.Forms.Button PassSetBtn;
    }
}