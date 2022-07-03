using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Donguler.DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //do while önce çalıştırır sonra kontrol eder yani en az bir kere çalışır
            string a;
            string b;
            do
            {
                Console.WriteLine("lütfen kullanıcı adı ve şifre giriniz");
                Console.Write("Kullanıcı Adı: ");
                string d = Console.ReadLine();
                a = d;
                Console.Write("Şifre: ");
                string c = Console.ReadLine();
                b = c;

            } while (a != "admin" && b != "1234");
            Console.WriteLine("--giriş başarılı--");
            Console.ReadLine();
        }
    }
}
