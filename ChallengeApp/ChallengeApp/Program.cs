using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników!");
Console.WriteLine("============================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika!");
var employee = new Employee("Jan", "Kowalski");

while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine();
        break;
    }
    employee.AddGrade(input);
    Console.WriteLine("Podaj kolejną ocenę pracownika!");
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Letter Average: {statistics.AverageLetter}");

