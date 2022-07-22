using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbagecollection_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGCCollectClass myGCCol = new MyGCCollectClass();

            Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);

            myGCCol.MakeSomeGarbage();
            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            GC.Collect(0);

            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));

            GC.Collect(0);

            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            GC.Collect(2);

            Console.WriteLine("Generation: {0}", GC.GetGeneration(myGCCol));

            Console.WriteLine("Total Memory: {0}", GC.GetTotalMemory(false));
            Console.Read();
        }
    }
}
