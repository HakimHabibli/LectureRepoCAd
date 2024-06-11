using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June11.Models
{
    internal class HourlyEmployee:IEmployee
    {
        private static int _id;
        public HourlyEmployee()
        {
            _id++;

            Id = _id;
        }
        public  int Id { get;  }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double HourlyRate { get; set; }
        public double HourlyWorked { get; set; }

        public double CalculateSalary()
        {
            return HourlyRate * HourlyWorked;
        }

        //public void DisplayDetails()
        //{
        //    Console.WriteLine($"Id:{Id} Name:{Name} Surname:{Surname} Age : {Age} Salary:{CalculateSalary()}");
        //}
    }
}
