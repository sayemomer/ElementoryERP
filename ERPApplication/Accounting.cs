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
using System.Windows.Forms.DataVisualization.Charting;

namespace ERPApplication
{
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = true;

            this.dataGrid.Visible = false;
            this.dataGrid1.Visible = false;

            AccountingRepository ar = new AccountingRepository();
            this.totalCashLabel.Text = "totalCash : " + Convert.ToString(ar.countTotalCash());

            showChart();
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

        private void contactsTab_Click(object sender, EventArgs e)
        {

            this.dataGrid.Visible = true;
            this.dataGrid1.Visible = false;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;

            this.chart1.Visible = false;

            EmployeeRepository result = new EmployeeRepository();
            List<EmployeeR> allResult = result.GetEmployee("Accounting");
            this.dataGrid.DataSource = allResult;

        }

        private void cashInTab_Click(object sender, EventArgs e)
        {
            this.dataGrid.Visible = false;
            this.dataGrid1.Visible = true;

            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;

            this.chart1.Visible = false;


            AccountingRepository result = new AccountingRepository();
            List<AccountingR> allResult = result.GetAllTransiction();
            this.dataGrid1.DataSource = allResult;


        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.dateTimePicker1.Text == "")
            {
                MessageBox.Show("please insert Data");
            }
            else
            {
                AccountingRepository ar = new AccountingRepository();


                if (ar.GetCurrentAmmount() == 0)
                {
                    AccountingR i = new AccountingR();
                    i.Date = this.dateTimePicker1.Value.ToShortDateString();
                    i.Money = Convert.ToDouble(this.textBox1.Text);
                    i.CurrentAmmount = Convert.ToDouble(this.textBox1.Text);


                    if (ar.Insert(i))
                    {
                        List<AccountingR> allResult = ar.GetAllTransiction();
                        this.dataGrid1.DataSource = allResult;

                        this.textBox1.Text = "";
                        this.dateTimePicker1.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Can Not Insert Transition", "Insert Error");
                    }


                }
                else
                {
                    AccountingR i = new AccountingR();
                    i.Date = this.dateTimePicker1.Value.ToShortDateString();
                    i.Money = Convert.ToDouble(this.textBox1.Text);
                    i.CurrentAmmount = ar.GetCurrentAmmount() + Convert.ToDouble(this.textBox1.Text);


                    if (ar.Insert(i))
                    {
                        List<AccountingR> allResult = ar.GetAllTransiction();
                        this.dataGrid1.DataSource = allResult;

                        this.textBox1.Text = "";
                        this.dateTimePicker1.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Can Not Insert Transition", "Insert Error");
                    }
                }
               

                //
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.dateTimePicker1.Text == "")
            {
                MessageBox.Show("please insert Data");
            }

            else
            {
                AccountingR i = new AccountingR();
                i.Date = this.dateTimePicker1.Value.ToShortDateString();
                i.Money = Convert.ToDouble(this.textBox1.Text);


                AccountingRepository ar = new AccountingRepository();
                if (ar.Update(i))
                {
                    List<AccountingR> allResult = ar.GetAllTransiction();
                    this.dataGrid1.DataSource = allResult;

                    this.textBox1.Text = "";
                    this.dateTimePicker1.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Update Transition", "Update Error");
                }
            }
        }

        private void dataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox1.Text = row.Cells[1].Value.ToString();
                DateTime oDate = Convert.ToDateTime(row.Cells[0].Value );
                this.dateTimePicker1.Value = oDate;
               
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text == "" || this.dateTimePicker1.Text == "")
            {
                MessageBox.Show("please insert Data");
            }
            else
            {

                string date = this.dateTimePicker1.Value.ToShortDateString();

                AccountingRepository ar = new AccountingRepository();
                if (ar.Delete(date))
                {
                    List<AccountingR> allResult = ar.GetAllTransiction();
                    this.dataGrid1.DataSource = allResult;

                    this.textBox1.Text = "";
                    this.dateTimePicker1.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Delete transition", "Delete Error");
                }

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            string text = this.dateTimePicker2.Value.ToShortDateString();
            AccountingRepository ar = new AccountingRepository();
            List<AccountingR> iList = ar.searchTransiction(text);
            this.dataGrid1.DataSource = iList;
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            showChart();

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = true;
            this.chart1.Visible = true;

            this.dataGrid.Visible = false;
            this.dataGrid1.Visible = false;
            
            AccountingRepository ar = new AccountingRepository();
            this.totalCashLabel.Text = "totalCash : " + Convert.ToString(ar.countTotalCash());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Text = "";
            this.dateTimePicker2.Text = "";
            this.textBox1.Text = "";
        }

        public void showChart()
        {

            AccountingRepository ar = new AccountingRepository();
            List<AccountingR> allTransiction = ar.GetAllTransiction();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            foreach (AccountingR a in allTransiction) 
            {
                //this.chart1.Series.Add("taka");

                this.chart1.Series["Money"].Points.AddXY(a.Date, a.Money);
            }


        }
        
    }
}
