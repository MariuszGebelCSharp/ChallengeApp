using ChallengeApp;

Employee employee1 = new Employee("Dorota", "Gil", 23);
employee1.AddScore(4);
employee1.AddScore(1);
employee1.AddScore(7);
employee1.AddScore(8);
employee1.AddScore(2); 

Employee employee2 = new Employee("Waldemar", "Pawlak", 53);
employee2.AddScore(1);
employee2.AddScore(8);
employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(5); 

Employee employee3 = new Employee("Wiktor", "Kowalski", 48);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(6);
employee3.AddScore(8);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

List<Employee> employeesWithMaxResult = new List<Employee>();

int maxResult = -1;

foreach (var employee in employees)
{
    if(employee.Result == maxResult)
    {
        employeesWithMaxResult.Add(employee);
    }
    else if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeesWithMaxResult.Clear();
        employeesWithMaxResult.Add(employee);
    }
}

if (employeesWithMaxResult.Count > 1) {
    Console.WriteLine("Najwyższą sumę ocen osiągnęli pracownicy: ");
} else {
    Console.WriteLine("Najwyższą sumę ocen osiągnął pracownik: ");
}

foreach (var employee in employeesWithMaxResult)
{
    Console.WriteLine(employee.Name + " " + employee.Surname + ", " +
        "Wiek " + employee.Age + ", Suma ocen: " + employee.Result);
}