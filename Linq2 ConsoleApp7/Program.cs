using LinqAssignment;

namespace Linq2_ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            var products = SampleData.Products;
            var customers = SampleData.Customers;

            void Header(string title) => Console.WriteLine($"\n===== {title} =====");


            Header("1. Top 3 most expensive products");
            products.OrderByDescending(p => p.UnitPrice).Take(3).ToList().ForEach(Console.WriteLine);


            Header("2. Page 2 (page size = 5)");
            int pageNumber = 2, pageSize = 5;
            products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList().ForEach(Console.WriteLine);


            Header("3. TakeWhile UnitPrice < $25 (ordered by price)");
            products.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25).ToList().ForEach(Console.WriteLine);

        
            Header("4. Are ALL Seafood products in stock?");
            bool allSeafoodInStock = products.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            Console.WriteLine(allSeafoodInStock);


            Header("5. ids contains 9?");
            int[] ids = { 3, 9, 13, 18 };
            Console.WriteLine(ids.Contains(9));

  
            Header("6. Group by Category + count");
            foreach (var g in products.GroupBy(p => p.Category))
            {
                Console.WriteLine($"{g.Key}: {g.Count()} products");
                foreach (var p in g) Console.WriteLine($"   - {p.ProductName}");
            }

       
            Header("7. Group by Category -> product names only");
            var namesByCategory = products
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName).ToList() });
            foreach (var g in namesByCategory)
                Console.WriteLine($"{g.Category}: {string.Join(", ", g.Names)}");

    
            Header("8. Categories with more than 3 products");
            products.GroupBy(p => p.Category)
                    .Where(g => g.Count() > 3)
                    .Select(g => g.Key).ToList()
                    .ForEach(Console.WriteLine);

   
            Header("9. Customers by Country (query syntax)");
            var customersByCountry =
                from c in customers
                group c by c.Country into g
                select new
                {
                    Country = g.Key,
                    Count = g.Count(),
                    TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
                };
            foreach (var x in customersByCountry)
                Console.WriteLine($"{x.Country,-8} Count: {x.Count}  TotalOrderValue: {x.TotalOrderValue:C}");

            Header("10. Total units in stock");
            Console.WriteLine(products.Sum(p => p.UnitsInStock));

     
            Header("11. Cheapest & most expensive price");
            Console.WriteLine($"Cheapest: {products.Min(p => p.UnitPrice):C}");
            Console.WriteLine($"Most expensive: {products.Max(p => p.UnitPrice):C}");

            Header("12. Distinct categories");
            products.Select(p => p.Category).Distinct().ToList().ForEach(Console.WriteLine);

   
            Header("13. setA except setB");
            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            int[] setB = { 3, 6, 9, 12, 15, 13 };
            Console.WriteLine(string.Join(", ", setA.Except(setB)));

  
            Header("14. list1 except list2 (case-insensitive)");
            string[] list1 = { "Germany", "France", "UK", "Spain" };
            string[] list2 = { "france", "SPAIN", "Italy" };
            Console.WriteLine(string.Join(", ", list1.Except(list2, StringComparer.OrdinalIgnoreCase)));

   
            Header("15. Dictionary<int, Product>, ID = 18");
            Dictionary<int, Product> productDict = products.ToDictionary(p => p.ProductID);
            Console.WriteLine(productDict[18]);


            Header("16. First product with price > $50");
            Console.WriteLine(products.First(p => p.UnitPrice > 50));

          
            Header("17. First product with price > $500 (FirstOrDefault)");
            var expensive = products.FirstOrDefault(p => p.UnitPrice > 500);
            Console.WriteLine(expensive == null ? "null (no product found)" : expensive.ToString());

         
            Header("18. Multiplication table for 7");
            Enumerable.Range(1, 10).Select(i => $"7 x {i,2} = {7 * i}").ToList().ForEach(Console.WriteLine);

            Header("19. Even numbers between 1 and 30");
            Console.WriteLine(string.Join(", ", Enumerable.Range(1, 30).Where(n => n % 2 == 0)));

            Header("20. Concat product names + customer company names");
            var combined = products.Take(3).Select(p => p.ProductName)
                .Concat(customers.Take(3).Select(c => c.CompanyName));
            combined.ToList().ForEach(Console.WriteLine);

       
            Header("21. Zip products with customers");
            products.Zip(customers, (p, c) => $"{p.ProductName} sold to {c.CompanyName}")
                    .ToList().ForEach(Console.WriteLine);
        }
    }
}
