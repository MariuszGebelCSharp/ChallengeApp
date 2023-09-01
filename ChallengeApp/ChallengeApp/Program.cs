int[] grades = new int[365];
string[] daysOfWeek = new string[7];
daysOfWeek[0] = "poniedziałek";
daysOfWeek[1] = "wtorek";
daysOfWeek[2] = "środa";
daysOfWeek[3] = "czwartek";
daysOfWeek[4] = "piątek";
daysOfWeek[5] = "sobota";
daysOfWeek[6] = "niedziela";

Console.WriteLine(daysOfWeek[2]);

string[] daysOfWeek1 = {"poniedziałek", "wtorek", "środa" };

Console.WriteLine(daysOfWeek[0]);

for(int i=0; i<daysOfWeek.Length; i=i+2)
{
    Console.WriteLine(daysOfWeek[i]);
}

List<string> dayOfWeek =  new List<string>();

dayOfWeek.Add("poniedziałek");
dayOfWeek.Add("wtorek");
dayOfWeek.Add("środa");
dayOfWeek.Add("czwartek");
dayOfWeek.Add("piątek");
dayOfWeek.Add("sobota");
dayOfWeek.Add("niedziela");

for (int i = 0; i < dayOfWeek.Count; i++)
{
    Console.WriteLine("Dzień tygodnia nr "+ (i+1) + " to: " + dayOfWeek[i]);
}

foreach(var day in dayOfWeek)
{ Console.WriteLine(day); } 