namespace Interface_.Models;

public interface IFutbolcu
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string Takim { get; set; }
    public string FormaNo { get; set; }
    public string Mevki { get; set; }
    public int Agresiflik { get; set; }
    public int SutGucu { get; set; }
    public int TopKontrolu { get; set; }
    public int Kondisyon { get; set; }
    public decimal Maas { get; set; } 

}
