using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Entre driver name: ");
            string driverName = Console.ReadLine();
            Console.Write("Entre drive experience: ");
            var driveExperience = int.Parse(Console.ReadLine());

            Car car = new Car(carModel);
            Driver driver = new Driver(driverName, driveExperience);

            Console.WriteLine("Car model: {0}.", car.GetModel());
            Console.WriteLine("Driver name: {0}.", driver.GetName());
            Console.WriteLine("Driver experience: {0}.", driver.GetDriveExperience());
        }
    }
}
