using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Koleksiyonlar.Stackk
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();         //stack son girdiğin değeri listenin ilk değeri olarak kaydeder
            s1.Push("bir");
            s1.Push("iki");
            s1.Push("üç");
            s1.Push("dört");

            s1.Pop();
            object b = s1.Pop();              //listenin ilk öğesini siler istersen silinen öğeyi objecte atayabilirsin
            object a = s1.Peek();             //listenin ilk öğesini objecte atar öğeyi silme işlemini yapmaz

        }
    }
}
