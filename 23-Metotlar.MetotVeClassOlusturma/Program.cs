using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Metotlar.MetotVeClassOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            selamver();
            Class1 o1 = new Class1();
            o1.selamver2();
            o1.adsoyad("mahmut", "satici");
        }
        static void selamver()
        {
            Console.WriteLine("Herkese merhaba");
        }
    
    }
}
