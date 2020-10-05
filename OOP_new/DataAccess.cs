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
        public int AddCustomer(string firstName, string lastName, string age, string city)
        {
            SqlCommand cmd = new SqlCommand("insert into Customer values (@firstName, @lastName,@age,@city)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@city", city);
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
        public void DeleteCustomer(int customerId)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE customerId = @customerId", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@customerId", customerId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AddUpdateCustomer(int customerId,string fstName,string lstName,string age,string city)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET firstName = @firstName, lastName = @lastName,age = @age,city = @city WHERE customerId = @customerId", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@firstName", fstName);
            cmd.Parameters.AddWithValue("@lastName", lstName);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@customerId", customerId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
    }

}
