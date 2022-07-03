using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Donguler.SonsuzForBreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int syc = 0;
            for (; ; )
            {
                syc++;
                if (syc == 4)
                {
                    break;

                }
                Console.WriteLine("break kodu tamamen kırar");

            }
            int i = 0;
            for (; ; )
            {
                i++;                    //contunie bir seferlik kodu kırar
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
                if (i == 10)
                    break;
            }
            Console.ReadLine();

        }
    }
}
