﻿namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        { 
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"{grade:N2} is not valid grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
           
            foreach(var grade in this.grades) 
            { 
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
