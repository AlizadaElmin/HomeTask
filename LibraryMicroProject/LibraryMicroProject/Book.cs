namespace LibraryMicroProject;

public class Book
{
    private static int _id;
    public int Id { get; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public decimal Price { get; set; }
    public string Title { get; set; }


    public Book()
    {
        Id = ++_id;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id} Name: {Name} Author: {AuthorName} Price: {Price}");
    }

}