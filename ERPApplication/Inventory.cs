using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERPRepository;

namespace ERPApplication
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            InventoryRepository inventory = new InventoryRepository();
            List<InventoryR> allProduct = inventory.GetAllProduct();
            this.dataGrid.DataSource = allProduct;
            

        }

        private void HomeTab_Click(object sender, EventArgs e)
        {
            AdminDashboard m = new AdminDashboard();
            m.Show();
            this.Hide();
        }

        private void logoutTab_Click(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Show();
            this.Hide();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 260;
                panelTransition.ShowSync(sideMenu);
                logoTransition.ShowSync(logo);

            }
            else
            {
                logoTransition.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 50;
                panelTransition.ShowSync(sideMenu);

            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

            //
            if (this.textBox1.Text == "" || this.textBox2.Text == ""||this.textBox3.Text == ""||this.textBox5.Text == "" || this.comboBox1.Text == "" ||this.textBox7.Text == "" )
            {
                MessageBox.Show("please insert Data");
            }
            else
            {
                //(ProductName,ProductId,Volume,Price,Store,Category,Tax)
                InventoryR i = new InventoryR();
                i.ProductId = (this.textBox1.Text).ToUpper().Trim();
                i.ProductName = this.textBox2.Text;
                i.Volume = Convert.ToInt32(this.textBox3.Text);
                i.Price = 0;
                i.Store = this.textBox5.Text;
                i.Category = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                i.Tax = Convert.ToInt32(this.textBox7.Text);

                InventoryRepository invetoryRepo = new InventoryRepository();
                if (invetoryRepo.Insert(i))
                {
                    List<InventoryR> iList = invetoryRepo.GetAllProduct();
                    this.dataGrid.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    
                    this.textBox5.Text = "";
                    this.comboBox1.Text = "";
                    this.textBox7.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Insert Product", "Insert Error");
                }

                //
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox5.Text == "" || this.comboBox1.Text == "" || this.textBox7.Text == "")
            {
                MessageBox.Show("Insert the data");
            }

            else
            {
                InventoryR i = new InventoryR();
                i.ProductId = this.textBox1.Text;
                i.ProductName = this.textBox2.Text;
                i.Volume = Convert.ToInt32(this.textBox3.Text);
                i.Store = this.textBox5.Text;
                i.Category = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                i.Tax = Convert.ToInt32(this.textBox7.Text);

                InventoryRepository invetoryRepo = new InventoryRepository();
                if (invetoryRepo.Update(i))
                {
                    List<InventoryR> iList = invetoryRepo.GetAllProduct();
                    this.dataGrid.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox5.Text = "";
                    this.comboBox1.Text = "";
                    this.textBox7.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Update Product", "Update Error");
                }
 
            
            }

          

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == ""  || this.textBox5.Text == "" || this.comboBox1.Text == "" || this.textBox7.Text == "")
            {
                MessageBox.Show("Select the id which u want to delete ");
            }

            else {

                string ProductId = this.textBox1.Text;

                InventoryRepository invetoryRepo = new InventoryRepository();
                if (invetoryRepo.Delete(ProductId))
                {
                    List<InventoryR> iList = invetoryRepo.GetAllProduct();
                    this.dataGrid.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox5.Text = "";
                    this.comboBox1.Text = "";
                    this.textBox7.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Delete Product", "Delete Error");
                }

            }

            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string text = this.searchTBox.Text;
            InventoryRepository invetoryRepo = new InventoryRepository();
            List<InventoryR> iList = invetoryRepo.searchInventory(text);
            this.dataGrid.DataSource = iList;

        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox1.Text = row.Cells[0].Value.ToString();
                this.textBox2.Text = row.Cells[1].Value.ToString();
                this.textBox3.Text = row.Cells[2].Value.ToString();
                this.textBox5.Text = row.Cells[4].Value.ToString();
                this.comboBox1.Text = row.Cells[5].Value.ToString();
                this.textBox7.Text = row.Cells[6].Value.ToString();
            }

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox5.Text = "";
            
            this.textBox7.Text = "";
           
        }

    }
}
