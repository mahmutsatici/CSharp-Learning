using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Sınıflar.YapıcıMetotlar
{
    class Araba
    {
        public int arabasayisi;
        public string arabarengi;
        public double arabamotoru;
        public Araba(int _arabasayisi , string _arabarengi , double _arabamotoru)
        {                        //değerler buradaeşitlendi
            arabasayisi = _arabasayisi;
            arabarengi = _arabarengi;
            arabamotoru = _arabamotoru;
        }
        public Araba()
        {
            //istersek nesne oluştururken  bu kısım sayesinde normal atama da yapılabilir
        }
    }
}
