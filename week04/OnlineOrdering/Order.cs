public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>(){};

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {

    }

    public double TotalPrice()
    {
        return 1.2; // stub
    }

    public int ShippingCost()
    {
        return 10; // stub
    }

    public string PackingLabel()
    {
        return "product name and id and \n"; // stub
    }

    public string ShippingLabel()
    {
        return "Customer name and address"; // stub
    }
}