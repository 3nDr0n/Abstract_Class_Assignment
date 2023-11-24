using System;

// Create Employee class, inheriting from Person and adding IQuittable interface
public class Employee : Person, IQuittable
{
    // Adding the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} is quitting the job.");
    }

    // Adding SayName Method
    public override void SayName()
    {
        Console.WriteLine($"Employee's Name: {FirstName} {LastName}");
    }
}
