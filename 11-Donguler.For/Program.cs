using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Donguler.For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------");



            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine("---------------------------------------------------");

            int c = 0;

            for (int i = 2; i < 101; i += 2)
            {

                c = c + i;
            }

            Console.WriteLine("1 - ile 100 arasındaki çif sayıların toplamı: " + c);




            Console.ReadLine();
        }
    }
}
