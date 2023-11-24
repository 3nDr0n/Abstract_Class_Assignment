class Program
{
    static void Main()
    {
        // Instantiate an Employee object with firstName “Sample” and lastName “Student”
        Employee employee = new Employee
        {
            FirstName = "Alexander",
            LastName = "Magyar"
        };

        // Call the SayName() method on the Employee object
        employee.SayName();
    }
}