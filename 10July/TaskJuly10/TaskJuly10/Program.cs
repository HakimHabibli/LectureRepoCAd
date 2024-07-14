using TaskJuly10.Models;

namespace TaskJuly10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magazini daxil edin");
            int magazine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silahin tipini daxil edin");
            string GunType = Console.ReadLine();
            Console.WriteLine("Milli Saniyede ata bileceyi gulle sayisini daxil edin");
            int MilSec = Convert.ToInt32(Console.ReadLine());
            Gun gun = new Gun();
            gun.Magazine = magazine;
            gun.Type = GunType;
            gun.PerMilSec = 2;
            gun.FireSingle(5);
            gun.FireAvto(2);
        }
    }
}
