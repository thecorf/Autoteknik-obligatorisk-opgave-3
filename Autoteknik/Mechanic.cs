using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Mechanic : Person
    {
        protected string education;
        public Mechanic() : base()
        {

        }

        public Mechanic(int id, string name, string phone, string education) : base(id, name, phone)
        {
            this.education = education;
        }

        public void GetMechanicDetails()
        {
            GetPersonDetails();
            Console.WriteLine($"Speciale: {education}");
        }

        public override string ToString()
        {
            return $"\nNavn: {Name}\nID: {Id}\nTelefonnummer: {Phone}\nSpeciale: {education}\n";
        }
    }
}
