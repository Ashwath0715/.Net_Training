using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class XYZ : IWork
    {
        public void Add()
        {
            Console.WriteLine("I am from XYZ class");
        }
        public int Calc()
        {
            int sum;
            sum = 10;
            return sum;
        }
    }
}
