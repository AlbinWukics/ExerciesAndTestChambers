using OOP_FORTS_v._38;

var carClass = new CarClass() { TopSpeed = 200, NumberOfDoors = 5 };
var mcClass = new MotorcycleClass() { TopSpeed = 250 , HandleBarType = "Bock" };
var vehicleClass = new VehicleClass() { TopSpeed = 100 };

VehicleClass[] vehicles = new VehicleClass[3];
vehicles[0] = carClass;
vehicles[1] = mcClass;
vehicles[2] = vehicleClass;

for (int i = 0; i < vehicles.Length; i++)
{
	if (vehicles[i] is CarClass car)
	{
		car.NumberOfDoors = 3;
		Console.WriteLine(car.NumberOfDoors);
	}

	if (vehicles[i] is MotorcycleClass mc)
	{
		Console.WriteLine(mc.HandleBarType);
	}

	Console.WriteLine(vehicles[i].TopSpeed);
}