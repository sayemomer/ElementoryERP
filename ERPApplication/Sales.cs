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
using System.Data.SqlClient;

namespace ERPApplication
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
             


            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = false;
            this.dataGrid4.Visible = false;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;

            //dashBoard text
            this.groupBox3.Visible = true;
            this.groupBox4.Visible = true;
            this.groupBox5.Visible = true;

            // init the ID from inventory table in this combobox
            InventoryRepository m = new InventoryRepository();
            List<string> allId = m.GetAllId();

            foreach (string id in allId)
            {
                this.comboBox1.Items.Add(id);
            }


            OrderRepository or = new OrderRepository();

            this.totalOrderLabel.Text = "Total Order : " + Convert.ToString(or.countAllOrder());
            this.totalBikeLabel.Text = "Bike : " + Convert.ToString(or.countOrder("Bike"));
            this.totalCarLabel.Text = "Car : " + Convert.ToString(or.countOrder("Car"));
            this.totalAutoLabel.Text = "Cng : " + Convert.ToString(or.countOrder("Cng"));
            this.totalMicroLabel.Text = "Microbus : " + Convert.ToString(or.countOrder("Microbus"));
            this.totalPickupLabel.Text = "Pickup : " + Convert.ToString(or.countOrder("Pickup"));
            this.totalTruckLabel.Text = "Truck : " + Convert.ToString(or.countOrder("Truck"));


            //count the total Inventory in groupBox4

            InventoryRepository ir = new InventoryRepository();

            this.totalInventoryLabel.Text = "Total Inventory : " + Convert.ToString(ir.countAllInventory());
            this.totalBikeILabel.Text = "Bike :" + Convert.ToString(ir.countInventory("Bike"));
            this.totalCarILabel.Text = "Car :" + Convert.ToString(ir.countInventory("Car"));
            this.totalAutoILabel.Text = "Cng :" + Convert.ToString(ir.countInventory("Cng"));
            this.totalMicroILabel.Text = "Microbus :" + Convert.ToString(ir.countInventory("Microbus"));
            this.totalPickupILabel.Text = "Pickup :" + Convert.ToString(ir.countInventory("Pickup"));
            this.totalTruckILabel.Text = "Truck :" + Convert.ToString(ir.countInventory("Truck"));


            //count all shipment 

            ShipmentRepository sr = new ShipmentRepository();
            this.totalShipmentLabel.Text = "Total Shipment : " + Convert.ToString(sr.countAllShipment());
            this.atOriginLabel.Text = "At Origin : " + Convert.ToString(sr.countShipment("At Origin"));
            this.onTheWayLabel.Text = "On the Way : " + Convert.ToString(sr.countShipment("On the Way"));
            this.stuckedLabel.Text = "Stucked : " + Convert.ToString(sr.countShipment("Stuked"));
            this.atDestinationLabel.Text = "At Destination : " + Convert.ToString(sr.countShipment("At Destination"));
            this.shippedLabel.Text = "Shipped : " + Convert.ToString(sr.countShipment("Shipped"));

            
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

        private void homeTab_Click(object sender, EventArgs e)
        {
            AdminDashboard m = new AdminDashboard();
            m.Show();
            this.Hide();
        }

        private void orderTab_Click(object sender, EventArgs e)
        {

            this.dataGrid2.Visible = true;
            this.dataGrid3.Visible = false;
            this.dataGrid4.Visible = false;

            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;


            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = false;


            OrderRepository order = new OrderRepository();
            List<OrderR> allProduct = order.GetAllOrder();
            this.dataGrid2.DataSource = allProduct;

            dataGrid2.Columns[7].Visible = false;
        }

        private void shipmentTab_Click(object sender, EventArgs e)
        {
            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = true; 
            this.dataGrid4.Visible = false;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = true;

            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = false;


            ShipmentRepository shipment = new ShipmentRepository();
            List<ShipmentR> allShipment = shipment.GetAllShipment();
            this.dataGrid3.DataSource = allShipment;

        }


        private void insrtbtn_Click(object sender, EventArgs e)
        {
            if (this.orderIdTxt.Text == "" || this.productIdTxt.Text == "" || this.productNameTxt.Text == "" || this.quantityTxt.Text == "" || this.addressTxt.Text == "" || this.employeeNameTxt.Text == "" || this.comboBox1.Text == "" || this.comboBox3.Text == "")
            {
                MessageBox.Show("Insert data");
            }

            else {


                OrderR i = new OrderR();
                OrderRepository orderRepo = new OrderRepository();
                InventoryRepository ir = new InventoryRepository();
                i.OrderId = (this.orderIdTxt.Text).ToUpper().Trim();
                i.ProductId = (this.productIdTxt.Text).ToUpper().Trim();
                i.ProductName = this.productNameTxt.Text;
                i.Quantity = Convert.ToInt32(this.quantityTxt.Text);
                i.Address = this.addressTxt.Text;
                i.EmployeeName = this.employeeNameTxt.Text;
                i.Catagory = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);
                i.Status = "Order";


                if (orderRepo.Insert(i))
                {
                    List<OrderR> iList = orderRepo.GetAllOrder();
                    this.dataGrid2.DataSource = iList;
                    this.orderIdTxt.Text = "";
                    this.productIdTxt.Text = "";
                    this.productNameTxt.Text = "";
                    this.quantityTxt.Text = "";
                    this.addressTxt.Text = "";
                    this.employeeNameTxt.Text = "";
                    this.comboBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Insert Order", "Insert Error");
                }
            }

        }

        private void DataGridClicked(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (this.orderIdTxt.Text == "" || this.productIdTxt.Text == "" || this.productNameTxt.Text == "" || this.quantityTxt.Text == "" || this.addressTxt.Text == "" || this.employeeNameTxt.Text == "" || this.comboBox1.Text == "" || this.comboBox3.Text == "")
            {
                MessageBox.Show("Insert the data");
            }

            else {

                OrderR i = new OrderR();
                i.OrderId = this.orderIdTxt.Text;
                i.ProductId = this.productIdTxt.Text;
                i.ProductName = this.productNameTxt.Text;
                i.Quantity = Convert.ToInt32(this.quantityTxt.Text);
                i.Address = this.addressTxt.Text;
                i.EmployeeName = this.employeeNameTxt.Text;

                OrderRepository orderRepo = new OrderRepository();
                if (orderRepo.Update(i))
                {
                    List<OrderR> iList = orderRepo.GetAllOrder();
                    this.dataGrid2.DataSource = iList;

                    this.orderIdTxt.Text = "";
                    this.productIdTxt.Text = "";
                    this.productNameTxt.Text = "";
                    this.quantityTxt.Text = "";
                    this.addressTxt.Text = "";
                    this.employeeNameTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Update Order", "Opdate Error");
                }
            }
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (this.orderIdTxt.Text == "" || this.productIdTxt.Text == "" || this.productNameTxt.Text == "" || this.quantityTxt.Text == "" || this.addressTxt.Text == "" || this.employeeNameTxt.Text == "" || this.comboBox1.Text == "" || this.comboBox3.Text == "")
            {
                MessageBox.Show("Insert the data");
            }

            else {

                string OrderId = this.orderIdTxt.Text;

                OrderRepository orderRepo = new OrderRepository();
                if (orderRepo.Delete(OrderId))
                {
                    List<OrderR> iList = orderRepo.GetAllOrder();
                    this.dataGrid2.DataSource = iList;

                    this.orderIdTxt.Text = "";
                    this.productIdTxt.Text = "";
                    this.productNameTxt.Text = "";
                    this.quantityTxt.Text = "";
                    this.addressTxt.Text = "";
                    this.employeeNameTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Can Not Delete Order", "Delete Error");
                }
            }
           
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string text = this.searchTBox.Text;
            OrderRepository orderRepo = new OrderRepository();
            List<OrderR> iList = orderRepo.searchOrder(text);
            this.dataGrid2.DataSource = iList;
        }

        private void ShipOrderbtn_Click(object sender, EventArgs e)
        {
            ShipmentR i = new ShipmentR();
            i.OrderId = this.orderIdTxt.Text;
            i.ShipmentProgress = 0;
            i.Status ="";
            ShipmentRepository  shipRepo = new ShipmentRepository();

            //insert into shipment table if the product is sufficient in inventory 
            if ( Convert.ToInt32(this.quantityTxt.Text) <= Convert.ToInt32(this.textBox7.Text) )
            {
                if (shipRepo.Insert(i))
                {

                    //---------------update the volume in inventory after successful shipment-----------------//

                    int latestVolume = Convert.ToInt32(this.textBox7.Text) - Convert.ToInt32(this.quantityTxt.Text);
                    InventoryRepository ir = new InventoryRepository();
                    if (ir.updateInventory(this.productIdTxt.Text, latestVolume))
                    {
                        MessageBox.Show("One Row Updated in Inventory");
                    }
                    else
                    {
                        MessageBox.Show("Can't update inventory", "Update Error");
                    }

                    //---------------Update and hide From Order Tabel after Shipment-----------------//
                    OrderRepository or = new OrderRepository();
                   
                    if (or.updateStatus(this.orderIdTxt.Text) )
                    {
                        MessageBox.Show("Order Updated");
                    }
                    else
                    {
                        MessageBox.Show("unSuccessfull order update","Update Error");
                    }

                    MessageBox.Show("Succsfull ", "Shipment");

                    //---------------refresh the order Grid-----------------//

                    List<OrderR> order = new List<OrderR>();
                    order =  or.GetAllOrder();
                    this.dataGrid2.DataSource = order;

                    this.orderIdTxt.Text = "";
                    this.productIdTxt.Text = "";
                    this.productNameTxt.Text = "";
                    this.quantityTxt.Text = "";
                    this.addressTxt.Text = "";
                    this.employeeNameTxt.Text = "";
   
                }
                else
                {
                    MessageBox.Show("Can Not Ship Order", "Ship Error");
                }

            }
            else
            {
                MessageBox.Show("Unsufficient amount of Product", "Available Error");
            }
           
        }


        private void contactsTab_Click(object sender, EventArgs e)
        {
            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = false;
            this.dataGrid4.Visible = true;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;

            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = false;

            EmployeeRepository result = new EmployeeRepository();
            List<EmployeeR> allResult = result.GetEmployee("Sales");
            this.dataGrid4.DataSource = allResult;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryRepository m = new InventoryRepository();

            this.productIdTxt.Text = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            this.productNameTxt.Text = m.GetProductName(this.comboBox1.GetItemText(this.comboBox1.SelectedItem));
            this.comboBox3.Text = m.GetProductCatagory(this.comboBox1.GetItemText(this.comboBox1.SelectedItem));
        }

        private void dataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.orderIdTxt.Text = row.Cells[0].Value.ToString();
                this.productIdTxt.Text = row.Cells[1].Value.ToString();
                this.productNameTxt.Text = row.Cells[2].Value.ToString();
                this.quantityTxt.Text = row.Cells[3].Value.ToString();
                this.addressTxt.Text = row.Cells[4].Value.ToString();
                this.employeeNameTxt.Text = row.Cells[5].Value.ToString();
                this.textBox7.Text = row.Cells[6].Value.ToString();
            }

        }

        private void dataGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGrid3.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.shpIdTxt.Text = row.Cells[0].Value.ToString();
                this.shpProTxt.Text = row.Cells[1].Value.ToString();
                this.comboBox2.Text= row.Cells[2].Value.ToString();
                
            }

        }

        private void shpUpdate_Click(object sender, EventArgs e)
        {

            if (this.shpIdTxt.Text == "" || this.shpProTxt.Text == "" || this.comboBox2.Text == "")
            {
                MessageBox.Show("Insert the data");
            }
            else {

                ShipmentR i = new ShipmentR();

                i.ShipmentId = Convert.ToInt32(this.shpIdTxt.Text);
                i.ShipmentProgress = Convert.ToInt32(this.shpProTxt.Text);
                i.Status = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);

                ShipmentRepository sr = new ShipmentRepository();
                if (sr.Update(i))
                {
                    List<ShipmentR> iList = sr.GetAllShipment();
                    this.dataGrid3.DataSource = iList;

                    this.shpIdTxt.Text = "";
                    this.shpProTxt.Text = "";
                    this.comboBox2.Text = "";

                }
                else
                {
                    MessageBox.Show("Can Not Update Shipment", "Update Error");
                }

            }
           
        }

        private void shpSearch_Click(object sender, EventArgs e)
        {

            string text = this.shpSearchbox.Text;
            ShipmentRepository  sr = new ShipmentRepository();
            List<ShipmentR> iList = sr.searchShipment(text);
            this.dataGrid3.DataSource = iList;

        }

        private void shpDelete_Click(object sender, EventArgs e)
        {
            if (this.shpIdTxt.Text == "" || this.shpProTxt.Text == "" || this.comboBox2.Text == "")
            {
                MessageBox.Show("Insert the data");
            }

            else {

                int shipId = Convert.ToInt32(this.shpIdTxt.Text);

                ShipmentRepository sr = new ShipmentRepository();
                if (sr.Delete(shipId))
                {
                    List<ShipmentR> iList = sr.GetAllShipment();
                    this.dataGrid3.DataSource = iList;

                    this.shpIdTxt.Text = "";
                    this.shpProTxt.Text = "";
                    this.comboBox2.Text = "";

                }
                else
                {
                    MessageBox.Show("Can Not Delete Shipment", "Delete Error");
                }

            }
           
        }

        private void dashBoardClicked(object sender, EventArgs e)
        {
            this.groupBox3.Visible = true;
            this.groupBox4.Visible = true;
            this.groupBox5.Visible = true;

            //get all the data
            // count the total order in groupBox3

            OrderRepository or = new OrderRepository();

            this.totalOrderLabel.Text = "Total Order : " + Convert.ToString( or.countAllOrder() );
                this.totalBikeLabel.Text = "Bike : " +Convert.ToString( or.countOrder("Bike") );
                this.totalCarLabel.Text = "Car : " +Convert.ToString( or.countOrder("Car") );
                this.totalAutoLabel.Text = "Cng : " + Convert.ToString(or.countOrder("Cng"));
                this.totalMicroLabel.Text = "Microbus : " + Convert.ToString(or.countOrder("Microbus"));
                this.totalPickupLabel.Text = "Pickup : " + Convert.ToString(or.countOrder("Pickup"));
                this.totalTruckLabel.Text = "Truck : " + Convert.ToString(or.countOrder("Truck"));


            //count the total Inventory in groupBox4

            InventoryRepository ir = new InventoryRepository();

             this.totalInventoryLabel.Text="Total Inventory : " + Convert.ToString( ir.countAllInventory() );
                 this.totalBikeILabel.Text = "Bike :" + Convert.ToString(ir.countInventory("Bike"));
                 this.totalCarILabel.Text = "Car :" + Convert.ToString(ir.countInventory("Car"));
                 this.totalAutoILabel.Text = "Cng :" + Convert.ToString(ir.countInventory("Cng"));
                 this.totalMicroILabel.Text = "Microbus :" + Convert.ToString(ir.countInventory("Microbus"));
                 this.totalPickupILabel.Text = "Pickup :" + Convert.ToString(ir.countInventory("Pickup"));
                 this.totalTruckILabel.Text = "Truck :" + Convert.ToString(ir.countInventory("Truck"));


            //count all shipment 

                 ShipmentRepository sr = new ShipmentRepository();
                  this.totalShipmentLabel.Text ="Total Shipment : "+Convert.ToString(sr.countAllShipment());
                  this.atOriginLabel.Text ="At Origin : " +Convert.ToString( sr.countShipment("At Origin"));
                  this.onTheWayLabel.Text = "On the Way : " + Convert.ToString(sr.countShipment("On the Way"));
                  this.stuckedLabel.Text = "Stucked : " + Convert.ToString(sr.countShipment("Stuked"));
                  this.atDestinationLabel.Text = "At Destination : " + Convert.ToString(sr.countShipment("At Destination"));
                  this.shippedLabel.Text = "Shipped : " + Convert.ToString(sr.countShipment("Shipped"));
            


            this.dataGrid2.Visible = false;
            this.dataGrid3.Visible = false;
            this.dataGrid4.Visible = false;

            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
        }

        private void totalMicroLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalPickupLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalTruckLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalBikeLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalCarLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalAutoLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalInventoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalPickupILabel_Click(object sender, EventArgs e)
        {

        }

        private void totalTruckILabel_Click(object sender, EventArgs e)
        {

        }

        private void totalBikeILabel_Click(object sender, EventArgs e)
        {

        }

        private void totalCarILabel_Click(object sender, EventArgs e)
        {

        }

        private void totalAutoILabel_Click(object sender, EventArgs e)
        {

        }

        private void totalMicroILabel_Click(object sender, EventArgs e)
        {

        }

        private void atOriginLabel_Click(object sender, EventArgs e)
        {

        }

        private void onTheWayLabel_Click(object sender, EventArgs e)
        {

        }

        private void stuckedLabel_Click(object sender, EventArgs e)
        {

        }

        private void atDestinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void shippedLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalShipmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            this.shpIdTxt.Text = "";
            this.shpProTxt.Text = "";
        }

        private void RefreshBtn2_Click(object sender, EventArgs e)
        {
            this.orderIdTxt.Text = "";
            this.productIdTxt.Text = "";
            this.productNameTxt.Text = "";
            this.quantityTxt.Text = "";
            this.addressTxt.Text = "";
            this.employeeNameTxt.Text = "";
            this.comboBox3.Text = "";

        }
    }
}
