/*
Clyde Balaman
IT102 - OOP

Each class has a single responsibility: managing vehicle data, handling maintenance, or managing registration. This separation makes the code easier to maintain and extend.
1. Vehicle: Manages the vehicle's data and displays its details.
2. VehicleMaintenance: Handles scheduling maintenance for the vehicle.
3. VehicleRegistration: Manages the registration of the vehicle.
*/

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    // Responsible for storing vehicle details
    public void DisplayDetails()
    {
        Console.WriteLine($"Vehicle: {Make} {Model} ({Year})");
    }
}

public class VehicleMaintenance
{
    // Responsible for maintaining vehicle
    public void ScheduleMaintenance(Vehicle vehicle)
    {
        Console.WriteLine($"Maintenance scheduled for {vehicle.Make} {vehicle.Model}.");
    }
}

public class VehicleRegistration
{
    // Responsible for vehicle registration
    public void RegisterVehicle(Vehicle vehicle)
    {
        Console.WriteLine($"Vehicle {vehicle.Make} {vehicle.Model} registered.");
    }
}
