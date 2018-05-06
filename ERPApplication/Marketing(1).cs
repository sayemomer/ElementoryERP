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
    public partial class Marketing : Form
    {
        public Marketing()
        {
            InitializeComponent();

            this.dataGrid1.Visible = false;
            this.dataGrid.Visible = false;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
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

        private void contactsTab_Click(object sender, EventArgs e)
        {
            this.dataGrid1.Visible = false;
            this.dataGrid.Visible = true;
            this.dataGrid2.Visible = false;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;

            EmployeeRepository result = new EmployeeRepository();
            List<EmployeeR> allResult = result.GetEmployee("Marketing");
            this.dataGrid.DataSource = allResult;
            
        }

        private void campaignsTab_Click(object sender, EventArgs e)
        {

            this.dataGrid.Visible = false;
            this.dataGrid1.Visible = true;
            this.dataGrid2.Visible = false;

            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;

            MarketingRepository mr = new MarketingRepository();
            List<MarketingR> allCampaign = mr.GetAllCampaign();
            this.dataGrid1.DataSource = allCampaign;

            dataGrid1.Columns[7].Visible = false;
            dataGrid1.Columns[8].Visible = false;
            dataGrid1.Columns[9].Visible = false;
            
        }

        private void dataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox1.Text = row.Cells[0].Value.ToString();
                this.textBox2.Text = row.Cells[1].Value.ToString();
                this.textBox3.Text = row.Cells[2].Value.ToString();
                this.textBox4.Text = row.Cells[3].Value.ToString();
                this.textBox5.Text = row.Cells[4].Value.ToString();
                this.comboBox1.Text = row.Cells[10].Value.ToString();
                this.dateTimePicker1.Text = row.Cells[5].Value.ToString();
                this.dateTimePicker2.Text = row.Cells[6].Value.ToString();
               
            }

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == "" || this.textBox5.Text == "")
            {
                MessageBox.Show("Insert the data");

            }

            else {
                //(ProductName,ProductId,Volume,Price,Store,Category,Tax)
                MarketingR i = new MarketingR();
                i.CampaignId = (this.textBox1.Text).ToUpper().Trim();
                i.CampaignName = this.textBox2.Text;
                i.Objective = this.textBox3.Text;
                i.Placement = this.textBox4.Text;
                i.EmployeeName = this.textBox5.Text;
                i.LaunchDate = this.dateTimePicker1.Value.ToLongDateString();
                i.EndDate = this.dateTimePicker2.Value.ToShortDateString();
                i.RunningCost = 0;
                i.Report = "";
                i.Budget = 0;
                i.Status = "Not Approved";

                MarketingRepository mr = new MarketingRepository();
                if (mr.Insert(i))
                {
                    List<MarketingR> iList = mr.GetAllCampaign();
                    this.dataGrid1.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    this.dateTimePicker1.Text = "";
                    this.dateTimePicker2.Text = "";

                }
                else
                {
                    MessageBox.Show("Can Not Insert Campaign", "Insert Error");
                }
 
            
            }
           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == "" || this.textBox5.Text == "")
            {
                MessageBox.Show("Insert the data");

            }

            else {

                MarketingR i = new MarketingR();
                i.CampaignId = (this.textBox1.Text).ToUpper().Trim();
                i.CampaignName = this.textBox2.Text;
                i.Objective = this.textBox3.Text;
                i.Placement = this.textBox4.Text;
                i.EmployeeName = this.textBox5.Text;
                i.LaunchDate = this.dateTimePicker1.Value.ToLongDateString();
                i.EndDate = this.dateTimePicker2.Value.ToShortDateString();
                i.RunningCost = 0;
                i.Report = "";
                i.Budget = 0;
                i.Status = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

                MarketingRepository mr = new MarketingRepository();
                if (mr.Update(i))
                {
                    List<MarketingR> iList = mr.GetAllCampaign();
                    this.dataGrid1.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    this.comboBox1.Text = "";
                    this.dateTimePicker1.Text = "";
                    this.dateTimePicker2.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Update Campaign", "Update Error");
                }
            }


           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox4.Text == "" || this.textBox5.Text == "")
            {
                MessageBox.Show("Insert the data");

            }
            else {

                string campaignId = this.textBox1.Text;

                MarketingRepository mr = new MarketingRepository();

                if (mr.Delete(campaignId))
                {
                    List<MarketingR> iList = mr.GetAllCampaign();
                    this.dataGrid1.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    this.dateTimePicker1.Text = "";
                    this.dateTimePicker2.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Delete Campaign", "Delete Error");
                }

            }
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string text = this.searchTBox.Text;
            MarketingRepository mr = new MarketingRepository();
            List<MarketingR> iList = mr.searchCampaign(text);
            this.dataGrid1.DataSource = iList;
        }

        private void approvedTab_Click(object sender, EventArgs e)
        {
            this.dataGrid.Visible = false;
            this.dataGrid1.Visible = false;
            this.dataGrid2.Visible = true;

            this.groupBox1.Visible = true;
            this.groupBox2.Visible = true;
            this.groupBox3.Visible = false;

            MarketingRepository mr = new MarketingRepository();
            List<MarketingR> allCampaign = mr.GetAllApprovedCampaign();
            this.dataGrid2.DataSource = allCampaign;
        }

        private void dataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox7.Text = row.Cells[0].Value.ToString();
                this.textBox9.Text = row.Cells[7].Value.ToString();
                this.textBox10.Text = row.Cells[8].Value.ToString();
      
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox7.Text == "" || this.textBox9.Text == "" || this.textBox10.Text == "")
            {
                MessageBox.Show("Insert the data");

            }

            else
            {
                string id = this.textBox7.Text;
                double runningCost = Convert.ToDouble(this.textBox9.Text);
                string report = this.textBox10.Text;

                MarketingRepository mr = new MarketingRepository();
                if (mr.UpdateCost(id, runningCost, report))
                {
                    List<MarketingR> iList = mr.GetAllApprovedCampaign();
                    this.dataGrid2.DataSource = iList;

                    this.textBox7.Text = "";
                    this.textBox9.Text = "";
                    this.textBox10.Text = "";
                   
                   
                }
                else
                {
                    MessageBox.Show("Can Not Update Campaign", "Update Error");
                }

 
            
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dashBoardTab_Click(object sender, EventArgs e)
        {

            this.dataGrid1.Visible = false;
            this.dataGrid.Visible = false;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = true;

            MarketingRepository mr = new MarketingRepository();

            this.totalCampaigns.Text = "Total Campaigns : " + Convert.ToString(mr.countAllCampaigns());

            this.appCampaign.Text = "Approved Campaigns : " + Convert.ToString(mr.countAllApprovedCampaigns("Approved"));
            
        }
    }
}
