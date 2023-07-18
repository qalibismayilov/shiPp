using System;

class Transport
{
    public string Name { get; set; }
}

class Vehicle : Transport
{
    public int Wheels { get; set; }
}

class Car : Vehicle
{
    public int Doors { get; set; }
}

class Airplane : Vehicle
{
    public int Wingspan { get; set; }
}

class Ship : Vehicle
{
    public int Length { get; set; }
}

class VehicleController
{
    public void ControlVehicle(Vehicle vehicle)
    {
        Console.WriteLine($"Control {vehicle.Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car { Name = "Car", Wheels = 4, Doors = 4 };
        Airplane airplane = new Airplane { Name = "Airplane", Wheels = 6, Wingspan = 30 };
        Ship ship = new Ship { Name = "Ship", Wheels = 0, Length = 100 };

        VehicleController controller = new VehicleController();
        controller.ControlVehicle(car);
        controller.ControlVehicle(airplane);
        controller.ControlVehicle(ship);
    }
}
