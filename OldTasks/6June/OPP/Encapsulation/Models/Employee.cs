 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber => $"{this.FirstName }";
        public string Address;
        private int _age;
        public int Age { get; set; }
    }
}
