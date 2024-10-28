namespace MeetingManager;

public class MeetingSchedule
{
    public Meeting[] meetings;

    public MeetingSchedule()
    {
        meetings = new Meeting [0];
    }
    public void SetMeeting(string fullName, DateTime fromDate, DateTime toDate)
    {
        if (fromDate >= toDate)
        {
            throw new WrongDateIntervalException();
        }
        for (int i = 0; i < meetings.Length; i++)
        {   
            if (toDate > meetings[i].FromDate && fromDate < meetings[i].ToDate)
            {
                throw new ReservedDateIntervalException();
            }
        }
        Array.Resize(ref meetings,meetings.Length+1);
        meetings[meetings.Length - 1] = new Meeting(fromDate, toDate, fullName);
     
    }
}