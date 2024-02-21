
namespace xm_practice;

public class Employe
{
    public int id;
    public string FirstName;
    public string LastName;
    public float salary;
   
    public virtual void Getdetails()
    {
       Console.WriteLine($"\n Employee id is: {id} \n Employee 1st name is: {FirstName} \nEmpoyee lastName is :{LastName}\n Employee Salary is :{salary}");
    }
}
