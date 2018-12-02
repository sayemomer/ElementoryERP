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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            //marketing Info
            MarketingRepository mr = new MarketingRepository();

          //  this.totalCampaigns.Text = "Total Campaigns : " + Convert.ToString(mr.countAllCampaigns());

           // this.appCampaign.Text = "Approved Campaigns : " + Convert.ToString(mr.countAllApprovedCampaigns("Approved"));



            //Hr Info


            EmployeeRepository m = new EmployeeRepository();


            /* 
             * EmployeeRepository m = new EmployeeRepository();
              this.label123.Text += Convert.ToString(m.countAllEmployee());
              this.label129.Text += Convert.ToString(m.countEmployee("Admin"));
              this.label125.Text += Convert.ToString(m.countEmployee("Sales"));
              this.label127.Text += Convert.ToString(m.countEmployee("Marketing"));
              this.label124.Text += Convert.ToString(m.countEmployee("Human Resource"));
              this.label126.Text += Convert.ToString(m.countEmployee("Accounting"));
              this.label128.Text += Convert.ToString(m.countEmployee("Finance"));

              this.label120.Text += Convert.ToString(m.countAllStatus("Full Time"));
              this.label119.Text += Convert.ToString(m.countAllStatus("Probationary"));
  this.label118.Text += Convert.ToString(m.countAllStatus("Intern"));
             * 
             * 
             * this.label120.Text += Convert.ToString(m.countAllStatus("Full Time"));
              this.label119.Text += Convert.ToString(m.countAllStatus("Probationary"));
              this.label118.Text += Convert.ToString(m.countAllStatus("Intern"));*/

            

            this.hrGraph.Series["emp"].Points.AddXY("Admin", m.countEmployee("Admin") );
            this.hrGraph.Series["emp"].Points.AddXY("Sales", m.countEmployee("Sales"));
            this.hrGraph.Series["emp"].Points.AddXY("HR", m.countEmployee("Human Resource"));
            this.hrGraph.Series["emp"].Points.AddXY("IT", m.countEmployee("IT"));
            this.hrGraph.Series["emp"].Points.AddXY("Accounts", m.countEmployee("Accounting"));
            this.hrGraph.Series["emp"].Points.AddXY("Finance", m.countEmployee("Finance")); 
            this.hrGraph.Series["emp"].Points.AddXY("Marketing", m.countEmployee("Marketing"));

            //sales Info


            
            //get all the data
            // count the total order in groupBox3

            OrderRepository or = new OrderRepository();

          /*  this.label117.Text = "Total Order : " + Convert.ToString(or.countAllOrder());
            this.label114.Text = "Bike : " + Convert.ToString(or.countOrder("Bike"));
            this.label108.Text = "Car : " + Convert.ToString(or.countOrder("Car"));
            this.label111.Text = "Cng : " + Convert.ToString(or.countOrder("Cng"));
            this.label112.Text = "Microbus : " + Convert.ToString(or.countOrder("Microbus"));
            this.label92.Text = "Pickup : " + Convert.ToString(or.countOrder("Pickup"));
            this.label90.Text = "Truck : " + Convert.ToString(or.countOrder("Truck")); */


           /* this.orderGraph.Series["Order"].Points.AddXY("Bike:" + Convert.ToString(or.countOrder("Bike")), or.countOrder("Bike"));
            this.orderGraph.Series["Order"].Points.AddXY("Car:" + Convert.ToString(or.countOrder("Car")), or.countOrder("Car") );
            this.orderGraph.Series["Order"].Points.AddXY("Cng:" + Convert.ToString(or.countOrder("Cng")), or.countOrder("Cng"));
            this.orderGraph.Series["Order"].Points.AddXY("Microbus:" + Convert.ToString(or.countOrder("Microbus")), or.countOrder("Microbus"));
            this.orderGraph.Series["Order"].Points.AddXY("Pickup:" + Convert.ToString(or.countOrder("Pickup")), or.countOrder("Pickup"));
            this.orderGraph.Series["Order"].Points.AddXY("Truck:"+ Convert.ToString(or.countOrder("Truck")), or.countOrder("Truck"));*/


            this.orderGraph.Series["Order"].Points.AddXY("Bike", or.countOrder("Bike"));
            this.orderGraph.Series["Order"].Points.AddXY("Car", or.countOrder("Car"));
            this.orderGraph.Series["Order"].Points.AddXY("Cng", or.countOrder("Cng"));
            this.orderGraph.Series["Order"].Points.AddXY("Microbus", or.countOrder("Microbus"));
            this.orderGraph.Series["Order"].Points.AddXY("Pickup", or.countOrder("Pickup"));
            this.orderGraph.Series["Order"].Points.AddXY("Truck", or.countOrder("Truck"));




            //count the total Inventory in groupBox4

            InventoryRepository ir = new InventoryRepository();

           /* this.label73.Text = "Total Inventory : " + Convert.ToString(ir.countAllInventory());
            this.label138.Text = "Bike :" + Convert.ToString(ir.countInventory("Bike"));
            this.label135.Text = "Car :" + Convert.ToString(ir.countInventory("Car"));
            this.label136.Text = "Cng :" + Convert.ToString(ir.countInventory("Cng"));
            this.label137.Text = "Microbus :" + Convert.ToString(ir.countInventory("Microbus"));
            this.label134.Text = "Pickup :" + Convert.ToString(ir.countInventory("Pickup"));
            this.label133.Text = "Truck :" + Convert.ToString(ir.countInventory("Truck")); */

            this.inventoryGraph.Series["Inventory"].Points.AddXY("Bike", ir.countInventory("Bike"));
            this.inventoryGraph.Series["Inventory"].Points.AddXY("Car",  ir.countInventory("Car"));
            this.inventoryGraph.Series["Inventory"].Points.AddXY("Cng",  ir.countInventory("Cng"));
            this.inventoryGraph.Series["Inventory"].Points.AddXY("Microbus", ir.countInventory("Microbus"));
            this.inventoryGraph.Series["Inventory"].Points.AddXY("Pickup", ir.countInventory("Pickup"));
            this.inventoryGraph.Series["Inventory"].Points.AddXY("Truck", ir.countInventory("Truck"));


            //count all shipment 

                 ShipmentRepository sr = new ShipmentRepository();
               /*  this.label52.Text = "Total Shipment : " + Convert.ToString(sr.countAllShipment());
                 this.label72.Text = "At Origin : " + Convert.ToString(sr.countShipment("At Origin"));
                 this.label66.Text = "On the Way : " + Convert.ToString(sr.countShipment("On the Way"));
                 this.label70.Text = "Stucked : " + Convert.ToString(sr.countShipment("Stuked"));
                 this.label71.Text = "At Destination : " + Convert.ToString(sr.countShipment("At Destination"));
                 this.label68.Text = "Shipped : " + Convert.ToString(sr.countShipment("Shipped")); */

                 this.shipmentGraph.Series["Shipment"].Points.AddXY("At Origin" , sr.countShipment("At Origin"));
                 this.shipmentGraph.Series["Shipment"].Points.AddXY("On the Way",sr.countShipment("On the Way"));
                 this.shipmentGraph.Series["Shipment"].Points.AddXY("Stucked",sr.countShipment("Stuked"));
                 this.shipmentGraph.Series["Shipment"].Points.AddXY("At Destination",sr.countShipment("At Destination"));
                 this.shipmentGraph.Series["Shipment"].Points.AddXY("Shipped", sr.countShipment("Shipped"));

            //accounting

                 AccountingRepository ar = new AccountingRepository();
               //  this.totalCashLabel.Text = "totalCash : " + Convert.ToString(ar.countTotalCash());

     


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void salesTab_Click(object sender, EventArgs e)
        {
            Sales m = new Sales();
            m.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            if (sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 200;
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

        private void Logout_click(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Show();
            this.Hide();
        }

        private void marketingTab_Click(object sender, EventArgs e)
        {
            Marketing m = new Marketing();
            m.Show();
            this.Hide();
        }

        private void dashbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dealsTab_Click_1(object sender, EventArgs e)
        {
            Deals m = new Deals();
            m.Show();
            this.Hide();
        }

        private void inventoryTab_Click(object sender, EventArgs e)
        {
            Inventory m = new Inventory();
            m.Show();
            this.Hide();
        }

        private void humanResourceTab_Click(object sender, EventArgs e)
        {
            HumanResource m = new HumanResource();
            m.Show();
            this.Hide();
        }

        private void accountingTab_Click(object sender, EventArgs e)
        {
            Accounting m = new Accounting();
            m.Show();
            this.Hide();
        }

        private void financeTab_Click(object sender, EventArgs e)
        {
            Finance m = new Finance();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void totalCarLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalMicroLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void totalBikeLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalAutoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ITtab_clicked(object sender, EventArgs e)
        {
            IT m = new IT();
            m.Show();
            this.Hide();
        }

        private void HomeTab_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hrGraphToggle_Click(object sender, EventArgs e)
        {

        }

        private void hrGraph_DoubleClick(object sender, EventArgs e)
        {
            
            this.hrGraph.Visible = false;

        }

        private void hrGraph2_DoubleClick(object sender, EventArgs e)
        {
            this.hrGraph.Visible = true;

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
