namespace Polymorphism_.Models;

public class BasePhone
{
    public string Brand { get; set; }
    public string ConnectionType { get; set; }
    public virtual string Sound() => "default phone sound";
}

public class MobilePhone : BasePhone
{
    public string OS { get; set; }
    //public string Sound() => "mobile phone sound";
    public override string Sound()
    {

        // += data ekle
        // return

        return "mobile phone sound";
    }

    public override string ToString()
    {
        return $"Mobil Telefon yazsın";
    }
}

public class SmartPhone : MobilePhone
{
    //public string Sound() => "smart phone sound";


    public string ReturnToStringType { get; set; }
    public override string Sound()
    {
        return "smart phone sound";
    }

    public override string ToString()
    {
        return ReturnToStringType switch
        {

            "smart" => "SmartPhone",
            "mobile" => "MobilePhone",
            "base" => "BasePhone",
            _ => base.ToString()
        };


        //Console.WriteLine("To string metodu çalıştı vs.");
        //Console.WriteLine(base.ToString());
        //return $"{this.Brand}\n{this.OS}\n{this.ConnectionType}";
    }
}