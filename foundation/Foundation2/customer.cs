public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Getters for the shipping label
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}
