using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Metotlar.StaticRefOutParams
{
    class Class
    {
        public int yas;
        public static int numara;
        public static int toplam = 0;
        public static string Isimgonder()
        {
            Console.Write("Lütfen isminizi giriniz:  ");
            string ad = Console.ReadLine();
            return ad;

        }
        public void Artir(ref int a)
        {
            a++;
        }
        public void Degistir(out int c)
        {
            c = 21;

        }

        public static void topla(string v, params int[] sayilar)
        {  //params değişken sayıda parametre almaya yarar ve bunları bir diziye aktarır
           //eğer başka türde bir değişkenin de eklenmesini istiyorsanız paramstan önce yazmalısınız
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = sayilar[i] + toplam;
            }
            Console.WriteLine(toplam);
            Console.WriteLine(v);

        }
    }
}
