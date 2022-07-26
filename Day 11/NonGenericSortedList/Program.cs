using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            //Adding
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");
            //Displaying
            //foreach
            foreach(DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            //for
            for(int i=0;i< sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));

            }
            //Index
            Console.WriteLine(sortedList[5].ToString());
            //Capcity
            Console.WriteLine(sortedList.Count);
            //Remove
            sortedList.Remove(1);
            foreach(DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            //Contains
            Console.WriteLine(sortedList.ContainsValue("Apr"));

            //Copy to ArrayList
            Console.WriteLine("Now we are inside the array list");
            ArrayList array = new ArrayList(sortedList.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
