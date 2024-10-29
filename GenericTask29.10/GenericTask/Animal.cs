namespace GenericTask;
public abstract class Animal
{
    public int AvgLifeTime { get; set; }
    public Gender Gender { get; set; }
    public string Breed { get; set; }
    public int HP { get; set; }

    public Animal(int hp)
    {
        HP = hp;
    }
}