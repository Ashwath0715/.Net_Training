using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates_Demo
{
    class Myclass
    {
        public static bool IsDate(string date)
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);
        }
        public static int Multi(int a,int b)
        {
            return a + b;
        }
        public static void sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public static void add(string fname, string lname)
        {
            string fullname = fname + " " + lname;
            Console.WriteLine(fullname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Action Delegate
            Action<int, int> a = new Action<int, int>(Myclass.sum);
            a(15, 16);
            Action<string, string> b = new Action<string, string>(Myclass.add);
            b("Rahul", "Bangalore");

            //Func Delegate
            Func<int, int, int> ds = new Func<int, int, int>(Myclass.Multi);
            Console.WriteLine(ds(45, 65));

            //Predicate Delegate
            Predicate<string> p = new Predicate<string>(Myclass.IsDate);
            if (p("10-06-2022"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}
