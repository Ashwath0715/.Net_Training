using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Rahul");
            q.Enqueue("Raj");
            q.Enqueue("Vijay");
            Console.WriteLine("Count is " + q.Count);
            foreach(var i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine(q.Contains("Raj"));
            Console.WriteLine("------------------------");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("----After remove----");
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}
