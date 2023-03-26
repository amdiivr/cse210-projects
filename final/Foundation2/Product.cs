using System;

public class Product
{
    private string name;
    private double price;
    private int idProduct;
    private int quantity;

    private int costShipping;

    public string GetName()
    {
        return name;
    }
    public double GetPrice()
    {
        return price;
    }
    public int GetIdProduct()
    {
        return idProduct;
    }
    public int GetQuantity()
    {
        return quantity;
    }

    public void GetInfoProduct(string nameProduct, int idProductNumber)
    {
        name = nameProduct;
        idProduct = idProductNumber;
    }

    public void GetTotalPrice(double priceProduct, int quantityProducts)
    {
        price = priceProduct;
        quantity = quantityProducts;
    }

    public void DisplayInfoProduct()
    {
        Console.WriteLine($"\nName Product: {name}\nID Product: {idProduct}"); 
    }

    public double DisplayTotalPrice(int cost)
    {
        costShipping = cost;
        Console.WriteLine($"\nThe total price is: {price * quantity}");
        Console.WriteLine($"The total price with shipping is: {(price * quantity) + cost}");
        return price;
    }
}