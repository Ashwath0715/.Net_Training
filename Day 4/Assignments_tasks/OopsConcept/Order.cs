using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Order
    {
        public string Laptop { get; set; }
        public string Ram { get; set; }
        public string Generation { get; set; }

        public string CreateOrder()
        {
            validateRam();
            validateGeneration();
            return "Order Created";
        }
        private bool validateRam()
        {
            return true;
        }
        private bool validateGeneration()
        {
            return true;
        }
    }
}
