using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_04_listas_ejercicio_01
{
    internal class MyNode
    {
        // Attributes
        private string name;
        private string surname;
        private string address;
        private string tel;
        private MyNode next;

        // Constructors
        public MyNode(string name, string surname, string address, string tel, MyNode next)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Tel = tel;
            Next = next;
        }
        public MyNode(string name, string surname, string address, string tel) : this(name, surname, address, tel, null) { }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public MyNode Next
        {
            get { return next; }
            set { next = value; }
        }

        // Methods
    }
}
