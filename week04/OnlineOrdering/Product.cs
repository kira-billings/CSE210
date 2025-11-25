
class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product ()
    {
        
    }
    
    public Product(string productName, string productID)
    {
        _productName = productName;
        _productID = productID;
    }

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    
    public double GetProductCost()
    {
        return _price * _quantity;
    }

    public string GetProductID()
    {
        return _productID;
    }
    public string GetProductName()
    {
        return _productName;
    }
}