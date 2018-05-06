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
    public partial class HumanResource : Form
    {
        public HumanResource()
        {
            InitializeComponent();
            
            this.dataGrid.Visible = false;
            this.groupBox1.Visible = false;
            getAllInfo();

        }


        public void getAllInfo()
        {

            EmployeeRepository m = new EmployeeRepository();
            this.totalEmployee.Text += Convert.ToString(m.countAllEmployee());
            this.totalAdminLabel.Text += Convert.ToString(m.countEmployee("Admin"));
            this.totalSaleLabel.Text += Convert.ToString(m.countEmployee("Sales"));
            this.totalMarketingLabel.Text += Convert.ToString(m.countEmployee("Marketing"));
            this.totalHrLabel.Text += Convert.ToString(m.countEmployee("Human Resource"));
            this.totalAccountingLabel.Text += Convert.ToString(m.countEmployee("Accounting"));
            this.totalFinanceLabel.Text += Convert.ToString(m.countEmployee("Finance"));

            this.fullTime.Text += Convert.ToString(m.countAllStatus("Full Time"));
            this.Probation.Text += Convert.ToString(m.countAllStatus("Probationary"));
            this.Intern.Text += Convert.ToString(m.countAllStatus("Intern"));

        }

        private void homeTab_Click(object sender, EventArgs e)
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


        private void employeeRecruitementTab_Click(object sender, EventArgs e)
        {
            EmployeeRepository em = new EmployeeRepository();
            List<EmployeeR> allEmployee = em.GetAllEmployee();
            this.dataGrid.DataSource = allEmployee;

            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.dataGrid.Visible = true;
            this.groupBox1.Visible = true;

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
                this.comboBox2.Text = row.Cells[3].Value.ToString();
                this.textBox5.Text = row.Cells[4].Value.ToString();
                this.textBox6.Text = row.Cells[5].Value.ToString();
                this.textBox7.Text = row.Cells[6].Value.ToString();

                this.comboBox1.Text = row.Cells[7].Value.ToString();
            }
        }

        private void insertBtn_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox5.Text == "" || this.textBox6.Text == "" || this.textBox7.Text == "" || this.comboBox1.Text == "" || this.comboBox2.Text == "")
            {
                MessageBox.Show(" Insert the data");
            }
            else {

                EmployeeR i = new EmployeeR();
                i.EmployeeId = this.textBox1.Text;
                i.EmployeeName = this.textBox2.Text;
                i.EGender = this.textBox3.Text;
                i.EDepartmentName = Convert.ToString(this.comboBox2.SelectedItem);
                i.EPhone = this.textBox5.Text;
                i.EmployeeEmail = this.textBox6.Text;
                i.EReportsTo = this.textBox7.Text;
                i.EStatus = Convert.ToString(this.comboBox1.SelectedItem);

                EmployeeRepository emp = new EmployeeRepository();
                if (emp.Insert(i))
                {
                    List<EmployeeR> iList = emp.GetAllEmployee();
                    this.dataGrid.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.comboBox2.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Insert Employee", "Insert Error");
                }
            }

            
        }

        private void logoutTab_Click_1(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Show();
            this.Hide();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox5.Text == "" || this.textBox6.Text == "" || this.textBox7.Text == "" || this.comboBox1.Text == "" || this.comboBox2.Text == "")
            {
                MessageBox.Show(" Insert the data");
            }
            else {

                EmployeeR i = new EmployeeR();
                i.EmployeeId = this.textBox1.Text;
                i.EmployeeName = this.textBox2.Text;
                i.EGender = this.textBox3.Text;
                i.EDepartmentName = Convert.ToString(this.comboBox2.SelectedItem);
                i.EPhone = this.textBox5.Text;
                i.EmployeeEmail = this.textBox6.Text;
                i.EReportsTo = this.textBox7.Text;
                i.EStatus = Convert.ToString(this.comboBox1.SelectedItem);

                EmployeeRepository emp = new EmployeeRepository();
                if (emp.Update(i))
                {
                    List<EmployeeR> iList = emp.GetAllEmployee();
                    this.dataGrid.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.comboBox2.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Update Employee", "Update Error");
                }
            }
            
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "" || this.textBox5.Text == "" || this.textBox6.Text == "" || this.textBox7.Text == "" || this.comboBox1.Text == "" || this.comboBox2.Text == "")
            {
                MessageBox.Show(" Insert the data");
            }
            else {

                string employeeId = this.textBox1.Text;
                EmployeeRepository emp = new EmployeeRepository();
                if (emp.Delete(employeeId))
                {
                    List<EmployeeR> iList = emp.GetAllEmployee();
                    this.dataGrid.DataSource = iList;

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.comboBox2.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Delete Employee", "Delete Error");
                }
            }
            
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            string text = this.searchTBox.Text;
            EmployeeRepository emp = new EmployeeRepository();
            List<EmployeeR> iList = emp.searchEmployee(text);
            this.dataGrid.DataSource = iList;
        }

        private void dashTab_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = true;
            this.groupBox3.Visible = true;
            this.dataGrid.Visible = false;
            this.groupBox1.Visible = false;

        }

        private void totalMarketingLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalFinanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalAccountingLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalHrLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalEmployee_Click(object sender, EventArgs e)
        {

        }

        private void totalAdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalSaleLabel_Click(object sender, EventArgs e)
        {

        }

        private void fullTime_Click(object sender, EventArgs e)
        {

        }

        private void Probation_Click(object sender, EventArgs e)
        {

        }

        private void Intern_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
           



        }

    }
}
