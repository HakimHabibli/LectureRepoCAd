using System.ComponentModel.DataAnnotations;

namespace Abstract_.Models;





public class SubItemAttribute : System.Attribute { }
public class ChildItemAttribute : System.Attribute { }


public enum Hammadde
{
    Agac,
    Metal,
    Plastik
}



public class Muzisyen
{

    [Required]
    public string Adi { get; set; }
    [MaxLength(50), Required(ErrorMessage = "Code edu")]
    public string Soyadi { get; set; }
    [SubItem, ChildItem]
    public Enstruman Enstruman { get; set; }
}



public interface IEnstruman { }
public abstract class Enstruman : IEnstruman
{


    [Display(Name = "Brand")]
    public string Marka { get; set; }
    [Required(ErrorMessage = "Model can not be empty.")]
    public string Model { get; set; }
    public string Aciklama { get; set; }
    public decimal Fiyat { get; set; }
    public string UretimYeri { get; set; }
    public Hammadde Hammadde { get; set; }

    public virtual string Ses(string name) => $"{name} Enstrumanı Default Sound";
    public abstract string Sound();
}

public class Bateri : Enstruman
{
    public string DeriTipi { get; set; }
    public override string Sound() => "Tak Tak Tak";
}

public class Keman : Enstruman
{
    public string TelTipi { get; set; }
    public string Arse { get; set; }
    public override string Sound() => "Vınnnnnnnnn";
}

public class Gitar : Enstruman
{
    public bool Akustik { get; set; }
    public override string Sound() => "Tın Tın Tın";
}

public class Piano : Enstruman
{
    public string TelTipi { get; set; }
    public string TusTakimi { get; set; }
    public override string Sound() => "Ding Ding Ding";
}