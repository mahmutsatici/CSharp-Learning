using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Koleksiyonlar.Dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "mahmut";
            string[] a = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("lütfen herhangi bir isim giriniz: ");
                a[i] = Console.ReadLine();
            }
            Console.WriteLine("----------------------------------");

            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("dizinin uzunluğu = " + a.Length + " sayısıdır");
            Console.ReadLine();
        }
    }
}
