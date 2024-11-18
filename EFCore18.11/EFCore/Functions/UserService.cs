using EFCore.Context;
using EFCore.Exceptions;
using EFCore.Models;

namespace EFCore.Functions;

public class UserService
{
    public void Register()
    {
        using (AppDbContext context = new AppDbContext())
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            
            if (context.Users.Any(u => u.Username == username))
            {
                throw new UsernameInUse("Username already taken");
            }
          
            User newUser = new()
            {
                Name = name,
                Surname = surname,
                Username = username,
                Password = password
            };

            context.Users.Add(newUser);
            context.SaveChanges();
            Console.WriteLine("User created");
        }
    }

    public void Login()
    {
        using (AppDbContext context = new AppDbContext())
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            
            User user = context.Users.FirstOrDefault(u=>u.Username == username && u.Password == password);

            if (user == null)
            {
                throw new UserNotFoundException("Invalid username or password");
            }
            Menu(user);
        }
    }

    public void Menu(User user)
    {
        bool isActive = true;
        while (isActive)
        {
            Console.WriteLine("1.Məhsullara bax.\n2. Səbətə bax.\n3. Hesabdan çıx.");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    AllProducts(user);
                    break;
                case 2:
                    BasketMenu(user);
                    break;
                case 3:
                    isActive = false;
                    break;
            }
        }
    }

    public void AllProducts(User user)
    {
        using (AppDbContext context = new AppDbContext())
        {
            var products = context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}.{product.Name}-{product.Price}");
            }

            Console.WriteLine("Enter id for add product to your basket: (0 go back)");
            int selectedProductId = Convert.ToInt32(Console.ReadLine());
            if (selectedProductId == 0) return;
            Product selectedProduct = context.Products.FirstOrDefault(p => p.Id == selectedProductId);
            if (selectedProduct == null)
            {
                throw new ProductNotFoundException("Product not found");
            }

            Basket newBasket = new()
            {
                ProductId = selectedProduct.Id,
                UserId = user.Id
            };
            context.Baskets.Add(newBasket);
            context.SaveChanges();
            Console.WriteLine("Product added to your basket.");
        }
    }

    public void BasketMenu(User user)
    {
        using (AppDbContext context = new AppDbContext())
        {
            var baskets = context.Baskets.Where(b => b.UserId == user.Id).ToList();
            
            
            foreach (var basket in baskets)
            {
               Product product = context.Products.FirstOrDefault(p => p.Id == basket.ProductId);
               Console.WriteLine($"{product.Id}.{product.Name}-{product.Price}");
            }

            Console.WriteLine("Enter id for delete product from your basket:");
            int productId = Convert.ToInt32(Console.ReadLine());
            var basketItem = baskets.FirstOrDefault(b => b.ProductId == productId);

            if (basketItem == null)
            {
                throw new ProductNotFoundException("Product not found");
            }
            context.Baskets.Remove(basketItem);
            context.SaveChanges();
            Console.WriteLine("Product deleted from your basket.");
        }
    }
}