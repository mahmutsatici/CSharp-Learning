using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Kosullar.SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bulunduğumuz ay: ");
            string a = Console.ReadLine();

            switch (a)
            {
                case "ocak":
                case "şubat":
                case "aralık":
                    Console.WriteLine("kış mevsimindesiniz...");
                    break;
                case "mart":
                case "nisan":
                case "mayıs":
                    Console.WriteLine("ilkbahar mevsimindesiniz...");
                    break;
                case "haziran":
                case "temmuz":
                case "ağustos":
                    Console.WriteLine("yaz mevsimindesiniz...");
                    break;
                case "eylül":
                case "ekim":
                case "kasım":
                    Console.WriteLine("sonbahar mevsimindesiniz...");
                    break;
                default:
                    Console.WriteLine("yanlış bir değer girdiniz!!!");
                    break;


            }
            Console.ReadLine();
        }
    }
}
