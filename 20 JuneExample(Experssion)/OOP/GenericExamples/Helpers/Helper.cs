using GenericExamples.Models;
using System.Reflection;

namespace GenericExamples.Helpers;
public static class Helper
{

    public static void WriteToConsole<T>(this T entity) where T : IEntity, new()
    {
        PropertyInfo[] properties = entity
            .GetType()
            .GetProperties();

        string propertyLength = properties
            .Select(p => p.Name)
            .OrderByDescending(name => name.Length)
            .FirstOrDefault();

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength.Length)} : {property.GetValue(entity)}");
        }
    }

    public static T Load<T>(T entity) where T : IEntity, new()
    {
        foreach (PropertyInfo prop in entity.GetType().GetProperties())
        {

            if (prop.Name == "Id")
                continue;

            Console.Write($"Lütfen {prop.Name} giriniz : ");
            string value = Console.ReadLine();

            try
            {
                object convertedValue = Convert.ChangeType(value, prop.PropertyType);
                prop.SetValue(entity, convertedValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Geçersiz değer girdiniz. Hata : {ex.Message}");
                return Load(entity);
            }
        }

        return entity;
    }
}
// Extension bir metot yazınız
// Metot ilgili sınıfın instance'na . dediğimizde çalışacak.
// bu metot sınıf içerisinde yer alan property değerlerini ekrana yazdırsın.
//    c1.WriteToConsole();