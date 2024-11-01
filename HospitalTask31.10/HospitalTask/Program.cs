namespace HospitalTask;

class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();
        bool flag = true;

        while (flag)
        {
            Console.WriteLine("1. Appointment yarat");
            Console.WriteLine("2. Appointment-i bitir");
            Console.WriteLine("3. Bütün appointment-lərə bax");
            Console.WriteLine("4. Bu həftəki appointment-lərə bax");
            Console.WriteLine("5. Bugünki appointment-lərə bax");
            Console.WriteLine("6. Bitməmiş appointmentlərə bax");
            Console.WriteLine("7. Menudan çıx");
            Console.Write("Seçiminizi edin: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Xəstə adı: ");
                    string patientName = Console.ReadLine();
                    Console.Write("Həkim adı: ");
                    string doctorName = Console.ReadLine();
                    Console.Write("Başlama tarixi (yyyy-MM-dd HH:mm): ");
                    DateTime startDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Bitmə tarixi (yyyy-MM-dd HH:mm): ");
                    DateTime endDate = DateTime.Parse(Console.ReadLine());
                    Patient patient = new Patient(patientName);
                    Doctor doctor = new Doctor(doctorName);
                    Appointment appointment = new Appointment(patient, doctor, startDate, endDate);
                    hospital.AddAppointment(appointment);
                    Console.WriteLine("Appointment uğurla əlavə edildi.");
                    break;
                
                case "2":
                    try
                    {
                        Console.Write("Bitirmek istədiyiniz appointmentin nömrəsini daxil edin: ");
                        int no = int.Parse(Console.ReadLine());
                        hospital.EndAppointment(no);
                        Console.WriteLine("Appointment bitdi.");
                    }
                    catch (CustomAppointmentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "3":
                    List<Appointment> allAppointments = hospital.GetAllAppointments();
                    foreach (var app in allAppointments)
                    {
                        Console.WriteLine($"Appointment No: {app.No}, Xəstə: {app.Patient.Name}, Həkim: {app.Doctor.Name}");
                    }
                    break;

                case "4":
                    List<Appointment> weeklyAppointments = hospital.GetWeeklyAppointments();
                    foreach (var app in weeklyAppointments)
                    {
                        Console.WriteLine($"Appointment No: {app.No}, Xəstə: {app.Patient.Name}, Həkim: {app.Doctor.Name}");
                    }
                    break;

                case "5":
                    List<Appointment> todaysAppointments = hospital.GetTodaysAppointments();
                    foreach (var app in todaysAppointments)
                    {
                        Console.WriteLine($"Appointment No: {app.No}, Xəstə: {app.Patient.Name}, Həkim: {app.Doctor.Name}");
                    }
                    break;

                case "6":
                    List<Appointment> continuingAppointments = hospital.GetAllContinuingAppointments();
                    foreach (var app in continuingAppointments)
                    {
                        Console.WriteLine($"Appointment No: {app.No}, Xəstə: {app.Patient.Name}, Həkim: {app.Doctor.Name}");
                    }
                    break;

                case "7":
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Doğru dəyər daxil edin.");
                    break;
            }
        }
    }
}