public class Order
{
    private List<Product> _productsList=new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer=customer;
    }
    public void AddAProduct(string name, int productId, double price, int quantity)
    {
        Product product=new Product(name,productId,price,quantity);
        _productsList.Add(product);
    }
    public void DisplayTotalPrice()
    {
        double total=0;
        int shippingFee=0;
        foreach(Product product in _productsList)
        {
            total=total+product.GetProductPrice();
        }
        if(_customer.LivesInTheUSA()==true)
        {
            shippingFee=5;
        }
        else
        {
            shippingFee=35;
        }
        Console.WriteLine($"SubTotal: ${total}, Shipping fee: ${shippingFee}");
        total=total+shippingFee;
        Console.WriteLine($"Total: ${total}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        foreach(Product product in _productsList)
        {
            Console.WriteLine($"Product Name {product.GetProductName()} - Product ID {product.GetProductID()}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"Name: {_customer.GetCustomerName()} - Address: {_customer.GetCustomerStringAddress()}");
    }



}