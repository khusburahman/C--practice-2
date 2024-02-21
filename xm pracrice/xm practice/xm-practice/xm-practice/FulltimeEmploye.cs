

namespace xm_practice;

 public class FulltimeEmploye:Employe
{
    public float AnnualSalary;
    public override void Getdetails()
    {
        Console.WriteLine($"\n Annual salary is:{AnnualSalary}");
    }
   
}

