/*
Clyde Balaman
IT102 - OOP

In this example, the IVehicle interface defines a contract with a Start method that all vehicle types must implement.

1. Car and Motorcycle classes implement the IVehicle interface, each providing its own version of the Start method.
2. This design allows new vehicle types to be added by creating new classes that implement the IVehicle interface, without modifying the existing code for other vehicle types.

This demonstrates the Open/Closed Principle by ensuring the code is open for adding new types of vehicles but closed for modifying the existing code.
*/

public interface IVehicle
{
    void Start();
}

public class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }
}

public class Motorcycle : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Motorcycle started.");
    }
}
