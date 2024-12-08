using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const float taxRate = 0.07f; // 7% tax

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public float CalculateTotal()
    {
        float total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        // Apply tax
        total += total * taxRate;

        // Add shipping cost
        total += customer.IsInUSA() ? 5 : 35;
        
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetShippingLabel()}";
    }

    public string GetEstimatedDelivery()
    {
        return customer.IsInUSA() ? "Estimated Delivery: 3-5 days" : "Estimated Delivery: 7-10 days";
    }
}
