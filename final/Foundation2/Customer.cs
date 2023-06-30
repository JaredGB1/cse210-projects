public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name=name;
        _address=address;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerStringAddress()
    {
       return _address.GetFullAddress();
    }
    public bool LivesInTheUSA()
    {
        return _address.IsInTheUSA();
    }
}