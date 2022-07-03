using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Operatorler.Dortİslem
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 15;
            int s2 = 12;
            int s3 = s1 + s2;

            byte b1 = 4;
            byte b2 = 5;
            int b3 = b1 + b2;


            string m1 = "ben";
            int s4 = 10;
            string m2 = m1 + s4;

            int s5 = 34;             //byte çıkarma işleminin sonucu int olabilir
            int s6 = 15;
            int s7 = s5 - s6;


            decimal d1 = 13.2M;
            decimal d2 = 13.4M;
            decimal d3 = d1 * d2;

            int s8 = (int)(d1 * d2);   //int virgülden öncesini alır


            int s9 = 15;
            int s10 = 2;
            double db1 = s9 / s10;

            int s11 = 15 % 2;
            int s12 = s9++;
            int s13 = ++s9;

            int s14 = s9--;
            int s15 = --s9;
        }
    }
}
