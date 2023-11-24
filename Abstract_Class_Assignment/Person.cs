using System;

// Create abstract class called Person
public abstract class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Creating SayName method
    public abstract void SayName();
}
