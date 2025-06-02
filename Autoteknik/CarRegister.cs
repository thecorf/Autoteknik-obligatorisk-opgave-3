namespace Autoteknik
{
    internal class CarRegister
    {
        public string Name { get; set; }
        public int Cvr { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void DeleteCar(Car car)
        {
            Cars.Remove(car);
        }

        public void AddRepairToCar(AutoRepair ar, string nummerplade)
        {
            foreach (var car in Cars)
            {
                if (car.RegNo == nummerplade)
                    car.AddAutoRepair(ar);
            }
            //Cars.Find(c => c.RegNo == nummerplade).AddAutoRepair(ar);
        }

        public override string ToString()
        {
            return $"\nNavn på Værksted: {Name}\nCVR: {Cvr}\nBiler i Værksted:\n";
        }
    }
}
