using System.Diagnostics;

namespace Autoteknik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mechanic mechanic1 = new Mechanic(1, "Jakob", "12345678", "Bremsemand");
            CarRegister carRegister = new CarRegister();
            Car car1 = new Car();
            Car car2 = new Car("BJ69420", 2015, "Ford", "Focus", 69420);
            Car car3 = new Car("AB12345", 2025, "Polestar", "Model Q", 200);
            carRegister.AddCar(car1);
            carRegister.AddCar(car2);
            carRegister.AddCar(car3);
            car3.Owner = new Owner(1, "Ove Ovesen", "87654321", "Hr." );
            car1.AddAutoRepair(new AutoRepair("bremseklods fucked", 200.50, new Mechanic(1, "Jakob", "12345678", "Bremsemand")));
            car1.AddAutoRepair(new AutoRepair("bremseklods ígen fucked", 200.50, mechanic1));
            car1.AddAutoRepair(new AutoRepair("bremseklods unfucked", 200.50, mechanic1));
            car1.AddAutoRepair(new AutoRepair("bremseklods gigafucked igen", 200.50, mechanic1));
            carRegister.AddRepairToCar(new AutoRepair("bremseklods unfucked", 200, mechanic1),"BJ69420");

            foreach (Car car in carRegister.Cars)
            {
                Console.WriteLine(car);
            }
            Debug.WriteLine(carRegister + "test");
            Console.WriteLine("Den samlede pris for reperationer for Car1 er: " + car1.TotalAutoRepairCost() + "kr.");
            Console.WriteLine(mechanic1);
            Console.WriteLine(car3);

            //Eksempel på en thrown exception
            //Car car3 = new Car("mere end 7 karakterer som nummerplade", 2015, "Ford", "Focus", 69420);
        }
    }
}
