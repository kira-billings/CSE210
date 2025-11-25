
class Address
{
    private string _street;
    private string _city;
    private string _country;

    public Address()
    {
        
    }

    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _country = country;
    }

    public string GetAddress()
    {
        string text = $"{_street}\n{_city}\n{_country}";
        return text;
    }
    public string GetCountry()
    {
        string text = $"{_country}";
        return text;
    }
}