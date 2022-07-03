using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TurDonusumu.BilincliBilincsizTurDonusumu
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = 255;
            int sayi2 = sayi1;   //bilinçli tür dönüşümü


            int sayi3 = 255;
            byte sayi4 = (byte)sayi3;   //bilinçsiz tür dönüşümü (kullanıcya güvenir)

            object o1 = 21;         //object her değeri alabilir
            object o2 = 34.5;
            object o3 = "mahmut";
            object o4 = true;

            string m1 = "255";                 //tür dönüşümü için convert ve parse kullanılır
            int s1 = int.Parse(m1);
            int s2 = Convert.ToInt32(m1);

            string m2 = "true";
            bool b1 = bool.Parse(m2);
            bool b2 = Convert.ToBoolean(m2);

            string m3 = null;                      //convert null değer alır ama parse alamaz        
            decimal d1 = Convert.ToDecimal(m3);
            //decimal d2 = decimal.Parse(m3);


            var v1 = 13;         //var değişkenleri otommatik atar
            var v2 = "naber";
        }
    }
}
