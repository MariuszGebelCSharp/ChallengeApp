using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny pracowników!");
Console.WriteLine("============================================");
Console.WriteLine();
//Console.WriteLine("Podaj ocenę pracownika!");
var employee = new EmployeeInFile("Jan", "Kowalski");
employee.AddGrade(100);
employee.AddGrade(45.88);
employee.AddGrade('j');
employee.AddGrade('c');
employee.AddGrade("11");

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Letter Average: {statistics.AverageLetter}");