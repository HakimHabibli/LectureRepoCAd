namespace Inheritance_.Models;

public class BaseEntity
{
    public int Id { get; set; }
}
 
public class BaseAuditEntity : BaseEntity
{
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public string CreatedIp { get; set; }
    public string ModifiedIp { get; set; }
    public string ModifiedComputerName { get; set; }
    public string CreatedComputerName { get; set; }
    public string CreatedADUserName { get; set; }
    public string ModifiedADUserName { get; set; }
}




public class Category : BaseEntity
{
    public string Name { get; set; }
}

public class Product : BaseAuditEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
 
public class BaseEmployee : BaseAuditEntity
{ 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
}
 
public class Student : BaseEmployee
{
    public string StudentNo { get; set; }
}
public class Teacher : BaseEmployee
{
    public string Department { get; set; }
    public string Salary { get; set; }
}