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

        public abstract void AddGrade(char grade);

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
