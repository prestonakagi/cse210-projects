public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetFullName()
    {
        return _name;
    }

    public string GetFullAddress()
    {
        return _address.FullAddress();
    }

    public bool CheckUSA()
    {
        return _address.LiveInUSA();
    }
}