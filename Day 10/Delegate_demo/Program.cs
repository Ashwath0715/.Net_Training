using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_demo
{
    public delegate string FirstDelegate(int x);
    class Program
    {
        string name;
        static string StaticMethod(int i)
        {
            return string.Format("Static Method: {0}", i);
        }
        string InstanceMethod(int i)
        {
            return string.Format("{0}: {1}", name, i);
        }
        public void SumMethod()
        {

        }
        static void Main(string[] args)
        {
            FirstDelegate d1 = new FirstDelegate(Program.StaticMethod);

            Program instance = new Program();
            instance.name = "My instance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);
            Console.WriteLine(d1(10));  //static output
            Console.WriteLine(d2(5));   //Instance output
            Console.ReadLine();
        }
    }
}
