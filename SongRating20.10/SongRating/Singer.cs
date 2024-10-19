namespace SongRating;

public class Singer
{
    private string _name;
    private string _surname;
    private int _age;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (0< value.Length && value.Length <= 100)
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Ad uzunluğu 100-dən çox ola bilməz.");
            }
        }
    }

    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (0<value.Length && value.Length <= 100)
            {
                _surname = value;
            }
            else
            {
                Console.WriteLine("Soyad uzunluğu 100-dən çox ola bilməz.");
            }
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (0< value && value <= 170)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Yaş doğru deyil.");
            }
        }
    }
}