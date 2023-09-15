namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        //public abstract void AddGrade(char grade);

        public int AddGrade(char grade)
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
            }
            return result;
        }  

    public void AddGrade(double grade)
        {
            float gradeAsFload = (float)grade;
            this.AddGrade(gradeAsFload);
        }

        public void AddGrade(int grade)
        {
            float gradeAsInt = (int)grade;
            this.AddGrade(gradeAsInt);
        } 
  
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float!");
            }
        }

        public abstract Statistics GetStatistics();
    }
}
