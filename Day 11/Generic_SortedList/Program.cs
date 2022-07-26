using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            SortedList List = new SortedList();
            SortedList<string, string> phoneBook = new SortedList<string, string>();

            //Adding 
            phoneBook.Add("Jack", "821452631");
            phoneBook.Add("Willy", "941241766");
            phoneBook.Add("Charles", "9540120315");
            phoneBook.Add("Jennifer", "621450139");
            phoneBook.Add("James", "2012321458");
         

            //Displaying
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + ", Roll no is" + item.Value);
            }

            //Index
            phoneBook["Jack"] = "1234521648";
            Console.WriteLine(phoneBook["Jack"]);

            //TryGetValue
            phoneBook.TryGetValue("James", out string number);
            Console.WriteLine(number);

            //Remove
            Console.WriteLine("----------------");
            Console.WriteLine("After Removing");
            phoneBook.Remove("Willy");
            phoneBook.RemoveAt(1);
            foreach(var item in phoneBook)
            {
                Console.WriteLine(item.Key);
            }
            //Remove all
            Console.WriteLine(phoneBook.Count);
            //phoneBook.Clear();
            //Console.WriteLine(PhoneBook.Count);
            //Contains
            Console.WriteLine(phoneBook.ContainsValue("0131189915"));
        }
    }
}
