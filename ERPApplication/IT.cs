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
    public partial class IT : Form
    {
       
        public IT()
        {
            InitializeComponent();
            this.dataGrid.Visible = false;
            this.groupBox1.Visible = false;
        }

        private void PasswordTab_clicked(object sender, EventArgs e)
        {
            this.dataGrid.Visible = true;
            this.groupBox1.Visible = true;

            ItRepository p = new ItRepository();
            List<EmployeeR> allResult = p.GetAllEmployee();

            this.dataGrid.DataSource = allResult;
        }


        private void updateBtnP_clicked(object sender, EventArgs e)
        {
            
            if (this.textBox1.Text == "" || this.paswrdSetTBox.Text == "")
            {
                MessageBox.Show("Insert the data");

            }
           
            else
            {
                EmployeeR i = new EmployeeR();
                i.EmployeeId = this.textBox1.Text;
                i.EPassword = this.paswrdSetTBox.Text;

                ItRepository p = new ItRepository();
                if (p.Update(i))
                {
                    List<EmployeeR> iList = p.GetAllEmployee();
                    this.dataGrid.DataSource = iList;


                    List<EmployeeR> allResult = p.GetAllEmployee();

                    this.textBox1.Text = "";
                    this.paswrdSetTBox.Text = "";

                }
                else
                {
                    MessageBox.Show("Can Not Update Password", "Update Error");
                }
            }

        }

        private void PassSetBtn_clicked(object sender, EventArgs e)
        {
            
        }
       

        private void dataGridcell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox1.Text = row.Cells[0].Value.ToString();
                this.paswrdSetTBox.Text = row.Cells[9].Value.ToString();

            }
        }

        private void logoutTab_clicked(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Show();
            this.Hide();
        }

        private void HomeTab12_clicked(object sender, EventArgs e)
        {
            AdminDashboard m = new AdminDashboard();
            m.Show();
            this.Hide();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.textBox1.Text = row.Cells[0].Value.ToString();
                this.paswrdSetTBox.Text = row.Cells[9].Value.ToString();

            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
           
        }

        private void IT_Load(object sender, EventArgs e)
        {

        }

        private void PassSetBtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                Random r = new Random();
                int s;
                s = r.Next(10000000, 90000000);
                string x = Convert.ToString(s);
                EmployeeR i = new EmployeeR();



                ItRepository em = new ItRepository();
                if (em.countPass(x) == 1)
                {
                    MessageBox.Show("Can Not Update Employee", "Update Error");
                }
                else
                {
                    this.paswrdSetTBox.Text = x;
                }
            }

        }

       
    }
}
