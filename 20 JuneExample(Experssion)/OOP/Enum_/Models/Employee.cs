using System.Drawing;

namespace Enum_.Models;

public enum Departments
{
    HR,
    IT,
    Finance,
    Marketing,
    Sales
}

public enum Status
{
    None,
    Active,
    Inactive,
    Pending,
    Deleted,
    Approved,
    Rejected,
    Completed,
    Canceled,
}

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Departments Department { get; set; }
    public Color SacRengi { get; set; }
    public Status Statu { get; set; }
}


public enum Sehirler
{
    Adana = 1,
    Adıyaman = 2,
    Afyonkarahisar = 4,
    Ağrı = 8,
    Amasya = 16,
    Ankara = 32,
    Antalya = 64,
    Istanbul = 128,
    Izmir = 256,
}
