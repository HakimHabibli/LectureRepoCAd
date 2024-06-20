using OOP.Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.FirstName = "John";
            customer.LastName = "Doe";

            customer.Phone = "1234567890";
            customer.Address = "Baku, Azerbaijan";
            customer.Age = 40;
            


            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.FullName);

            //try
            //{
            //    customer.Age = 10;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }
    }
}
