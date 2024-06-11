using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    
    public class BasePhone : Object
    {

        public override string ToString()
        {
            return base.ToString();
        }
        public string Sound() { return "Default song"; }
    }
    public class MobilPhone :BasePhone
    {
        public string Sound() { return "Mobil sound"; }
        
       
    }
    public class SmartPhone : MobilPhone
    {
       
    }
    public class BaseHuman
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
    public class Student:BaseHuman
    {
        public string StudentNo { get; set; }
    }
    public class Teacher:BaseHuman
    {
        public string Department { get; set; }
        public string Salary { get; set; }
    }
}
