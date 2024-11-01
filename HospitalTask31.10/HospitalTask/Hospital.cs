namespace HospitalTask;

public class Hospital
{
    public List<Appointment> Appointments = new();

    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
    }

    public void EndAppointment(int no)
    {
        Appointment appointment = Appointments.Find(a => a.No == no);
        if (appointment == null)
        {
            throw new CustomAppointmentException("Appointment not found");
        }

        appointment.EndDate = DateTime.Now;
    }

    public Appointment GetAppointment(int no)
    {
        Appointment appointment = Appointments.Find(a => a.No == no);
        if (appointment == null)
        {
            throw new CustomAppointmentException("Appointment not found.");
        }
        return appointment;
    }

    public List<Appointment> GetAllAppointments()
    {
        return Appointments;
    }

    public List<Appointment> GetWeeklyAppointments()
    {
        List<Appointment> weeklyAppointments = Appointments.FindAll(a => DateTime.Now.AddDays(-7) < a.StartDate);
        return weeklyAppointments;
    }
    public List<Appointment> GetTodaysAppointments()
    {
        List<Appointment> todaysAppointments = Appointments.FindAll(a => DateTime.Now.Date == a.StartDate.Date);
        return todaysAppointments;
    }
    
    public List<Appointment> GetAllContinuingAppointments()
    {
        List<Appointment> continuingAppointments = Appointments.FindAll(a =>a.EndDate ==null || DateTime.Now < a.EndDate);
        return continuingAppointments;
    }
}