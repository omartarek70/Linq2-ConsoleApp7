namespace LinqAssignment;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public override string ToString() =>
        $"#{ProductID,-3} {ProductName,-28} {Category,-12} ${UnitPrice,7:F2}  Stock: {UnitsInStock}";
}

public class Order
{
    public int OrderID { get; set; }
    public decimal Total { get; set; }
}

public class Customer
{
    public string CustomerID { get; set; }
    public string CompanyName { get; set; }
    public string Country { get; set; }
    public List<Order> Orders { get; set; } = new();
}
