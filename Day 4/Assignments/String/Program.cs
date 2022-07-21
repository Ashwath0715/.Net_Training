using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();

            // a.padding();

            //a.equal();

           // a.removereplace();

           // a.trim();

            a.upperlower();

            //a.containsandcovert();
        }


        #region removereplace
        private void removereplace()
        {
            //using Remove

            string str1 = "Aniket";
            str1 = str1.Remove(0, 3);  
            Console.WriteLine(str1);

            //Using Replace

            string str2 = "kavin prakash";
            Console.WriteLine(str2);
            string str3 = str2.Replace("kavin", "alok");
            Console.WriteLine(str3);


            Console.ReadKey();
        }
        #endregion


        #region Paddingleftright
        private void padding()
        {
            string str1 = "Aakash";
            str1 = str1.PadLeft(30);
            Console.WriteLine(str1);


            string str3 = "Nagpur";
            char padWith = '#';
            Console.WriteLine(str3.PadLeft(15, padWith));

            Console.ReadKey();

        }
        #endregion


        #region checkequal
        private void equal()
        {
            string city1 = "Mumbai";
            string city2 = "Mumbai";
            string city3 = "Pune";

            // Compare strings using String.Equals  
            if (string.Equals(city1, city2))
                Console.WriteLine($"{city1} and {city2} are same city.");
            else
                Console.WriteLine($"{city1} and {city2} are different.");

            if (string.Equals(city1, city3))
                Console.WriteLine($"{city1} and {city3} are same city.");
            else
                Console.WriteLine($"{city1} and {city3} are different.");

            Console.ReadKey();

        }
        #endregion


        #region trimend
        private void trim()
        {
            string[] str1 = new string[] { "There are different string method", "yes" };

            foreach (string item in str1) 
            {
                Console.WriteLine(item);
            }

            foreach (string item in str1)  
            {

                string trimmed = item.TrimEnd('d', 's');
                Console.WriteLine(trimmed);

            }
        }
        #endregion


        #region upperlowercase
        private void upperlower()
        {
            string name = "flower";
            if (!string.IsNullOrEmpty(name))
            {
                name = char.ToUpper(name[0]) + name.Substring(1);
            }
            Console.WriteLine($"First letter uppercase: {name} ");

            string sport = "VIRAT KOHLI";
            string updatedName = sport.Substring(0, 7).ToUpper() + sport.Substring(7).ToLower();
            Console.WriteLine(updatedName);
        }
        #endregion


        #region containsandconvert
        private void containsandcovert()
        {
            string tofind = "Sunflower is YELLOW";
            bool isContains = tofind.Contains("Red");
            Console.WriteLine(isContains);

            string toconvert = "Sunflower is YELLOW";
            char[] charArray = toconvert.ToCharArray();
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }


        }
        #endregion
    }
}
