using System;

class Program
{
    static void Main()
    {
        // Instantiate an Employee object with firstName and lastName
        Employee employee = new Employee
        {
            FirstName = "Alexander",
            LastName = "Magyar"
        };

        // Call the SayName() method on the Employee object to display the name
        employee.SayName();

        // Using polymorphism to create an object of type IQuittable and calling the Quit() method on it
        IQuittable quittableEmployee = employee;
        quittableEmployee.Quit();
        Console.ReadLine();
    }
}