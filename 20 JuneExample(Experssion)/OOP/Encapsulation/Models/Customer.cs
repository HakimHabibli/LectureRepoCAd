using System.ComponentModel.DataAnnotations.Schema;

namespace OOP.Encapsulation.Models;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }


    // code.edu.az

    //public string Email
    //{ // readonly
    //    get => $"{this.FirstName}.{this.LastName}@code.edu.az";
    //}

    //public string Email
    //{  
    //    get
    //    {
    //        return $"{this.FirstName}.{this.LastName}@code.edu.az";
    //    }
    //}

    [NotMapped] // db içerisinde, column oluşmaz 
    public string FullName => $"{this.FirstName} {this.LastName}";
    public string Email => $"{this.FirstName}.{this.LastName}@code.edu.az";



    public string Address { get; set; }

    // value -> set edilen değer


    private int _age;
    public int Age
    {
        //get; // getter -> okumak için 
        //set; // setter -> değer atamak için
        get => _age;
        set
        {
            if (value < 18)
            {
                throw new Exception("Age must be greater than 18");
                //_age = -1;
            }
            else
            {
                _age = value;
            }
        }
    }

    string _password;
    public void SetPassword(string password) { }
    public string GetPassword() => _password;
}
