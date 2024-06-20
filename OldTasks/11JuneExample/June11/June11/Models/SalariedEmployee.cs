using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June11.Models
{
    internal class SalariedEmployee : IEmployee
    {
        private static int _id;
        public SalariedEmployee()
        {
            _id++;
            Id = _id;
        }
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double MonthlySalary { get; set; }


        public double CalculateSalary()
        {
            return MonthlySalary;
        }
        //Artiq Helper classi daxilinde WriteToConsole methodu olduguna gore displaydetails methoduna ehtiyac qalmir

        //public void DisplayDetails()
        //{
        //    Console.WriteLine($"Id:{Id} Name:{Name} Surname:{Surname} Age : {Age} Salary:{CalculateSalary()} MonthlySalary :{MonthlySalary}");
        //}
    }
}
