using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_demo
{
    sealed class ClassDemo
    {
        public void Add()
        {
            Console.WriteLine("I am sealed class");
        }
    }
    class B
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo obj = new ClassDemo();
            obj.Add();
        }
    }
}
