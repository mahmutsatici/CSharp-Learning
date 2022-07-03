using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Metotlar.StaticRefOutParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adınız: " + Class.Isimgonder());     // class içindeki isimgonder metotunu static olarak
                                                                    // belirlediğimiz için nesne kullanmadan metotu kullanabildik
            Class nesne = new Class();

            nesne.yas = 11;                    //yas değişkenini classta static olarak belirlemediğimiz için nesne ile kullanabildik
            Class.numara = 823;               //ama numara static olduğu için nesne ye gerek kalmadı
            int b = 8;

            nesne.Artir(ref b);      //ref kullanmasaydık artma olmazdı
            Console.WriteLine(b);    //ref kullanırken değişken metota gelirken değer almak zorundadır

            nesne.Degistir(out b);    //out kullanırken metot içinde atama yapmak zorundasın
            Console.WriteLine(b);
            Class.topla("mahmut", 1, 2, 3, 4, 5, 6, 7, 8, 9);    //metotu kullanarak bir dizi ataması yaptık
            Console.ReadLine();
        }

    }
}

