

using Newtonsoft.Json;
using xm_practice;




List<Employe>khus = new List<Employe>()
{
   new Employe() {id=1, FirstName="Khusbu", LastName="rahman", salary=2000},
   new Employe() {id=2,FirstName="Fima",LastName="rahman",salary=20000},
   new Employe() {id=3,FirstName="Ayesha",LastName="rahman",salary=20000},
   new Employe() {id=4,FirstName="Ayesha",LastName="rahman",salary=20000},

};
string json=JsonConvert.SerializeObject(khus,Formatting.Indented);
Console.WriteLine(json);
Console.ReadKey(true);

