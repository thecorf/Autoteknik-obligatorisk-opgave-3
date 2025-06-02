using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Autoteknik
{
    internal class Car
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public Owner Owner { get; set; }
        public Dictionary<int, AutoRepair> Repairs { get; set; }

        static int TempCarID = 1;
        static int GenCarID()
        {
            return TempCarID++;
        }
        public Car() 
        {
            Id = GenCarID();
            RegNo = "PLACEHOLDER";
            Repairs = new Dictionary<int, AutoRepair>();

        }

        public Car(string regNo, int year, string make, string model, int mileage)
        {
            Id = GenCarID();
            if (regNo.Length == 7)
                RegNo = regNo;
            else
                throw new ArgumentException("Nummerplade er ikke 7 karakterer");
            Year = year;
            Make = make;
            Model = model;
            Mileage = mileage;
            Repairs = new Dictionary<int, AutoRepair>();
        }
        
        public void AddAutoRepair(AutoRepair ar)
        {
            Repairs.Add(ar.Id, ar);
        }
        public double TotalAutoRepairCost()
        {
            double price = 0;
            foreach (AutoRepair ar in Repairs.Values)
            {
                price += ar.Price;
            }
            return price;
        }
        

        public override string ToString()
        {
            if (Repairs.Count != 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var ar in Repairs)
                {
                    sb.Append(ar.Value.ToString());
                }
                return $"ID: {Id}\nMærke: {Make}\nModel: {Model}\nProduktions år: {Year}\nKilometer antal: {Mileage}\nNummerplade: {RegNo}\nReperationer:\n{sb}\nejer: {Owner}\n";
            }
            return $"ID: {Id}\nMærke: {Make}\nModel: {Model}\nProduktions år: {Year}\nKilometer antal: {Mileage}\nNummerplade: {RegNo}\nejer: {Owner}\n";
        }
    }
}
