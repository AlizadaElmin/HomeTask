namespace HospitalTask;

public class Appointment
{
    private static int _no; 
    public int No { get;}
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Appointment(Patient patient,Doctor doctor,DateTime startDate,DateTime endDate)
    {
        No = ++_no;
        Patient = patient;
        Doctor = doctor;
        StartDate = startDate;
        EndDate = endDate;
    }

}