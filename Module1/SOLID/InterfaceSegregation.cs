/*
Clyde Balaman
IT102 - OOP

In this code, IVehicle includes only vehicle-specific methods, ensuring that classes implementing it focus solely on vehicle functionality.
*/

public interface IVehicle
{
    void Start();
    void Stop();
}

public class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }
}
