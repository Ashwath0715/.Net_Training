using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] c = { 45, 10, 59, 78, 4 };
            //Array.Reverse(c);
            //Console.WriteLine("Reverse order");
            //for (int i = 0; i < c.Length; i++)
            //{

            //    Console.WriteLine(c[i] + " ");
            //}

            int[] arr = new int[50];
            int i, j, n, temp;
            Console.WriteLine("Enter the no");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            for (i = 0; i < n; i++)
            {
                arr[i]=int.Parse(Con)
            }






            //int[] arr = new int[100];
            //int i, j, num, count = 0;

            //Console.WriteLine("Enter size of the array: ");
            //num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter elements in the array: ");
            //for (i = 0; i < num; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (i = 0; i < num; i++)
            //{
            //    for (j = i + 1; j < num; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("\n Duplicate elements found in array:" + count);
            //Console.ReadLine();








            //int[] a1 = new int[] { 3, 1, 4, 9,5 };
            //int[] a2 = new int[a1.Length];

            //for (int i = 0; i < a1.Length; i++)
            //{
            //    a2[i] = a1[i];
            //}

            //Console.WriteLine("original array: ");
            //for (int i = 0; i < a1.Length; i++)
            //{
            //    Console.Write(a1[i] + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("new array: ");
            //for (int i = 0; i < a2.Length; i++)
            //{
            //    Console.Write(a2[i] + " ");
            //}






            int[] a = new int[100];
            int i, n, sum = 0;

            Console.Write("Input the number of elements");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}
