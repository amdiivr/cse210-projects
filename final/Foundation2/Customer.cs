using System;

public class Customer
{
    private string nameCustomer;

    public string GetNameCustomer()
    {
        return nameCustomer;
    }

    public void GetName(string name)
    {
        nameCustomer = name;
    }

    public void DisplayFullName()
    {
        Console.WriteLine($"\nName of Customer: {nameCustomer}");
    }

}