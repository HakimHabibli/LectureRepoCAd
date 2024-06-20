namespace OOP.Class_.Models;

// class'ın default access modifer değeri, internal'dır.
class Employee
{

    // sınıf içerisinde yer alan tüm elemanların default access modifier değeri, private'dır.

    // field, sınıf içerisinde field'lar her zaman private olmalıdır.



    // private -> sadece tanımlandığı sınıf içerisinde erişilebilir.
    //string firstName;
    //string lastName;
    //string email;
    //string phoneNumber;
    //string address;
    //int age;

    // publc -> tanımlandığı sınıf dışında da erişilebilir.
    //public string firstName;
    //public string lastName;
    //public string email;
    //public string phoneNumber;
    //public string address;
    //public int age;




    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
}


/*
 
 private            -> sadece tanımlandığı sınıf içerisinde erişilebilir.
 public             -> tanımlandığı sınıf dışında da erişilebilir.
 internal           -> Aynı assembly(derleme) içerisinden erişebilir
 protected          -> Tanımlandığı sınıf ve ondan türetilen sınıflar içerisinden erişilebilir.
 protected internal -> Aynı assembly içerisinden ve tanımlandığı sınıf ve ondan türetilen sınıflar içerisinden erişilebilir.
 private protected  -> Sadece tanımlandığı sınıf içinde veya aynı assembly'de türetilmiş sınıflar içerisinde erişilebilir. 

 
 */

