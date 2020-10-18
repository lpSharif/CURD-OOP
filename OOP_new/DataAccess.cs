using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_new
{
    class DataAccess
    {
        SqlConnection con;
        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=LPSHARIF;Initial Catalog=Customer;Integrated Security=True");
        }
        public int AddCustomer(Customer Customer)
        {
            SqlCommand cmd = new SqlCommand("insert into Customer values (@firstName, @lastName,@age,@city)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@firstName", Customer.firstName);
            cmd.Parameters.AddWithValue("@lastName", Customer.lastName);
            cmd.Parameters.AddWithValue("@age", Customer.age);
            cmd.Parameters.AddWithValue("@city", Customer.city);
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();

            return status;
        }
        public DataTable GeAlltCustomers()
        {
            SqlCommand cmd = new SqlCommand("select * from Customer", con);
            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

             return dt;
        }
        public void DeleteCustomer(Customer Customer)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE customerId = @customerId", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@customerId", Customer.id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AddUpdateCustomer(Customer Customer)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET firstName = @firstName, lastName = @lastName,age = @age,city = @city WHERE customerId = @customerId", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@firstName", Customer.firstName);
            cmd.Parameters.AddWithValue("@lastName", Customer.lastName);
            cmd.Parameters.AddWithValue("@age", Customer.age);
            cmd.Parameters.AddWithValue("@city", Customer.city);
            cmd.Parameters.AddWithValue("@customerId", Customer.id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
    }

}
