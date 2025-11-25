
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private Address _address;
    
    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
        _products = new List<Product>();
    }
       
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

public string GetPackingLabel()
{
    string label = "Packing Label:\n";

    foreach (Product p in _products)
    {
        label += $"{p.GetProductName()} (ID: {p.GetProductID()})\n";
    }

    return label;
}
    public string GetShippingLabel()
    {
        return $"\nShipping Label:\n{_customer.GetCustomerName()}\n{_address.GetAddress()}\n";
    }
    public double GetShippingCost()
    {
        
        if (_customer.IsInUSA() is true)
        {
            return 5.00;
        }
        else return 35.00;
    }
    public double GetTotalProductCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetProductCost();
        }
        return total;
    }
    public double GetTotalOrderCost()
    {
        return GetTotalProductCost() + GetShippingCost();
    }
}