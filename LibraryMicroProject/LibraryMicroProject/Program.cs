namespace LibraryMicroProject;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Get book by id");
            Console.WriteLine("3. Remove book");
            Console.WriteLine("0. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string author = Console.ReadLine();
                    Book newBook = new Book { Title = title, AuthorName = author };
                    library.AddBook(newBook);
                    Console.WriteLine("Book added successfully!\n");
                    break;

                case "2":
                    Console.Write("Enter book id: ");
                    int getId = int.Parse(Console.ReadLine());

                    Book book = library.GetBookById(getId);
                    Console.WriteLine($"Book found: {book.Title} by {book.AuthorName}\n");
                    break;

                case "3":
                    Console.Write("Enter book id to remove: ");
                    int id = int.Parse(Console.ReadLine());

                    library.RemoveBook(id);
                    Console.WriteLine("Book removed successfully!\n");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }
}