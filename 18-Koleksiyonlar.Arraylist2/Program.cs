using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _18_Koleksiyonlar.Arraylist2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar1 = new ArrayList();
            ar1.Add("adana");
            ar1.Add("bursa");
            ar1.Add("konya");
            ar1.Add("izmit");
            ar1.Add("elazığ");
            ar1.Add("edirne");
            ar1.Add("balıkesir");

            ar1.Sort();      //sort arraylisti alfabetik sıralar
            ar1.Reverse();   //reverse arraylisti alfabenin tersine göre sıralar
            bool sorgu = ar1.Contains("edirne");            //contains içinde varmı diye kontrol eder
            int indexsırası = ar1.IndexOf("balıkesir");     //indexof değerin kaçıncı sırada olduğunu gösterir
            object[] dizi = ar1.ToArray();                  //listeyi diziye aktarmamızı sağlar


            ar1.Clear();   //bütün listeyi temizler
            ar1.TrimToSize();     //kapsiteyi ilk haline getirir (yani 4)
        }
    }
}
