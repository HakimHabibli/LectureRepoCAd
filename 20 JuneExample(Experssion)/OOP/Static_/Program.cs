using Static_.Modles;

namespace Static_; 
internal class Program
{
    static void Main(string[] args)
    {
        //FizikKutuphanesi fiziKutuphanesi = new FizikKutuphanesi();

        // Pi değişkeni static olduğu için nesne oluşturmadan erişebiliriz.
        double sonuc = FizikKutuphanesi.Pi;


        //fiziKutuphanesi.ConnectionString = "server=";
        //string con = fiziKutuphanesi.ConnectionString;

        //fiziKutuphanesi.ReadOnlyConnection = "readonly";
        //string con1 = fiziKutuphanesi.ReadOnlyConnection;
        string read = FizikKutuphanesi.ConnectionStringReadOnly;// = "readonly";
        FizikKutuphanesi.Domain = "www.domain" + FizikKutuphanesi.Extension; 
    }
} 