using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _20_Koleksiyonlar.Sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            //sortedlistin hashtableden tek farkı keysleri otomatik bir şekilde alfabetik sıralamasıdır
            SortedList s1 = new SortedList();
            s1.Add(3, "mahmut");
            s1.Add(5, "kevser");
            s1.Add(2, "ayşe");
            s1.Add(1, "abdulkadir");
            s1.Add(4, "firdevs");

        }
    }
}
