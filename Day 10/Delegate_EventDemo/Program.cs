using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Delegate_EventDemo
{
    //custom delegate
    public delegate void DelEventHandler();

    class Program : Form
    {
        public event DelEventHandler add;
        public Program()
        {
            //Design a button over form
            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Hit Me";
            btn.Location = new Point(100, 100);

            //Event handler is assigned to
            // the button click event
            btn.Click += new EventHandler(onClick);
            add += new DelEventHandler(Initiate);
            //invoke the event 
            add();
        }
        //call when event is fired

        public void Initiate()
        {
            Console.WriteLine("Event Initiated");
        }
        //call when button clicked
        public void onClick(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked me");
        }
        static void Main(string[] args)
        {
            Application.Run(new Program());
            Console.ReadLine();
        }
    }   
}
