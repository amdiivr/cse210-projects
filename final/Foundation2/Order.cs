using System;

public class Order
{
    public List<Customer> listCustomer = new List<Customer>();
    public List<Product> listProduct = new List<Product>();

    public void GetPackingLabel()
    {
        Console.WriteLine("\nPacking Label:");

        foreach(Product shipping in listProduct)
        {
            shipping.DisplayInfoProduct(); 
        }

    }

    public void GetShippingLabel()
    {
        Console.WriteLine("\nShipping Label:");

        foreach(Customer packing in listCustomer)
        {
            packing.DisplayFullName();
        }
    }
}