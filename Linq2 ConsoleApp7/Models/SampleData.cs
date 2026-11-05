namespace LinqAssignment;

public static class SampleData
{
    public static List<Product> Products => new()
    {
        new() { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
        new() { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
        new() { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 13 },
        new() { ProductID = 4, ProductName = "Chef Anton's Cajun", Category = "Condiments", UnitPrice = 22.00m, UnitsInStock = 53 },
        new() { ProductID = 5, ProductName = "Grandma's Boysenberry", Category = "Condiments", UnitPrice = 25.00m, UnitsInStock = 120 },
        new() { ProductID = 6, ProductName = "Uncle Bob's Pears", Category = "Produce", UnitPrice = 30.00m, UnitsInStock = 15 },
        new() { ProductID = 7, ProductName = "Northwoods Cranberry", Category = "Condiments", UnitPrice = 40.00m, UnitsInStock = 6 },
        new() { ProductID = 8, ProductName = "Mishi Kobe Niku", Category = "Meat", UnitPrice = 97.00m, UnitsInStock = 29 },
        new() { ProductID = 9, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00m, UnitsInStock = 31 },
        new() { ProductID = 10, ProductName = "Queso Cabrales", Category = "Dairy", UnitPrice = 21.00m, UnitsInStock = 22 },
        new() { ProductID = 11, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.00m, UnitsInStock = 24 },
        new() { ProductID = 12, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 },
        new() { ProductID = 13, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.50m, UnitsInStock = 39 },
        new() { ProductID = 14, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.45m, UnitsInStock = 29 },
        new() { ProductID = 15, ProductName = "Alice Mutton", Category = "Meat", UnitPrice = 39.00m, UnitsInStock = 0 },
        new() { ProductID = 16, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.50m, UnitsInStock = 42 },
        new() { ProductID = 17, ProductName = "Teatime Chocolate", Category = "Confections", UnitPrice = 9.20m, UnitsInStock = 25 },
        new() { ProductID = 18, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.00m, UnitsInStock = 40 },
        new() { ProductID = 19, ProductName = "Gorgonzola Telino", Category = "Dairy", UnitPrice = 12.50m, UnitsInStock = 0 },
        new() { ProductID = 20, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.40m, UnitsInStock = 123 },
        new() { ProductID = 21, ProductName = "Mascarpone Fabioli", Category = "Dairy", UnitPrice = 32.00m, UnitsInStock = 9 },
        new() { ProductID = 22, ProductName = "Tarte au sucre", Category = "Confections", UnitPrice = 49.30m, UnitsInStock = 17 },
        new() { ProductID = 23, ProductName = "Rhönbräu Klosterbier", Category = "Beverages", UnitPrice = 7.75m, UnitsInStock = 125 },
        new() { ProductID = 24, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.50m, UnitsInStock = 17 }
    };

    public static List<Customer> Customers => new()
    {
        new() { CustomerID = "ALFKI", CompanyName = "Alfreds Futterkiste", Country = "Germany", Orders = new() { new() { OrderID = 1, Total = 814.50m }, new() { OrderID = 2, Total = 878.00m } } },
        new() { CustomerID = "ANATR", CompanyName = "Ana Trujillo Emparedados", Country = "Mexico", Orders = new() { new() { OrderID = 3, Total = 320.00m } } },
        new() { CustomerID = "ANTON", CompanyName = "Antonio Moreno Taquería", Country = "Mexico", Orders = new() { new() { OrderID = 4, Total = 660.00m }, new() { OrderID = 5, Total = 403.20m } } },
        new() { CustomerID = "AROUT", CompanyName = "Around the Horn", Country = "UK", Orders = new() { new() { OrderID = 6, Total = 1200.00m } } },
        new() { CustomerID = "BERGS", CompanyName = "Berglunds snabbköp", Country = "Sweden", Orders = new() { new() { OrderID = 7, Total = 450.75m } } },
        new() { CustomerID = "BLAUS", CompanyName = "Blauer See Delikatessen", Country = "Germany", Orders = new() { new() { OrderID = 8, Total = 150.00m } } },
        new() { CustomerID = "BONAP", CompanyName = "Bon app'", Country = "France", Orders = new() { new() { OrderID = 9, Total = 980.00m }, new() { OrderID = 10, Total = 210.00m } } },
        new() { CustomerID = "EASTC", CompanyName = "Eastern Connection", Country = "UK", Orders = new() { new() { OrderID = 11, Total = 530.00m } } }
    };
}