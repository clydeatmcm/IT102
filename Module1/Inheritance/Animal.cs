/*
Clyde Balaman
IT102 - OOP

Here's a C# code example demonstrating the relationship where a Pug is a Dog, and a Dog is an Animal, showing inheritance for better modeling and code reuse.

In this code snippet:
- Animal is the base class.
- Dog inherits from Animal and adds its own behavior.
- Pug inherits from Dog and adds its own behavior, demonstrating how inheritance allows for better modeling and code reuse.
*/

// Base class
public class Animal
{
    public string Name { get; set; }
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Derived class
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

// Further derived class
public class Pug : Dog
{
    public void Snore()
    {
        Console.WriteLine($"{Name} is snoring.");
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        Pug myPug = new Pug { Name = "Buddy" };
        myPug.Eat();  // Inherited from Animal
        myPug.Bark(); // Inherited from Dog
        myPug.Snore(); // Specific to Pug
    }
}
