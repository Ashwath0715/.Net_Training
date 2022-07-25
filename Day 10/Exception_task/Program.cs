using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_task
{
    class Furniture
    {
        int orderId;
        string orderDate;
        string furnitureType;
        int quantity;
        int totalAmt;
        string paymentMode;
        
        public void GetData()
        {
            Console.WriteLine("OrderId:");
            orderId = int.Parse(Console.ReadLine());
            Console.WriteLine("OrderDate:");
            orderDate = Console.ReadLine();
            Console.WriteLine("OrderType:");
            furnitureType = Console.ReadLine();
            Console.WriteLine("Quantity:");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("TotalAmount:");
            totalAmt = int.Parse(Console.ReadLine());
            Console.WriteLine("payment mode:");
            paymentMode = Console.ReadLine();

        }
        static void Main(String[] args)
        {
            Furniture f = new Furniture();
            f.GetData();
                        
        }

    }

}