using Interface_.Models;
using System.Collections;
using System.Reflection;

Kaleci kaleci = new Kaleci();
kaleci.Adi = "Tafarel";
kaleci.Soyadi = "Tefal";
kaleci.Takim = "Galatasaray";
kaleci.FormaNo = "1";
kaleci.Mevki = "Kaleci";
kaleci.Agresiflik = 10;
kaleci.SutGucu = 10;
kaleci.TopKontrolu = 10;
kaleci.Kondisyon = 10;
kaleci.Maas = 1000000;

// object initializer
Defans defans = new Defans
{
    Adi = "Sabri",
    Soyadi = "Sarioglu",
    Takim = "Galatasaray",
    FormaNo = "55",
    Mevki = "Defans",
    Agresiflik = 100,
    SutGucu = 5,
    TopKontrolu = 5,
    Kondisyon = 5,
    Maas = 50  // 50 TL 
};

ArrayList futbolcular = new ArrayList();
futbolcular.Add(kaleci);
futbolcular.Add(defans);


foreach (var futbolcu in futbolcular)
{

    #region Örnek 1
    /*
if (futbolcu is Kaleci kapici)
{

// Adı    : Tafarel
// Soyadı : Tefal
// ----------------------------------------

PropertyInfo[] properties = (new Kaleci()).GetType().GetProperties(); 
int propertyLength = properties
    .Select(p => p.Name)
    .OrderByDescending(name => name.Length)
    .FirstOrDefault().Length;

foreach (PropertyInfo property in properties)
{
    Console.WriteLine($"{property.Name.PadRight(propertyLength)} : {property.GetValue(kaleci)}");
}

Console.WriteLine(new String('-', 30));
}

else if (futbolcu is Defans mudafiyeci)
{
PropertyInfo[] properties = (new Defans()).GetType().GetProperties();
int propertyLength = properties
    .Select(p => p.Name)
    .OrderByDescending(name => name.Length)
    .FirstOrDefault().Length;

foreach (PropertyInfo property in properties)
{
    Console.WriteLine($"{property.Name.PadRight(propertyLength)} : {property.GetValue(mudafiyeci)}");
}

Console.WriteLine(new String('-', 30));
}
*/
    #endregion
     
    if (futbolcu.GetType().GetInterface(nameof(IFutbolcu)) != null)
    { 
        PropertyInfo[] properties = futbolcu
            .GetType()
            .GetProperties();

        string propertyLength = properties
            .Select(p => p.Name)
            .OrderByDescending(name => name.Length)
            .FirstOrDefault();


        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength.Length)} : {property.GetValue(futbolcu)}");
        }

        Console.WriteLine(new string('-', 30));
    }
}