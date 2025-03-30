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
        _products.Add(product);
    }

    public double TotalPrice()
    {
        // total cost of each product + ShippingCost()
        double runningTotalCost = 0;
        foreach (Product product in _products)
        {
            runningTotalCost += product.TotalCost();
        }
        
        return runningTotalCost + ShippingCost();
    }

    public int ShippingCost()
    {
        // use Customer.CheckUSA()
        if (_customer.CheckUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string PackingLabel()
    {
        string productsInfo = "";
        foreach (Product product in _products)
        {
            productsInfo += (product.GetProductName() + $", product ID: {product.GetProductId()}\n");
        }

        return productsInfo;
        // return "product name and id and \n"; // stub
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetFullName()}\n{_customer.GetFullAddress()}";
        // return "Customer name and address"; // stub
    }
}