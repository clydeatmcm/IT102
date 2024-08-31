/*
Clyde Balaman
IT102

Here, both Car and ElectricCar can replace Vehicle without changing how the Move method is used.
*/

public class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("Vehicle moving.");
    }
}

public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car driving.");
    }
}

public class ElectricCar : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Electric car driving.");
    }
}
