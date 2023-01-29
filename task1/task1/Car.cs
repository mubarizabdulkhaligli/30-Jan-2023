using System;
namespace task1
{
	internal class Car : Vehicle
	{
		public double FuelCapacity;
		public double CurrentFuel;
		

		public void AddFuel(double fuel)
		{
			if (fuel >= 0)
			{

				if (CurrentFuel + fuel <= FuelCapacity)
				{
					CurrentFuel += fuel;
					Console.WriteLine($"Added {fuel} liters of fuel; \n Current fuel: {CurrentFuel} liters");
				}
				else if (CurrentFuel + fuel > FuelCapacity)
				{
					if (CurrentFuel == FuelCapacity)
					{
						Console.WriteLine("The fuel tank is full");
					}
					else if (CurrentFuel != FuelCapacity)
					{
                        Console.WriteLine($"Added {FuelCapacity - CurrentFuel} liters of fuel. The fuel tank is full");

                        CurrentFuel = FuelCapacity;
                    }
				}
			}
			else Console.WriteLine("You entered a negative value");
        }
	}
}

