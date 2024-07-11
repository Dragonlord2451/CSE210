using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        total += shippingCost;

        return total;
    }

    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in products)
        {
            label.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return label.ToString();
    }

    public string ShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address}";
    }
}
