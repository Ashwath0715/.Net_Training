using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ContactInfo
    {

        string _address;
        string _city;
        string _state;
         string _country;
         string _phoneno;
        string _mobileno;
        string _emailid;
        ContactInfo(string address, string city, string state, string country, string phoneno, string mobileno, string emailid)
        {
            this._address = address;
            this._city = city;
            this._state = state;
            this._country = country;
            this._phoneno = phoneno;
            this._mobileno = mobileno;
            this._emailid = emailid;
        }
        //property
        public string Address()
        {
            get { return _address; }
            set { _address = value;}
        }
        public string City()
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State()
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Country()
        {
            get { return _country; }
            set { _country = value; }
        }

        public string Phoneno()
        {
            get { return _phoneno; }
            set { _phoneno = value; }
        }

        public string mobileno()
        {
            get { return _mailid; }
            set { _mailid = value; }
        }

        public string emailid()
        {
            get { return _mailid; }
            set { _mailid = value; }
        }



        public void createContact(string address, string city, string state, string country, string phoneno, string mobileno, string emailid)
        {
           
            {

                ContactInfo p=new ContactInfo
            
            }
        }
    }
}
