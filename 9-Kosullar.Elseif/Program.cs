using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Kosullar.Elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoşgeldiniz lütfen iki sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if ((a + b) > 100)
            {
                Console.WriteLine("girdiğiniz sayıların toplamı 100 den büyük...");
            }
            else if ((a + b) > 50)
            {
                Console.WriteLine("girdiğiniz sayıların toplamı 50 den büyük...");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayıların toplamı 50 den küçük...");
            }
            Console.ReadLine();
        }
    }
}
