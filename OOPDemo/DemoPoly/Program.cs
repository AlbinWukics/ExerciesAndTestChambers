using DemoPoly;

var car = new Car();
var mc = new Motorcycle();

var vehicles = new List<Vehicle>();
vehicles.Add(car);
vehicles.Add(mc);

car.TopSpeed = 200;
car.NumberOfDoors = 4;

mc.TopSpeed = 200;
mc.HandlebarStyle = "Normal";

foreach (var v in vehicles)
{
    v.MakeSound();
    v.PrintTopSpeed();
    v.PrintInfo();
}