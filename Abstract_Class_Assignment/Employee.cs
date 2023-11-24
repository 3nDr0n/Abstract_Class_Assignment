// Define the Employee class, inheriting from Person
using System;

public class Employee : Person
{
    // Implementation of the abstract method from the base class
    public override void SayName()
    {
        Console.WriteLine($"Employee's Name: {FirstName} {LastName}");
        Console.ReadLine(); 
    }
}
