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
    public partial class Deals : Form
    {
        public Deals()
        {
            InitializeComponent();
             DealsRepository deals = new DealsRepository();
             List<DealsR> dList = deals.GetAllDealerCompany();
             this.dataGrid.DataSource = dList;
        }

        private void homeTab_click(object sender, EventArgs e)
        {
            AdminDashboard m = new AdminDashboard();
            m.Show();
            this.Hide();
        }

        private void logoutTab(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Show();
            this.Hide();
        }

        private void companyTab_Click(object sender, EventArgs e)
        {

        }

        private void logout_clicked(object sender, EventArgs e)
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

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
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
                this.textBox4.Text = row.Cells[3].Value.ToString();
                this.textBox5.Text = row.Cells[4].Value.ToString();
                this.textBox6.Text = row.Cells[5].Value.ToString();
                this.textBox7.Text = row.Cells[6].Value.ToString();

               
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = ""; 
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";

        }

        private void dashbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
