using System;
using System.Linq;

class Product
{
    public int ProductId { get; }
    public string ProductName { get; }
    public string Category { get; }

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }

    public override string ToString()
    {
        return $"Product [ID={ProductId}, Name={ProductName}, Category={Category}]";
    }
}

class ProductSearch
{
    public static Product LinearSearch(Product[] products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] products, int targetId)
    {
        int left = 0, right = products.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (products[mid].ProductId == targetId)
                return products[mid];
            else if (products[mid].ProductId < targetId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }
}

class Program
{
    static void Main()
    {
        Product[] products = {
            new Product(101, "Laptop", "Electronics"),
            new Product(205, "Sneakers", "Footwear"),
            new Product(150, "Smartphone", "Electronics"),
            new Product(120, "Backpack", "Accessories"),
            new Product(180, "Watch", "Accessories")
        };

        Console.Write("Enter Product ID to search: ");
        int searchId;
        while (!int.TryParse(Console.ReadLine(), out searchId))
        {
            Console.Write("Invalid input. Please enter a valid Product ID: ");
        }

        // Linear Search
        Product foundLinear = ProductSearch.LinearSearch(products, searchId);
        Console.WriteLine(foundLinear != null 
            ? $"Linear Search: {foundLinear}" 
            : "Linear Search: Product not found.");

        // Sort for Binary Search
        var sortedProducts = products.OrderBy(p => p.ProductId).ToArray();

        // Binary Search
        Product foundBinary = ProductSearch.BinarySearch(sortedProducts, searchId);
        Console.WriteLine(foundBinary != null 
            ? $"Binary Search: {foundBinary}" 
            : "Binary Search: Product not found.");
    }
}
