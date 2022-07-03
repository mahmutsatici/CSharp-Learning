using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Kosullar.İfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen iki adet sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)     //if koşul yapısıdır
            {
                Console.WriteLine("girdiğiniz ilk sayı daha büyüktür...");
            }
            else
            {
                Console.WriteLine("girdiğiniz ikinci sayı daha büyüktür...");
            }
            Console.ReadLine();
        }
    }
}
