using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
			Stack<int> st = new Stack<int>();
			
			st.Push(9);
			st.Push(10);
			st.Push(50);
			st.Push(33);
			st.Push(14);
			
			Console.WriteLine("The contents of Stack: ");
			foreach (int element in st) 
			{ 
				Console.WriteLine(element); 
			}				
			Console.WriteLine("--------------------------------");

			Console.WriteLine(st.Contains(10));
			Console.WriteLine(st.Contains(16));
			Console.WriteLine("--------------------------------");

			Console.WriteLine("Popping out the top element = " + st.Pop());
			Console.WriteLine("Popping out the next element = " + st.Pop());
			Console.WriteLine("--------------------------------");

			Console.WriteLine("Peeking at the current top element = " + st.Peek());
			Console.WriteLine("--------------------------------");

			Console.WriteLine("After Updating: ");
			foreach (int element in st)
				Console.WriteLine(element);
			Console.ReadLine();
		}
    }
}
