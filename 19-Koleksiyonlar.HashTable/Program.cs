using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _19_Koleksiyonlar.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1.Add("car", "araba");
            h1.Add("game", "oyun");
            bool kontrol = h1.Contains("araba");          //keyi kontrol eder
            bool kontrol2 = h1.ContainsKey("car");        //keyi kontrol eder
            bool kontrol1 = h1.ContainsValue("araba");    //valueyi kontrol eder
            int sayi = h1.Count;                          //eleman sayısını gösterir
            h1.Remove("car");                             //girilen keyi siler
            h1["game"] = "video oyunu";                   //düzenleme yapma
            h1.Clear();                                   //bütün listeyi siler

        }
    }
}
