using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public abstract class Person
    {
        private int _id;
        private string _name;
        private string _phone;

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Phone { get; protected set; }
        public Person()
        {

        }

        public Person(int id, string name, string phone)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
        }

        public virtual void GetPersonDetails()
        {
            Console.WriteLine($"ID: {_id}\nNavn: {_name}\nTelefonnummer: {_phone}");
        }
        public override string ToString()
        {
            return ($"ID: {_id}\nNavn: {_name}\nTelefonnummer: {Phone}\n");
        }
    }
}
