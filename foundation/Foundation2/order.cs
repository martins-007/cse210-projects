using System;
using System.Collections.Generic;

public class Order
{
    // Private member variables
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add products to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order
    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost based on customer's location
        if (_customer.IsInUSA())
        {
            totalCost += 5; // USA shipping cost
        }
        else
        {
            totalCost += 35; // International shipping cost
        }

        return totalCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
