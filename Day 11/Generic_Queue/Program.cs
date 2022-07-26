using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
			Queue<string> q = new Queue<string>();
	
			q.Enqueue("India");
			q.Enqueue("US");
			q.Enqueue("Japan");
			q.Enqueue("Germany");
			q.Enqueue("Canada");


			Console.WriteLine("The contents of Queue: ");
			foreach (var element in q) 
			{
				Console.WriteLine(element);
			}
			
			Console.WriteLine("Does queue contains?  " + q.Contains("US"));
			
			Console.WriteLine("Total elements: {0}", q.Count);

	
			Console.WriteLine("Removing the element = " + q.Dequeue());
			Console.WriteLine("Removing the next element = " + q.Dequeue());


			Console.WriteLine("Peeking at the element = " + q.Peek());


			Console.WriteLine("Updated Queue: ");
			foreach (var element in q)
				Console.WriteLine(element);
			Console.ReadLine();
		}
    }
}
