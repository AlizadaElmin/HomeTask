namespace MeetingManager;

public class ReservedDateIntervalException:Exception
{
    public ReservedDateIntervalException():base("Bu tarixlərə daha əvvəl meeting təyin olunub."){}
}