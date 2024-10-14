namespace ClassFirstTask;

class Program
{
    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product("15 pro", "Iphone", 1700),
            new Product("14 pro", "Iphone", 1500),
            new Product("13 pro", "Iphone", 1300),
            new Product("12 pro", "Iphone", 1100),
        };
        CheckPrice(products,1000,2000);
    }

    static void CheckPrice(Product[] products, double minPrice, double maxPrice)
    {
        foreach (Product product in products)
        {
            if (minPrice <= product.Price && product.Price <= maxPrice)
            {
                Console.WriteLine($"Məhsul {product.Name} dəyəri {product.Price}");
            }
        }
    }
}