using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_task
{

    class MyException : Exception
    {
        public void MyExcep()
        {
            Console.WriteLine("Not enough quantity available");
        }
    }
    class Furniture
    {
        int orderId;
        string orderDate;
        public string furnitureType;
        int quantity;
        int totalAmt;
        string paymentMode;

        public void GetData()
        {
            try
            {
                Console.WriteLine("OrderId :");
                orderId = int.Parse(Console.ReadLine());
                Console.WriteLine("orderDate :");
                orderDate = Console.ReadLine();
                Console.WriteLine("furnitureType :");
                furnitureType = Console.ReadLine();
                Console.WriteLine("quantity :");

                quantity = int.Parse(Console.ReadLine());
                if (quantity > 50)
                {
                    throw new MyException();
                }
                Console.WriteLine("TotalAmt :");
                totalAmt = int.Parse(Console.ReadLine());
                Console.WriteLine("payment mode");
                paymentMode = Console.ReadLine();
            }
            catch (MyException ep)
            {
                ep.MyExcep();
            }
}    }   } 
