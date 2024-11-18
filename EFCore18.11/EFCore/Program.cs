using EFCore.Context;
using EFCore.Functions;
using EFCore.Models;

namespace EFCore;

class Program
{
    static void Main(string[] args)
    {
        UserService userService = new UserService();
        while (true)
        {
            Console.WriteLine("1. Register\n2. Login");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    userService.Register();
                    break;
                case 2:
                    userService.Login();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
} 