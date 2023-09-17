using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników!");
Console.WriteLine("============================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika!");
var employee = new EmployeeInFile("Jan", "Kowalski");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę!");
}

while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine();
        break;
    }
    try
    {
    employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    Console.WriteLine("Podaj kolejną ocenę pracownika!");
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Liczba ocen: {statistics.Count}");
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Letter Average: {statistics.AverageLetter}");