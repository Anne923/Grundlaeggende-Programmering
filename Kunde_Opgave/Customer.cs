using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunde_Opgave
{
    public class Customer
    {
        private string firstName;
        private string address;
        private int ID;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (firstName != "Peter") {
                    firstName = value;
                }
            }
        }

        public string LastName { get; set; }


        public string Address
        {
            get { return address; }
            
            set { address = value; }
        }

        public Customer()
        {
            ID = 5;
        }

        public Customer(string firstName)
        {
            ID = 7;
            this.firstName = firstName;
        }

        public override string ToString()
        {
            return firstName + "" + LastName;

        }
    }
}
