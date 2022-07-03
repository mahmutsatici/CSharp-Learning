using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım.NesneModelleme
{
    class Kopek
    {
        public int yas;
        public string renk;
        public string isim;
        private string boy;

        public void Hayvanbilgi()
        {
            Console.WriteLine("Yaş: "+yas);
            Console.WriteLine("Renk: "+renk);
            Console.WriteLine("İsim: "+isim);
        }
    }
}
