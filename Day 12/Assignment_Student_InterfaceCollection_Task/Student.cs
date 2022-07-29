using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_InterfaceCollection_Task
{
    class Student
    {
        string _id;
        string _name;
        byte _age;
        byte _standard;
        string _address;

        public Student(string id,string name,byte age,byte standard,string address)
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._standard = standard;
            this._address = address;
        }

        public void SetID(String id)
        {
            this._id = id;
        }
        public String GetID()
        {
            return this._id;
        }

        public void SetAge(byte age)
        {
            this._age = age;
        }
        public byte GetAge()
        {
            return this._age;
        }

        public void SetStandard(byte standard)
        {
            this._standard = standard;
        }
        public byte GetStandard()
        {
            return this._standard;
        }
        public void SetAddress(String address)
        {
            this._address = address;
        }
        public String Getaddress()
        {
            return this._address;
        }

        internal string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
