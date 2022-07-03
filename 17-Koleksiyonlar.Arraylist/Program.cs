using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _17_Koleksiyonlar.Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array1 = new ArrayList();
            array1.Add(100);
            array1.Add("mahmut");

            ArrayList array2 = new ArrayList();
            array2.Add("mühendis");
            array2.Add("doktor");
            array2.Add(1);
            array2.Add(2);
            array2.Add(3);
            array2.Add(4);
            array2.Add(5);

            array1.AddRange(array2);

            int c = array1.Capacity;
            int d = array1.Count;

            object o1 = array1[1];
            string s1 = array1[0].ToString();         //string kabul etmediği için string dönüşümü yaptık(object olmalı yani)
            int i1 = (int)array1[0];                  //int i kabul etmediği için bizim kabul ettirmemiz lazım

            array2.RemoveAt(4);                 //4. değeri siler
            array2.RemoveRange(2, 3);           //2. değerden başlar ve 2 3 4. değerleri siler
            array1.Remove("mahmut");            //mahmut değerini siler 

        }
    }
}
