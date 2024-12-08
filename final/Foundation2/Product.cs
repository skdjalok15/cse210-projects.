using System;

public class Product
{
    private string name;
    private string productId;
    private float price;
    private int quantity;
    private float discount;

    public Product(string name, string productId, float price, int quantity, float discount = 0)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
        this.discount = discount;
    }

    public float GetTotalCost()
    {
        float totalCost = price * quantity;
        if (discount > 0)
        {
            totalCost -= totalCost * (discount / 100);
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId}) - Quantity: {quantity}";
    }
}
