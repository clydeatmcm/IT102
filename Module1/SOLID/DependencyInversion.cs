/*
Clyde Balaman
IT102 - OOP

In this code snippet, Vehicle depends on the ILogger interface, making it easy to switch to a different logging method without changing the Vehicle class.
*/

public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class Vehicle
{
    private readonly ILogger _logger;

    public Vehicle(ILogger logger)
    {
        _logger = logger;
    }

    public void Start()
    {
        _logger.Log("Vehicle started.");
    }
}
