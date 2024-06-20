using June11.Helpers;
using June11.Models;

namespace June11
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//employee.Name = "Hakim";
			//employee.Surname = "Habibli";
			//employee.Age = 20;
			//employee.HourlyRate = 10;
			//employee.HourlyWorked = 300;

			//Console.WriteLine( employee.CalculateSalary());

			////employee.DisplayDetails();

			//employee1.Name = "Erestun";
			//employee1.Surname = "Ekberli";
			//employee1.Age = 20;
			//employee1.HourlyRate = 14;
			//employee1.HourlyWorked = 240;

			//Console.WriteLine(employee1.CalculateSalary());

			////employee1.DisplayDetails();

			HourlyEmployee employee1 = new HourlyEmployee();
			HourlyEmployee employee = new HourlyEmployee();
			SalariedEmployee salariedEmployee = new SalariedEmployee();
            Helper.Load(salariedEmployee);
            Helper.Load(employee1);
            Helper.Load(employee);
            Helper.WriteToConsole(employee);
            Helper.WriteToConsole(employee1);
            Helper.WriteToConsole(salariedEmployee);
            //salariedEmployee.Name = "Elnur";
            //salariedEmployee.Surname = "Ibadov";
            //salariedEmployee.Age = 20;
            //salariedEmployee.MonthlySalary = 2500;
            //Console.WriteLine(salariedEmployee.CalculateSalary());
            ////salariedEmployee.DisplayDetails();

        }
    }
}
