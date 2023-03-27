using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Foundation2 World!");

        Console.WriteLine("\n_____________First Order_____________");
        Product firstProduct = new Product();
        firstProduct.GetInfoProduct("Milk", 1254);
        firstProduct.GetTotalPrice(11.2, 10);
        
        Product secondProduct = new Product();
        secondProduct.GetInfoProduct("Egg", 1464);
        secondProduct.GetTotalPrice(18.20, 15);
        
        Customer firstCustomer = new Customer();
        firstCustomer.GetName("Andy Vasquez");
        Address firstAddress = new Address();

        Order firstOrder = new Order();
        firstOrder.listProduct.Add(firstProduct);
        firstOrder.listProduct.Add(secondProduct);
        firstOrder.listCustomer.Add(firstCustomer);
        firstOrder.GetPackingLabel();
        firstOrder.GetShippingLabel();

        firstAddress.GetFullAddress("1959 NE 153 ST", "North Miami", "Florida", "USA");
        firstAddress.GetInfoUSA();
        firstProduct.DisplayTotalPrice(5);
        secondProduct.DisplayTotalPrice(5);

        // Second Order // 
        Console.WriteLine("\n_____________Second Order_____________");

        Product thirdProduct = new Product();
        thirdProduct.GetInfoProduct("Soda", 1145);
        thirdProduct.GetTotalPrice(5.5, 10);
        
        Product fourthProduct = new Product();
        fourthProduct.GetInfoProduct("Apple", 1230);
        fourthProduct.GetTotalPrice(2.5, 30);
        
        Customer SecondCustomer = new Customer();
        SecondCustomer.GetName("Antonella Hidalgo");
        Address secondAddress = new Address();

        Order SecondOrder = new Order();
        SecondOrder.listProduct.Add(firstProduct);
        SecondOrder.listProduct.Add(secondProduct);
        SecondOrder.listCustomer.Add(firstCustomer);
        SecondOrder.GetPackingLabel();
        SecondOrder.GetShippingLabel();

        secondAddress.GetFullAddress("Av. Jose Carlos Mariategui", "El agustino", "Lima", "Perú");
        secondAddress.GetInfoUSA();
        thirdProduct.DisplayTotalPrice(35);
        fourthProduct.DisplayTotalPrice(35);

    }
}