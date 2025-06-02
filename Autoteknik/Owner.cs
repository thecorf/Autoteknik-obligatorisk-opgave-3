using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Autoteknik
{
    public class Owner : Person
    {
        protected string title;
        public Owner() : base()
        {

        }

        public Owner(int id, string name, string phone, string title) : base(id, name, phone)
        { 
            this.title = title;
        }

        public override string ToString()
        {
            return ($"Navn: {title}. {Name}\nID: {Id}\nTelefonnummer: {Phone}");
        }
    }
}
