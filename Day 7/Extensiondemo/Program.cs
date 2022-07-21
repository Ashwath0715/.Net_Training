using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensiondemo
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if(!string.IsNullOrEmpty(inputstring))
            {
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
        public static int Addition(int a,int b)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string myWord = "Welcome to training";
            int wordCount = myWord.GetWordCount();

            //
            Console.WriteLine("string:" + myWord);
            Console.WriteLine("count: " + wordCount);
            Console.ReadLine();
        }
    }
}

//call by ref

class Program
{
    public static string GetNextName(ref int id)
    {
        string returnText = "Next-" + id.ToString();
        id += 1;
        return returnText;
    }
    static void Main(string[] args)
    {
        int i = 1;
        Console.WriteLine("Previous value of integer i:+ i.ToString()");
        string test = GetNextName(ref i);
        Console.WriteLine("Current value of integer i: + i.ToString()");
    }
}