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
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = true;
            

            this.dataGrid.Visible = false;
            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = false;

            MarketingRepository mr = new MarketingRepository();
            InventoryRepository ir = new InventoryRepository();
            EmployeeRepository er = new EmployeeRepository();

            this.marketingAllowanceLabel.Text = "Pending Marketing Allowence : " + Convert.ToString(mr.countAllApprovedCampaignsAnd("Approved"));
            this.purchaseAllowanceLabel.Text = "Pending Product Purchase : " + Convert.ToString(ir.countAllInventoryAnd());
            this.salaryAllowanceLabel.Text = "Pending Salary Allowence : " + Convert.ToString(er.countAllEmployeeAnd());
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;

            this.dataGrid.Visible = true;
            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = false;

             FinanceRepository f = new FinanceRepository();
             List<EmployeeR> allResult = f.GetAllEmployee();

            this.dataGrid.DataSource = allResult;
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Show();
            this.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            AdminDashboard m = new AdminDashboard();
            m.Show();
            this.Hide();
        }

        private void cellCliked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox1.Text = row.Cells[0].Value.ToString();
                this.textBox2.Text = row.Cells[8].Value.ToString();
               
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show("Insert the data");

            }

            else {
                EmployeeR i = new EmployeeR();
                i.EmployeeId = this.textBox1.Text;
                i.Salary = Convert.ToInt32(this.textBox2.Text);


                FinanceRepository f = new FinanceRepository();
                if (f.Update(i))
                {
                    List<EmployeeR> iList = f.GetAllEmployee();
                    this.dataGrid.DataSource = iList;


                    List<EmployeeR> allResult = f.GetAllEmployee();

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";

                }
                else
                {
                    MessageBox.Show("Can Not Update Employee", "Update Error");
                }
            }
            
        }

        private void marketingAllowTab_Click(object sender, EventArgs e)
        {

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = true;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;

            this.dataGrid.Visible = false;
            this.dataGrid2.Visible = true;
            this.dataGrid3.Visible = false;

             MarketingRepository mr = new MarketingRepository();
             List<MarketingR> allResult = mr.GetAllApprovedCampaignAnd();

            this.dataGrid2.DataSource = allResult;
            
        }

        private void dataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox3.Text = row.Cells[0].Value.ToString();
                this.textBox4.Text = row.Cells[9].Value.ToString();

            }

        }

        private void UpdateMK_Click(object sender, EventArgs e)
        {

            if (this.textBox3.Text == "" || this.textBox4.Text == "")
            {
                MessageBox.Show("Insert data");

            }
            else
            {
                MarketingR i = new MarketingR();
                i.CampaignId =Convert.ToInt32( this.textBox3.Text );
                i.Budget = Convert.ToInt32(this.textBox4.Text);

                FinanceRepository fr = new FinanceRepository();
                
                if ( fr.UpdateBudget(i) )
                {
                    MarketingRepository mr = new MarketingRepository();
                    List<MarketingR> iList = mr.GetAllApprovedCampaignAnd();
                    this.dataGrid2.DataSource = iList;
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";

                }
                else
                {

                    MessageBox.Show("Insufficient Balance");
                   // MessageBox.Show("Can Not Update Campaign", "Update Error");
                }
            }

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = true;
            this.groupBox4.Visible = false;

            this.dataGrid.Visible =  false;
            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = true;

            FinanceRepository f = new FinanceRepository();
            List<InventoryR> allResult = f.GetAllProduct();

            this.dataGrid3.DataSource = allResult;

        }

        private void PurUpdateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid3.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox5.Text = row.Cells[0].Value.ToString();
                this.textBox6.Text = row.Cells[3].Value.ToString();

            }

        }

        private void DashBoardTab_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = true;

            this.dataGrid.Visible = false;
            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = false;

            MarketingRepository mr = new MarketingRepository();
            InventoryRepository ir = new InventoryRepository();
            EmployeeRepository er = new EmployeeRepository();

            this.marketingAllowanceLabel.Text = "Pending Marketing Allowence : " + Convert.ToString( mr.countAllApprovedCampaignsAnd("Approved") );
            this.purchaseAllowanceLabel.Text = "Pending Product Purchase : " + Convert.ToString( ir.countAllInventoryAnd() );
            this.salaryAllowanceLabel.Text = "Pending Salary Allowence : " + Convert.ToString( er.countAllEmployeeAnd() );
        }

        private void PurUpdateBtn_Click_1(object sender, EventArgs e)
        {
            if (this.textBox5.Text == "" || this.textBox6.Text == "")
            {
                MessageBox.Show("Insert data");

            }
            else
            {
                InventoryR i = new InventoryR();
                i.ProductId = this.textBox5.Text;
                i.Price = Convert.ToInt32(this.textBox6.Text);


                FinanceRepository f = new FinanceRepository();
                if (f.UpdatePrice(i))
                {
                    List<InventoryR> iList = f.GetAllProduct();
                    this.dataGrid3.DataSource = iList;

                    this.textBox5.Text = "";
                    this.textBox6.Text = "";

                }
                else
                {
                    MessageBox.Show("Can Not Update Price", "Update Error");
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = "";
            this.textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }
    }
}
