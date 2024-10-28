namespace MeetingManager;

public class WrongDateIntervalException:Exception
{   
    public WrongDateIntervalException():base("Tarixlər doğru daxil edilməyib."){}
}