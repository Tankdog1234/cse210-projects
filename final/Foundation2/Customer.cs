public class Customer
{
    private string _name;
    private Address _address;

    //constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //methods
    public bool IsUSA()
    {
        return _address.IsUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}