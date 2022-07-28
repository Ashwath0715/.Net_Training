using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DelegateEvent_task
{
    class Program
    {

        static void Main(string[] args)
        {
            Name n = new Name();
            n.en_BannedUser += WarningAlarm;
            n.User();
            Console.Read();
        }
        static void WarningAlarm(object sender, BannedUserEvent e)
        {
            Console.WriteLine("{0}, Sending Email to Administration.", e.Name);
            Console.WriteLine("Warning Alarm Started......");

        }
        public class BannedUserEvent
        {
            public BannedUserEvent(string s)
            {
                Name = s;
            }
            public string Name
            {
                get;
                set;
            }
        }

        public class Name
        {
            public event EventHandler<BannedUserEvent> en_BannedUser;
            public void User()
            {
                Console.Write("Enter Name : ");
                string userName = Console.ReadLine();

                if ((userName == "Ram" || userName == "Sham" || userName == "Naveen"))
                {
                    en_BannedUser(this, new BannedUserEvent(userName));
                }
                else
                {
                    Console.WriteLine("Welcome to " + userName);
                }
            }
        }

    }
}

