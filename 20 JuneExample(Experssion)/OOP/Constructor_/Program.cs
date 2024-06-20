using Constructor_.Models;

namespace Constructor_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Employee employee = new Employee("murat");
       
        
        Employee employee = new Employee();
        employee.FirstName = "ahmet";
        employee.LastName = "can";
        employee.Email = "deneme@d.com";
        employee.Phone = "1234567890";
        Console.WriteLine(employee.FirstName);
        Console.WriteLine(employee.CreatedComputerName);
        Console.WriteLine(employee.CreatedIp);
        Console.WriteLine(employee.CreatedLocalIp);


    }
}
