using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_new
{
    class Customer
    {
        public int id;
        public string firstName;
        public string lastName;
        public string age;
        public string city;

        public Customer(int id , string firstName=null,string lastName=null,string age=null,string city=null)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
        }
    }
}
