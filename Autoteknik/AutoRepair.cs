using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    internal class AutoRepair
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Mechanic Mechanic { get; set; }
        static int TempRepairID = 1;

        static int GenRepairID()
        {
            return TempRepairID++;
        }
        public AutoRepair()
        {
            Id = GenRepairID();
        }

        public AutoRepair(string description, double price, Mechanic mechanic)
        {
            Id = GenRepairID();
            Description = description;
            Price = price;
            Mechanic = mechanic;
        }

        public override string ToString()
        {
            return $"Reperations ID: {Id}\nHvad der skal fixes: {Description}\nPris: {Price} kr.\nLaves af: {Mechanic}";
        }
    }
}

