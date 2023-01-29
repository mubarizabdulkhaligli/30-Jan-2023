using System;

namespace task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();


			car.Brand = "Toyota";
			car.Model = "Prius";
			car.Mileage = 10000;
			car.FuelCapacity = 43;

			car.CurrentFuel = 23;

			car.AddFuel(-10);
            car.AddFuel(0);
            car.AddFuel(20);
            car.AddFuel(15);
        }
	}
}

