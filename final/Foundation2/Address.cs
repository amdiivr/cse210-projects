using System;

public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public string GetFullAddress(string streetName, string cityName, string stateName, string countryName)
    {
        street = stateName;
        city = cityName;
        state = stateName;
        country = countryName;

        string fullAddress = ($"Address: {stateName} - {cityName}/{stateName}/{countryName}");
        Console.WriteLine(fullAddress);
        return fullAddress;
    }

    public string GetInfoUSA()
    {
        if(country == "USA")
        {
            Console.WriteLine("This address live in the USA");
        }
        else
        {
            Console.WriteLine("This address not live in the USA");
        }
        return country;

    }
}