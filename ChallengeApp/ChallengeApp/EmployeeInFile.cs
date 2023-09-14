using System.Diagnostics;

namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
                if (grade >= 0 && grade <= 100)
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                }
                }
                else
                {
                    throw new Exception($"{grade:N2} is not valid grade value");
                }    
        }

        public override void AddGrade(char grade)
        {
            int result = 0;
            switch (grade)
            {
                case 'A':
                case 'a':
                    result = 100;
                    break;
                case 'B':
                case 'b':
                    result = 80;
                    break;
                case 'C':
                case 'c':
                    result = 60;
                    break;
                case 'D':
                case 'd':
                    result = 40;
                    break;
                case 'E':
                case 'e':
                    result = 20;
                    break;
                default:
                    Console.WriteLine($"There is no grade for the letter: {grade}!");
                    break;
                    //throw new Exception("Wrong Letter!");
            }
            if(result > 0)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(result);
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0;
            result.Max = float.MinValue;
            result.Min = float.MaxValue;
            int counter = 0;
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        counter++;
                        var number = float.Parse(line);
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Average += number;
                        line = reader.ReadLine();
                    }
                }
                result.Average /= counter;
                Console.WriteLine($"The number of grades used to calculate the AVG: {counter}");
                switch (result.Average)
                {
                    case var average when average >= 80:
                        result.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        result.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        result.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        result.AverageLetter = 'D';
                        break;
                    default:
                        result.AverageLetter = 'E';
                        break;
                }
            }
            return result;  
        }
    }
}
