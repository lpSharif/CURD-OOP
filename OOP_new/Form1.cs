using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataAccess DataAccess = new DataAccess();
        public int customerID;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isVaild())
            {
                Customer newCustomer = new Customer(-1,fstnamebox.Text, lstnamebox.Text, agebox.Text, citybox.Text);
               
                DataAccess.AddCustomer(newCustomer);

                MessageBox.Show("New Customer Added Successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CustomerTable.DataSource = DataAccess.GeAlltCustomers();
                refreshBoxs();
            }

                
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (customerID > 0)
            {
                if (customerID == Convert.ToInt32(idbox.Text))
                {
                    Customer newCustomer = new Customer(customerID, fstnamebox.Text, lstnamebox.Text, agebox.Text, citybox.Text);
                    DataAccess.AddUpdateCustomer(newCustomer);

                    MessageBox.Show("Customer's Record Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CustomerTable.DataSource = DataAccess.GeAlltCustomers();
                    refreshBoxs();
                }
                else
                {
                    MessageBox.Show("Can't Change Customer ID :(", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please Select A Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customerID > 0)
            {
                Customer newCustomer = new Customer(customerID);
                DataAccess.DeleteCustomer(newCustomer);

                MessageBox.Show("Customer's Deleted Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CustomerTable.DataSource = DataAccess.GeAlltCustomers();
                refreshBoxs();
            }
            else
            {
                MessageBox.Show("Please Select A Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshBoxs();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerTable.DataSource = DataAccess.GeAlltCustomers();
        }



        private void CustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerID = Convert.ToInt32(CustomerTable.SelectedRows[0].Cells[0].Value);
            idbox.Text = CustomerTable.SelectedRows[0].Cells[0].Value.ToString();
            fstnamebox.Text = CustomerTable.SelectedRows[0].Cells[1].Value.ToString();
            lstnamebox.Text = CustomerTable.SelectedRows[0].Cells[2].Value.ToString();
            agebox.Text = CustomerTable.SelectedRows[0].Cells[3].Value.ToString();
            citybox.Text = CustomerTable.SelectedRows[0].Cells[4].Value.ToString();
        }

        private bool isVaild()
        {
            if (fstnamebox.Text == string.Empty)
            {
                MessageBox.Show("Customer's First Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (lstnamebox.Text == string.Empty)
            {
                MessageBox.Show("Customer's Last Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (agebox.Text == string.Empty)
            {
                MessageBox.Show("Age is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (citybox.Text == string.Empty)
            {
                MessageBox.Show("City name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }

}

