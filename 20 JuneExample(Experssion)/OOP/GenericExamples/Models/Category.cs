namespace GenericExamples.Models;
public class Category : IEntity
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
}
