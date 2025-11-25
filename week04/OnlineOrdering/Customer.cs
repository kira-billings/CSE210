
using System.Reflection.Metadata.Ecma335;

class Customer
{
    private string _customerName;
    private Address _address = new Address();

    public Customer()
    {
        
    }
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;     
    }

    public bool IsInUSA()
    {
        if (_address.GetCountry() == "USA")
            return true;
        else 
            return false;
    }
    public string GetCustomerName()
    {
       return _customerName;
    }
}