using Enum_.Models;
using System.Drawing;

Employee employee = new Employee
{
    FirstName = "John",
    LastName = "Doe",
    Email = "jhon.doe@asan.az",
    Phone = "+994501234455",
    Department = Departments.IT,
    SacRengi = Color.DarkOliveGreen
};

//employee
//    .GetType()
//    .GetProperties()
//    .ToList()
//    .ForEach(p => Console.WriteLine($"{p.Name.PadRight(15)} : {p.GetValue(employee)}"));



//switch (employee.Department)
//{
//    case Departments.HR:
//        break;
//    case Departments.IT:
//        break;
//    case Departments.Finance:
//        break;
//    case Departments.Marketing:
//        break;
//    case Departments.Sales:
//        break;
//    default:
//        break;
//}




string[] sehirler = Enum.GetNames(typeof(Sehirler));
foreach (var item in sehirler)
{
    //Console.WriteLine(item);
}


Console.WriteLine(Enum.GetName(typeof(Sehirler), 1));


bool isDefined = Enum.IsDefined(typeof(Sehirler), "Artvin");
Console.WriteLine(isDefined);


string enumName = "Istanbul";

Sehirler city = (Sehirler)Enum.Parse(typeof(Sehirler), enumName);
Sehirler sehir = Enum.Parse<Sehirler>(enumName);
