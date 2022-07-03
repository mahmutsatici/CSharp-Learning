using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Donguler.While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------");

            while (a >= 0)
            {
                Console.WriteLine(a);
                a--;
            }
            Console.ReadLine();
        }
    }
}
