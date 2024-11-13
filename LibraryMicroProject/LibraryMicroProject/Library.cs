using Newtonsoft.Json;

namespace LibraryMicroProject;

public class Library
{
    private static int _id;
    public int Id { get; }
    public string Name { get; set; }
    public List<Book> Books;
    public string path;
    public Library()
    {
        Id = ++_id;
        Books = new List<Book>();
        path = "/Users/elmin/RiderProjects/LibraryMicroProject/LibraryMicroProject/database.json";
    }

    public void AddBook(Book book)
    {
        if (Books.Contains(book))
        {
            throw new Exception("Book exists");
        }
        Books.Add(book);
        string newBooks = JsonConvert.SerializeObject(Books);
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(newBooks);
        }
        
    }
    
    public Book GetBookById(int id)
    {
        StreamReader sr = new StreamReader(path);
        string json = sr.ReadToEnd();
        Books = JsonConvert.DeserializeObject<List<Book>>(json);
        Book book = Books.Find(book => book.Id == id);
        if (book == null)
        {
            throw new Exception("Book doesn't founded");
        }
        return book;
    }
    public void RemoveBook(int id)
    {
        Book book = Books.Find(book => book.Id == id);
        if (book == null)
        {
            throw new Exception("Book doesn't founded");
        }

        StreamReader sr = new StreamReader(path);
        string json = sr.ReadToEnd();
        Books = JsonConvert.DeserializeObject<List<Book>>(json);
        Books.Remove(book);
        string newBooks = JsonConvert.SerializeObject(Books);
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine(newBooks);
        }
    }
}