using System;
using System.Linq;

class EcommerceSearchFunction

{
    static void Main()
    {
        Product[] products = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Footwear"),
            new Product(3, "Watch", "Accessories"),
            new Product(4, "Camera", "Electronics"),
            new Product(5, "Mobile", "Electronics")
        };

        
        Product[] sortedProducts = products.OrderBy(p => p.ProductName).ToArray();

        string searchName = "Watch";

        Console.WriteLine("Linear Search:");
        Product result1 = LinearSearch(products, searchName);
        DisplayResult(result1);

        Console.WriteLine("\nBinary Search:");
        Product result2 = BinarySearch(sortedProducts, searchName);
        DisplayResult(result2);

        Console.WriteLine("\nAnalysis:");
        Console.WriteLine("Linear Search Time Complexity: O(n)");
        Console.WriteLine("Binary Search Time Complexity: O(log n)");
        Console.WriteLine("Binary Search is faster for large sorted data.");
    }

    static Product LinearSearch(Product[] products, string name)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }
        return null;
    }

    static Product BinarySearch(Product[] products, string name)
    {
        int low = 0, high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int compare = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

            if (compare == 0)
                return products[mid];
            else if (compare < 0)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void DisplayResult(Product product)
    {
        if (product != null)
        {
            Console.WriteLine($"Product Found: {product.ProductName}, Category: {product.Category}");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}
