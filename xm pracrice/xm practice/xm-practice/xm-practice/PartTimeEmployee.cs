namespace xm_practice;

public class PartTimeEmployee:Employe
{
    public float HourlyRate;
    public float HoursWorked;
    public override void Getdetails()
    {
        Console.WriteLine($"\n Hourly rate is:{HourlyRate} \n Hourworks is: {HoursWorked}");
    }
}
