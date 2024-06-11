using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasePhone basePhone = new BasePhone();
            Console.WriteLine(basePhone.Sound);

            MobilPhone mobilPhone = new MobilPhone();
            Console.WriteLine(mobilPhone.Sound);

            SmartPhone smartPhone = new SmartPhone();
            Console.WriteLine(smartPhone.Sound);







        }
    }
}
