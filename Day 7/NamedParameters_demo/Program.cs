using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the static method with named
            //parameters without any order
            addstr(s2: " is trained", s1: " Aswath", s3: " for .Net");
        }

        public static void addstr(string s1,string s2,string s3)
        {
            string result = s1 + s2 + s3;
            Console.WriteLine("Final String is: " + result);
            Console.ReadLine();
        }
    }

}
