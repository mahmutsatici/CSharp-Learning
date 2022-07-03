using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Degiskenler.DegiskenTurleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Mahmut";
            Console.WriteLine(a);
            int b;
            b = 4;
            Console.WriteLine(b);
            string buyuk = a.ToUpper();
            // stringdeki harfleri büyültür
            string kucuk = a.ToLower();
            // stringdeki harfleri küçültür
            string belli = a.Substring(2, 3);
            // a değişkeninin ikinci karakterinden 3 harf sonrasını alır
            Console.WriteLine(buyuk);
            Console.WriteLine(kucuk);
            Console.WriteLine(belli);

            char c = 'Z';
            Console.WriteLine(c);
            // char stringin tek değere taşıyan halidir 

            int d = 131;
            byte e = 6;
            byte f = byte.MaxValue;
            byte h = byte.MinValue;
            int k = int.MaxValue;
            int l = int.MinValue;
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.WriteLine(k);
            Console.WriteLine(l);

            //byte ve int tamsayı değişkenlerini saklar
            //min max value alabileceği min ve max değerleri gösterir


            // double decimal float ondalıklı sayılar için kullanılır
            // double sonuna harf konulmadan da kullanılır

            double m = 10.4;
            double n = 10;
            double p = 11.5d;

            float q = 13.7F;
            decimal r = 32.9M;




            Console.ReadLine();

        }
    }
}
