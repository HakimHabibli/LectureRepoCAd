using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June11.Models
{
    public interface IEmployee
    {
        public  int Id { get;  }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double CalculateSalary();
        //public void DisplayDetails();
        
    }
}
