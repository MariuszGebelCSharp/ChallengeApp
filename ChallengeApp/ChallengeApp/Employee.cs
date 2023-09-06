namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        
        //float
        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"{grade:N2} is invalid grade value");
            }
        }

        //double
        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        //int
        public void AddGrade(int grade)
        {
            float gradeAsInt = (int)grade;
            this.AddGrade(gradeAsInt);
        }

        //long
        public void AddGrade(long grade)
        {
            float gradeAsLong = (long)grade;
            this.AddGrade(gradeAsLong);
        }

        //string
        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
            this.AddGrade(result);

            }
            else
            {
                Console.WriteLine($"'{grade}' is invalid grade value (not float)");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;    
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
