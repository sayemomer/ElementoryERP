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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void LoginClicked(object sender, EventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            /*if (this.LoginPassword.Text != "" && this.LoginId.Text != "")
            {
                EmployeeR user = new EmployeeR();
                user.EmployeeId = LoginId.Text.Trim();
                user.EPassword = LoginPassword.Text;

                EmployeeRepository empRepo = new EmployeeRepository();

                if (empRepo.UserLoginValidation(user))
                {
                    if (LoginId.Text.Substring(0, 1) == "A" )
                    {
                        AdminDashboard admindash = new AdminDashboard();
                        admindash.Show();
                        this.Hide();
                    }
                    else if ( LoginId.Text.Substring(0, 1) == "M" )
                    {
                        Marketing m = new Marketing();
                        m.HomeTab.Hide();
                        m.Show();
                        this.Hide();
                    }
                    else if (LoginId.Text.Substring(0, 1) == "S")
                    {
                        Sales m = new Sales();
                        m.homeTab.Hide();
                        m.Show();
                        this.Hide();
                    }
                    else if (LoginId.Text.Substring(0, 1) == "H")
                    {
                        HumanResource m = new HumanResource();
                        m.Show();
                        m.homeTab.Hide();
                        this.Hide();
                    }
                    else if (LoginId.Text.Substring(0, 1) == "B")
                    {
                        Accounting m = new Accounting();
                        m.homeTab.Hide();
                        m.Show();
                        this.Hide();
                    }
                    else if (LoginId.Text.Substring(0, 1) == "F")
                    {
                        Finance m = new Finance();
                        m.homeTab.Hide();
                        m.Show();
                        this.Hide();
                    }
                    else if (LoginId.Text.Substring(0, 1) == "I")
                    {
                        IT m = new IT();
                        m.HomeTab12.Hide();
                        m.Show();
                       
                        this.Hide();
                    }
                    else
                    {

                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid Id or Password", "Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Insert ID or Password", "Login Failed");
            }*/


            AdminDashboard admindash = new AdminDashboard();
            admindash.Show();
            this.Hide();

           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void passwordpressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.' )
            {
                e.Handled = true;

            }
        }

        private void loginpressed(object sender, KeyPressEventArgs e)
        {
            
        }

        
    }
}
