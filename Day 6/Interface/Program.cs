using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IACT
    {
        void network();
    }

    class ABC : IWork, IACT, ICommunication
    {
        public void Add()
        {
            Console.WriteLine(" I am IWork interface");
        }

        public int Calc()
        {
            int result;
            result = 55;
            return result;
        }

        public void CNN()
        {
            throw new NotImplementedException();
        }

        public void network()
        {
            Console.WriteLine(" I am IWork interface");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ABC obj = new ABC();
            obj.Add();
            obj.Calc();
            obj.network();
            XYZ objx = new XYZ();
            objx.Calc();
            objx.Add();

        }
    }
}
