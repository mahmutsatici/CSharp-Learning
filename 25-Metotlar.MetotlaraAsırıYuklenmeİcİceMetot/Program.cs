using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Metotlar.MetotlaraAsırıYuklenmeİcİceMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            //consol writeline bir metottur ve birden fazla görev alabilir(string çıktısı verme, int çıktı verme...)
            //bizde metotlarımıza birden fazla görev verebiliriz buna metota aşırı yüklenme denir

            topla(12, 6);

        }
        static void topla(int a, int b)
        {
            Console.WriteLine(toplama(a, b));  //iç içe metot kullanımı(local function)
                                               //toplama metotu sadece topla methodu içerisinde kullanılabilir
            int toplama(int c, int d)
            {
                return c + d;

            }
        }
        static void topla(decimal a, decimal b)
        {
            Console.WriteLine(a + b);
        }
        static void topla(string a, string b)
        {
            Console.WriteLine(a + b);
        }
    }
    
}
