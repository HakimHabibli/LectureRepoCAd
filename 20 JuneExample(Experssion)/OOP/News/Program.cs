using News.Models;

namespace News;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        var st1 = new Student();
        st1.FirstName = "Mehmet";


        Student st2 = st1;
        st2.FirstName = "Ali";



        //Console.WriteLine(st1.FirstName);
        //Console.WriteLine(st2.FirstName);







        var emp1 = new Employee("Ahmet", "Yılmaz", "ahmet@ahmet.com", "123", null);
        var emp2 = new Employee("Ahmet", "Yılmaz", "ahmet@ahmet.com", "123", null);

        if (emp1 == emp2)
        {
            Console.WriteLine("Eşit");
        }
        else
        {
            Console.WriteLine("Eşit Değil");
        }


        //Console.WriteLine(emp1);



        //Employee emp3 = emp1;
        //emp3.FirstName = "Abuzer";


        Employee emp3 = emp1 with
        {
            FirstName = "Abuzer",
            Personel = new() { FirstName = "Mehmet", LastName = "Şahin" }

        };
        //Console.WriteLine(emp3.FirstName);
        //Console.WriteLine(emp3);


        //Personel p = new("Ali","Veli");
        Personel p = new()
        {
            FirstName = ""
        };
        p.FirstName = "Mehmet";
        Console.WriteLine(p);
        p.FirstName = "Ahmet";
        Console.WriteLine(p);
        p.FirstName = "Veli";
        Console.WriteLine(p);
        p.LastName = "Şahin";

        Personel p1 = p;
        p1.FirstName = "Hasan";
        Console.WriteLine(p1);



        Category c = new()
        {
            Name = "Beverages",
            Description = "Açıklama",
        };

        //c.Description = "Açıklama";


        Category updated = new();  // db.Categories.FirstOrDefault(x => x.Id == 1);
        updated.Update("", "");


        Category newC = new("", "");
        // db.Categories.Add(newC);
    }
}
