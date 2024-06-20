using System.ComponentModel.DataAnnotations;

namespace News.Models;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}



/*
 * 
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
 * 
 * 
C# 'record' -> değer tabanlı eşitliği (value-based quality) destekleyen, genellikle küçük, değişmez(immutable) nesneler oluşturmak için kullanılan bir özellik.C#9 ve sonrası için geçerlidir.

Değişmezlik (Immutability): Bir record'un özellikleri genellikle sadece oluşturulduğu zaman belirlenir ve sonrasında değiştirilemez.
Değer Tabanlı Eşitlik: İki record örneği, içerdikleri verilere göre karşılaştırıldığında eşit olabilir.
.

 */

//public record Personel(string FirstName, string LastName);
public record Personel()
{
    [Required(ErrorMessage = "Bu alan boş geçilemez")]
    public required string FirstName { get; set; }

    [Required(ErrorMessage = "Bu alan boş geçilemez")]
    public string LastName { get; set; } = null!;
}

public record Ogrenci(string FirstName);
public record Employee(string FirstName, string LastName, string Email, string Phone, Personel Personel) : Ogrenci(FirstName);



// required -> 'required' olarak işaretlendiyse, mutlaka Initizlie ederken değer ataması yapmanız gerekir, sonrasında bu değeri atama işlemi ile değiştirebilirsiniz. Constructor içerisinde atama işlemi geçerli sayılmayacaktır.

// init -> bir nesnenin oluşurken verilmesi gereken default değeridir. Constructor içerisinde belirtirseniz Onject Initialize tarafında belirtmenize gerek yoktur. Aksi halde Object Initialize tarafında bu değeri belirtmeniz gerekir. Sonrasında bu değer'de değişiklik yapamazsınız (Immutability)


public record Category
{
    //public Category()
    //{
    //    this.Name = "Beverages";
    //    this.Description = "Bu bir kategori";
    //}
    //public int Id { get; set; }
    //public required string Name { get; set; }
    //public string Description { get; init; } = "default description";
    //public string ImageUrl { get; set; }


    public Category() { }
    public Category(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public void Update(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }
}