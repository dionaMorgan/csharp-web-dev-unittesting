using System;

namespace CarNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);
            Console.WriteLine(car.GasTankLevel);
            car.Drive(100);
            car.AddGas(5);
            Console.WriteLine(car.GasTankLevel);
        }
    }
}
