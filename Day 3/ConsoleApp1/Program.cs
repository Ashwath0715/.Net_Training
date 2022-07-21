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
            int n, r, result = 0, temp;
            Console.Write("Enter the Number to check: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                result = (result * 10) + r;
                n = n / 10;
            }
            if (temp == result)
                Console.WriteLine("It is a Pallindrome number");
            else
                Console.WriteLine("It is not a Pallindrome number");
                Console.ReadLine();
        }

        //int temp, sum = 0,num, rem;
        //    Console.Write("Enter the Number To Check :");  
        //    num = int.Parse(Console.ReadLine());

        //    temp = num;  
        //    while (num > 0)  
        //    {  
        //        rem = num % 10;  
        //        sum =sum+(rem* rem* rem);
        //        num= num/ 10;  
        //    }  
              
        //    if (temp == sum)  
        //        Console.Write(temp + " Is A Armstrong Number");  
        //    else  
        //        Console.Write(temp + " Is Not A Armstrong Number");  
               
        //}
        
    }  
                
    }
 

