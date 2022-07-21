using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globalinterface
{
    interface IACT
    {
        void network();
    }
    interface IGlobal
    {
        void Network();
    }

    class ABC : IACT, IGlobal
    {

        public void Network()
        {
            Console.WriteLine(" I am from class ABC");
        }

        void IACT.network()
        {
            Console.WriteLine(" I am from IACT");
        }

        void IGlobal.Network()
        {
            Console.WriteLine(" I am from Gloabl");
        }


        class Program
        {
            static void Main(string[] args)
            {
                ABC obj = new ABC();
                obj.Calc();
                obj.Network();
                IGlobal obj2 = new ABC();
                obj2.Network();
                IACT objAct = new ABC();
                objAct.network();


            }
        }

        private void Calc()
        {
            throw new NotImplementedException();
        }
    }
}
