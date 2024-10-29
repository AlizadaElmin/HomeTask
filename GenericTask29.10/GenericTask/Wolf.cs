namespace GenericTask;

public class Wolf: Animal
{
    public bool IsPrideLeader { get; set; }
    public int  AttackDamage { get; set; }

    public Wolf(bool isPrideLeader,int attackDamage,int hp):base(hp)
    {
        IsPrideLeader = isPrideLeader;
        AttackDamage = attackDamage;
    }

    public void Hunt<T>(T animal) where T : Animal
    {
        animal.HP -= AttackDamage;
        Console.WriteLine($"Currently health:{animal.HP}");
    }
}