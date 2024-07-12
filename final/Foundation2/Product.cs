public class Product
{
    private string _name;
    private int _prodNumber;
    private double _price;
    private int _quantity;

    //constructor
    public Product(string name, int number, double price, int quantity)
    {
        _name = name;
        _prodNumber = number;
        _price = price;
        _quantity = quantity;
    }

    //methods
    public string GetName()
    {
        return _name;
    }

    public int GetNumber()
    {
        return _prodNumber;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }
}