using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _22_Koleksiyonlar.Enqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            q1.Enqueue("bir");
            q1.Enqueue("iki");
            q1.Enqueue("üç");
            q1.Enqueue("dört");

            object a2 = q1.Dequeue();
            object a1 = q1.Peek();
        }
    }
}
