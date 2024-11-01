namespace HospitalTask;

public class Patient
{
    private static int _id;
    public int Id { get;}
    public string Name { get; set; }

    public Patient(string name)
    {
        Id = ++_id;
        Name = name;
    }
}