namespace MeetingManager;

public class Meeting
{
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string FullName { get; set; }

    public Meeting(DateTime fromDate, DateTime toDate,string fullName)
    {
        FromDate = fromDate;
        ToDate = toDate;
        FullName = fullName;
    }
}