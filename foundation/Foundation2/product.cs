public class Product
{
    // Private member variables
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate total cost for this product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getters for packing label
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
}
