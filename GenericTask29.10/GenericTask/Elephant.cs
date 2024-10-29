namespace GenericTask;

public class Elephant:Animal
{
    public double Weight { get; set; }
    public bool IsTrained { get; set; }

    public Elephant(int hp):base(hp) { }
}