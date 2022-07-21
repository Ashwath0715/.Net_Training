using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    public abstract class Myclass
    {
        public void aa()
        {
            Console.WriteLine("This is not abstrct method ");
        }
        public abstract void calculate(double x);
    }
    class Sub1 : Myclass
    {
        public override void calculate(double x)
        {
            base.aa();
            Console.WriteLine("SQUARE ROOT IS" + Math.Sqrt(x));
        }
    }
    public class Sub2 : Myclass
    {
        public override void calculate(double x)
        {
            base.aa();
            Console.WriteLine("SQUARE IS" + (x * x));
        }
    }

    public class Sub3 : Myclass
    {
        public override void calculate(double x)
        {
            base.aa();
            Console.WriteLine("CubeE IS" + (x * x * x));
        }
    }
    public class Sub4 : Myclass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("Multi IS" + (x * x * x * x));
        }
    }
    class Program
    {
        static void main(string[] args)
        {
            Sub1 obj1 = new Sub1();
            Sub1 temp2 = new Sub1();
            Sub2 obj2 = new Sub2();
            Sub3 obj3 = new Sub3();
            obj1.calculate(9);
            obj2.calculate(9);
            //obj2.sum(12,78)
            obj3.calculate(9);



        }

    }

   
}
