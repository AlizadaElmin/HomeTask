namespace HospitalTask;

public class CustomAppointmentException:Exception
{
    public CustomAppointmentException():base()
    {
    }

    public CustomAppointmentException(string message):base(message)
    {
        
    }
}