namespace ERPApplication
{
    partial class Accounting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dashbar = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalCashLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.topbar = new System.Windows.Forms.Panel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.DashBoard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logoutTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contactsTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cashInTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeTab = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dashbar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dashbar
            // 
            this.dashbar.Controls.Add(this.chart1);
            this.dashbar.Controls.Add(this.groupBox2);
            this.dashbar.Controls.Add(this.groupBox1);
            this.dashbar.Controls.Add(this.dataGrid1);
            this.dashbar.Controls.Add(this.dataGrid);
            this.dashbar.Controls.Add(this.topbar);
            this.dashbar.Controls.Add(this.sideMenu);
            this.dashbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashbar.Location = new System.Drawing.Point(0, 0);
            this.dashbar.Name = "dashbar";
            this.dashbar.Size = new System.Drawing.Size(1068, 556);
            this.dashbar.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalCashLabel);
            this.groupBox2.Location = new System.Drawing.Point(338, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 180);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // totalCashLabel
            // 
            this.totalCashLabel.AutoSize = true;
            this.totalCashLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCashLabel.Location = new System.Drawing.Point(22, 58);
            this.totalCashLabel.Name = "totalCashLabel";
            this.totalCashLabel.Size = new System.Drawing.Size(126, 24);
            this.totalCashLabel.TabIndex = 0;
            this.totalCashLabel.Text = "totalCash : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefreshButton);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.insertBtn);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(263, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 104);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(566, 16);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 27;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(380, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Money";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(298, 19);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(136, 19);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 10;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(217, 19);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(485, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowUserToResizeColumns = false;
            this.dataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid1.ColumnHeadersHeight = 40;
            this.dataGrid1.EnableHeadersVisualStyles = false;
            this.dataGrid1.Location = new System.Drawing.Point(257, 69);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid1.Size = new System.Drawing.Size(808, 332);
            this.dataGrid1.TabIndex = 32;
            this.dataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid1_CellClick);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGrid.ColumnHeadersHeight = 40;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(257, 69);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.Size = new System.Drawing.Size(808, 332);
            this.dataGrid.TabIndex = 31;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1068, 63);
            this.topbar.TabIndex = 7;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.sideMenu.Controls.Add(this.DashBoard);
            this.sideMenu.Controls.Add(this.logo);
            this.sideMenu.Controls.Add(this.logoutTab);
            this.sideMenu.Controls.Add(this.contactsTab);
            this.sideMenu.Controls.Add(this.cashInTab);
            this.sideMenu.Controls.Add(this.homeTab);
            this.sideMenu.Controls.Add(this.menuButton);
            this.sideMenu.Location = new System.Drawing.Point(3, 61);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(253, 495);
            this.sideMenu.TabIndex = 6;
            // 
            // DashBoard
            // 
            this.DashBoard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.DashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.DashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashBoard.BorderRadius = 0;
            this.DashBoard.ButtonText = "DashBoard";
            this.DashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashBoard.DisabledColor = System.Drawing.Color.Gray;
            this.DashBoard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.Iconcolor = System.Drawing.Color.Transparent;
            this.DashBoard.Iconimage = ((System.Drawing.Image)(resources.GetObject("DashBoard.Iconimage")));
            this.DashBoard.Iconimage_right = null;
            this.DashBoard.Iconimage_right_Selected = null;
            this.DashBoard.Iconimage_Selected = null;
            this.DashBoard.IconMarginLeft = 0;
            this.DashBoard.IconMarginRight = 0;
            this.DashBoard.IconRightVisible = true;
            this.DashBoard.IconRightZoom = 0D;
            this.DashBoard.IconVisible = true;
            this.DashBoard.IconZoom = 90D;
            this.DashBoard.IsTab = false;
            this.DashBoard.Location = new System.Drawing.Point(0, 218);
            this.DashBoard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.DashBoard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.DashBoard.OnHoverTextColor = System.Drawing.Color.White;
            this.DashBoard.selected = false;
            this.DashBoard.Size = new System.Drawing.Size(252, 57);
            this.DashBoard.TabIndex = 8;
            this.DashBoard.Text = "DashBoard";
            this.DashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DashBoard.Textcolor = System.Drawing.Color.White;
            this.DashBoard.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.Click += new System.EventHandler(this.DashBoard_Click);
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
            this.logoutTab.Location = new System.Drawing.Point(0, 413);
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
            // contactsTab
            // 
            this.contactsTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.contactsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.contactsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contactsTab.BorderRadius = 0;
            this.contactsTab.ButtonText = "Contacts";
            this.contactsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactsTab.DisabledColor = System.Drawing.Color.Gray;
            this.contactsTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsTab.Iconcolor = System.Drawing.Color.Transparent;
            this.contactsTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("contactsTab.Iconimage")));
            this.contactsTab.Iconimage_right = null;
            this.contactsTab.Iconimage_right_Selected = null;
            this.contactsTab.Iconimage_Selected = null;
            this.contactsTab.IconMarginLeft = 0;
            this.contactsTab.IconMarginRight = 0;
            this.contactsTab.IconRightVisible = true;
            this.contactsTab.IconRightZoom = 0D;
            this.contactsTab.IconVisible = true;
            this.contactsTab.IconZoom = 90D;
            this.contactsTab.IsTab = false;
            this.contactsTab.Location = new System.Drawing.Point(1, 348);
            this.contactsTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contactsTab.Name = "contactsTab";
            this.contactsTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.contactsTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.contactsTab.OnHoverTextColor = System.Drawing.Color.White;
            this.contactsTab.selected = false;
            this.contactsTab.Size = new System.Drawing.Size(252, 57);
            this.contactsTab.TabIndex = 4;
            this.contactsTab.Text = "Contacts";
            this.contactsTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contactsTab.Textcolor = System.Drawing.Color.White;
            this.contactsTab.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsTab.Click += new System.EventHandler(this.contactsTab_Click);
            // 
            // cashInTab
            // 
            this.cashInTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.cashInTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.cashInTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cashInTab.BorderRadius = 0;
            this.cashInTab.ButtonText = "Cash In";
            this.cashInTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashInTab.DisabledColor = System.Drawing.Color.Gray;
            this.cashInTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInTab.Iconcolor = System.Drawing.Color.Transparent;
            this.cashInTab.Iconimage = ((System.Drawing.Image)(resources.GetObject("cashInTab.Iconimage")));
            this.cashInTab.Iconimage_right = null;
            this.cashInTab.Iconimage_right_Selected = null;
            this.cashInTab.Iconimage_Selected = null;
            this.cashInTab.IconMarginLeft = 0;
            this.cashInTab.IconMarginRight = 0;
            this.cashInTab.IconRightVisible = true;
            this.cashInTab.IconRightZoom = 0D;
            this.cashInTab.IconVisible = true;
            this.cashInTab.IconZoom = 90D;
            this.cashInTab.IsTab = false;
            this.cashInTab.Location = new System.Drawing.Point(0, 283);
            this.cashInTab.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cashInTab.Name = "cashInTab";
            this.cashInTab.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.cashInTab.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(54)))), ((int)(((byte)(55)))));
            this.cashInTab.OnHoverTextColor = System.Drawing.Color.White;
            this.cashInTab.selected = false;
            this.cashInTab.Size = new System.Drawing.Size(252, 57);
            this.cashInTab.TabIndex = 2;
            this.cashInTab.Text = "Cash In";
            this.cashInTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cashInTab.Textcolor = System.Drawing.Color.White;
            this.cashInTab.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashInTab.Click += new System.EventHandler(this.cashInTab_Click);
            // 
            // homeTab
            // 
            this.homeTab.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.homeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(160)))), ((int)(((byte)(141)))));
            this.homeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeTab.BorderRadius = 0;
            this.homeTab.ButtonText = "Home";
            this.homeTab.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.homeTab.Location = new System.Drawing.Point(0, 153);
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
            this.homeTab.Click += new System.EventHandler(this.homeTab_Click);
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topbar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(628, 88);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Money";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(354, 300);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 556);
            this.Controls.Add(this.dashbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.dashbar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.Panel dashbar;
        public System.Windows.Forms.Panel topbar;
        internal System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton logoutTab;
        private Bunifu.Framework.UI.BunifuFlatButton contactsTab;
        private Bunifu.Framework.UI.BunifuFlatButton cashInTab;
        internal Bunifu.Framework.UI.BunifuImageButton menuButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Bunifu.Framework.UI.BunifuFlatButton DashBoard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label totalCashLabel;
        private System.Windows.Forms.Button RefreshButton;
        public Bunifu.Framework.UI.BunifuFlatButton homeTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}