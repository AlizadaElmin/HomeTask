namespace FullName;

class Program
{
    static void Main(string[] args)
    {
    }

    static string FullName(string name)
    {
        return name;
    }
    static string FullName(string name, string surname)
    {
        return surname + " " + name;
    }
    static string FullName(string name, string surname,string fatherName)
    {
        return name[0] + "." + surname + " "+ fatherName;
    }
}

