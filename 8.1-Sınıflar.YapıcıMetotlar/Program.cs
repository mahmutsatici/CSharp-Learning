using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Sınıflar.YapıcıMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba nesne = new Araba(12,"kırmızı",1.8); //yapıcı metotu kullanmak için değerleri gönderdik
            Console.WriteLine("Araba rengi: {0}",nesne.arabarengi);
            Console.WriteLine("Araba sayısı: {0}", nesne.arabasayisi);
            Console.WriteLine("Araba motoru: {0}", nesne.arabamotoru);
            Console.ReadLine();
        }
    }
}
