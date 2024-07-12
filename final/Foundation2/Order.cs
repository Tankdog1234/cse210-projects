using System.Diagnostics;

public class Order
{
    private List<Product> _cart;
    private Customer _customer;

    //constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _cart = new List<Product>();
    }

    //methods
    public void AddToCart(Product product)
    {
        _cart.Add(product);
    }

    public double GetPrice()
    {
        double p = 0;
        foreach(Product product in _cart)
        {
            p += product.GetTotalCost();
        }
        if(_customer.IsUSA() == true)
        {
            p += 5;
        }
        else
        {
            p += 35;
        }
        return p;
    }

    public string GetPackingLabel()
    {
        string label = "ID:\tQuantity:\tProduct Name:\n";
        foreach(Product product in _cart)
        {
            label += $"{product.GetNumber()}\t{product.GetQuantity()}\t{product.GetName()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Customer Name:\tCustomer Address:\n";
        label += $"{_customer.GetName()}\t{_customer.GetAddress()}\n";
        return label;
    }
}