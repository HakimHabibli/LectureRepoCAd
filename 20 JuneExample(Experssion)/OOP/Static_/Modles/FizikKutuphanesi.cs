namespace Static_.Modles;

public static class FizikKutuphanesi
{
    // kendiliğinden static olma özelliğne sahip değişmeyen veri tipidir.
    public const double Pi = 3.14;
    //public string ConnectionString = "server;";
    //public readonly string ReadOnlyConnection = "readonly";
    public static readonly string ConnectionStringReadOnly = "readonly";

    public static string Domain { get; set; }
    public static readonly string Extension = "edu.az";
}