public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;
    private double _productPrice;

    public Product(string name, int productId, double price, int quantity)
    {
        _name=name;
        _productId=productId;
        _price=price;
        _quantity=quantity;
        _productPrice= _price*_quantity;
    }

    public int GetProductID()
    {
        return _productId;
    }
    public string GetProductName()
    {
        return _name;
    }
    public double GetProductPrice()
    {
        return _productPrice;
    }
}