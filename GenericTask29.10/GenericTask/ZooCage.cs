namespace GenericTask;

public class ZooCage<T, U> 
    where T: Animal
    where U: Food, new()
{
    public T Animal { get; set; }
    public U Food { get; set; }
    
}