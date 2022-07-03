using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım.NesneModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi k = new Kedi();
            k.isim = "karabaş";
            k.renk = "beyaz";      //kedi classında hiç kod olmamasına rağmen köpek classından türetildiği için 
            k.yas = 4;             //köpek classındaki 'public' olan bütün değerleri kullanabildik
            k.Hayvanbilgi();
            Console.ReadLine();
        }
    }
}
