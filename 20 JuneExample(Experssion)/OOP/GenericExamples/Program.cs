using GenericExamples.Models;
using static GenericExamples.Helpers.Helper;


namespace GenericExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Category c1 = Load(new Category());
        //Product p1 = Load(new Product());
        //Student s1 = Load(new Student());


        c1.WriteToConsole();

     
    }
}
