using Abstract_.Models;
using System.Collections;

namespace Abstract_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bateri bateri = new Bateri
            {
                Marka = "DW",
                Model = "Performance Series",
                Aciklama = "DW Performance Series Drum Set",
                Fiyat = 3000,
                UretimYeri = "USA",
                Hammadde = Hammadde.Metal,
                DeriTipi = "Cowhide"
            };

            Keman keman = new Keman
            {
                Marka = "Stradivarius",
                Model = "1715",
                Aciklama = "Stradivarius Violin",
                Fiyat = 1600000,
                UretimYeri = "Italy",
                Hammadde = Hammadde.Agac,
                TelTipi = "Gut",
                Arse = "Tourte Bow"
            };

            Gitar gitar = new Gitar
            {
                Marka = "Fender",
                Model = "Stratocaster",
                Aciklama = "Fender Stratocaster Electric Guitar",
                Fiyat = 1200,
                UretimYeri = "USA",
                Hammadde = Hammadde.Agac,
                Akustik = false
            };
            Muzisyen baterist = new() { Adi = "John", Soyadi = "Bonham", Enstruman = bateri };
            Muzisyen kemanci = new() { Adi = "Niccolo", Soyadi = "Paganini", Enstruman = keman };
            Muzisyen gitarist = new() { Adi = "Jimi", Soyadi = "Hendrix", Enstruman = gitar };

            Muzisyen piyanist = new()
            {
                Adi = "Ludwig",
                Soyadi = "van Beethoven",
                Enstruman = new Piano
                {
                    Marka = "Steinway & Sons",
                    Model = "Model D",
                    Aciklama = "Steinway & Sons Model D Concert Grand Piano",
                    Fiyat = 170000,
                    UretimYeri = "Germany",
                    Hammadde = Hammadde.Agac,
                    TelTipi = "Steel",
                    TusTakimi = "88 Keys"
                }
            };

            ArrayList muzisyenler = new ArrayList();
            muzisyenler.Add(kemanci);
            muzisyenler.Add(gitarist);
            muzisyenler.Add(baterist);
            muzisyenler.Add(piyanist);


            foreach (var muzisyen in muzisyenler)
            {
                var muzisyenType = muzisyen.GetType();
                var muzisyenProperties = muzisyenType.GetProperties();

                Console.WriteLine($"{muzisyenType.Name}{new String('_', 55)}");

                foreach (var muzisyenProperty in muzisyenProperties)
                {
                    #region MyRegion

                    //bool result = Attribute.GetCustomAttribute(muzisyenProperty, typeof(ChildItemAttribute)) != null;
                    //if (result)   {

                    //    Console.WriteLine("Attribute var");
                    //}
                    #endregion
                    if (muzisyenProperty.Name == "Enstruman")
                    {

                        var enstruman = muzisyenProperty.GetValue(muzisyen);
                        Console.WriteLine($"{muzisyenProperty.Name}{new String('_', 55)}");

                        foreach (var enstrumanProperty in enstruman.GetType().GetProperties())
                        {
                            Console.WriteLine($"    {enstrumanProperty.Name.PadRight(10)} : {enstrumanProperty.GetValue(enstruman)}");
                        }
                        string[] functionNames = { "Sound", "Ses" };
                        var funcs = enstruman
                            .GetType()
                            .GetMethods()
                            .Where(m => functionNames.Contains(m.Name)); 
                        foreach (var func in funcs)
                        { 
                            string funcResult = default;

                            if (func.GetParameters().Length > 0)
                            {
                                funcResult = $"{func.Invoke(enstruman, new[] { enstruman.GetType().Name })}";
                            }
                            else
                            {
                                funcResult = $"{func.Invoke(enstruman, null)}";
                            }
                            Console.WriteLine($"    {func.Name.PadRight(10)} : {funcResult}");
                        }
                        break;
                    }
                    Console.WriteLine($"{muzisyenProperty.Name.PadRight(10)} : {muzisyenProperty.GetValue(muzisyen)}");
                }
                Console.WriteLine("");
            }


            /*
             """
             Müzisyen______________________
                 Adı : Niccolo
                 Soyadı : Paganini

             Enstruman _____________________
                 Marka : Stradivarius
                 Model : Stradivarius 1715
                 Açıklama : Stradivarius Violin
                 Fiyat : 1600000
                 Üretim Yeri : Italy
                 Hammadde : Agac
                 Tel Tipi : Gut
                 Arşe : Tourte Bow
                 Sound : Vınnnnnnnnn
              """
             
             */

        }
    }
}
