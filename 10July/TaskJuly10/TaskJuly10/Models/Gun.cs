using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskJuly10.Models;

public class Gun
{
    private int _magazine;
    public int PerMilSec { get; set; }
    public string Type { get; set; }
    public int Magazine 
    {
        get { return _magazine; }
        set 
        {
            if (value > 0)
            {
                _magazine = value;
            }
            else 
            {
                Console.WriteLine("Dogru magazin sayi qebul edin");
            }
        }
    }

    #region Ctor
    public Gun() { }
    public Gun(int magazine, string type) : this()
    {
        Type = type;
        Magazine = magazine;
    }
    public Gun(int milsn, int magazine, string type) : this(magazine, type)
    {
        milsn = PerMilSec;
    }
    #endregion


    public void FireSingle(int count) 
    {
        for (int i = 0; i < count; i++)
        {
            if (Magazine>0)
            {
                Magazine -= 1;
                Console.WriteLine("Gulle atildi :" + Magazine);
            }
            else
            {
                Console.WriteLine("Magazinde gulle bitdi");
                break;
            }

        }
    }
    public void FireAvto(int count)
    {
        for (int i = 0; i<count; i++)
        {
            if(PerMilSec>0)
            {
                Magazine -= count;
                Console.WriteLine($"Avto Rejimdə qalan gulle :{Magazine}");
                PerMilSec--;
            }
            else
            {
                Console.WriteLine("Magazinde gulle bitdi");
            }
        }
    }
    
}
