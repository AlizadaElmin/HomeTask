namespace SongRating;

public class Song
{
    private string _name;
    private string _genre;
    public Singer singer;
    public float[] ratings;
    
    public Song()
    {
        ratings = new float[0];
    }

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

    public string Genre
    {
        get
        {
            return _genre;
        }
        set
        {
            string[] genres = { "Pop", "Rock", "Jazz", "Techno" };
            if(genres.Contains(value))
            {
                _genre = value;
            }
            else
            {
                Console.WriteLine("Genre yalnız Pop, Rock, Jazz və ya Techno ola bilər.");
            }
        }
    }

    public void AddRating(float rating)
    {
        if (0 <= rating && rating <= 5)
        {
            int length = ratings.Length;
            Array.Resize(ref ratings, length + 1);
            ratings[length] = rating;
        }
        else
        {
            Console.WriteLine("Rating dəyəri doğru daxil edilməyib.(0-5)");
        }
    }

    public float GetAverageRating()
    {
        float ratingSum = 0;
        float result = 0;
        if (ratings.Length == 0)
        {
            return 0;
        }
        foreach (float rating in ratings)
        {
            ratingSum += rating;
        }

        result = ratingSum / ratings.Length;
        return result ;
    }

}