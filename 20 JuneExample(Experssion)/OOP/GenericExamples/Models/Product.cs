namespace GenericExamples.Models;

public class Product : IEntity
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
}