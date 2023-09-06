namespace ChallengeApp.Test
{
    public class Tests
    {     
        [Test]
        public void CheckIfMaxValueIsCorrect()
        {
            // arrange
            Employee employee = new Employee("Dorota", "Gil");
            employee.AddGrade(3.12F);
            employee.AddGrade(8.4F);
            employee.AddGrade(3.4F);
            employee.AddGrade(12);
            employee.AddGrade(9);
            // act
            var statisctics = employee.GetStatistics();
            // assert
            Assert.AreEqual(12, statisctics.Max);
        }

        [Test]
        public void CheckIfMinValueIsCorrect()
        {
            // arrange
            Employee employee = new Employee("Waldemar", "Pawlak");
            employee.AddGrade(6);
            employee.AddGrade(10.1F);
            employee.AddGrade(7.45F);
            employee.AddGrade(3);
            employee.AddGrade(4.4F);
            // act
            var statisctics = employee.GetStatistics();
            // assert
            Assert.AreEqual(3, statisctics.Min);
        }
        [Test]
        public void CheckIfAverageValueIsCorrect()
        {
            // arrange
            Employee employee = new Employee("Wiktor", "Kowalski");
            employee.AddGrade(13);
            employee.AddGrade(7.6F);
            employee.AddGrade(3);
            employee.AddGrade(1.1F);
            employee.AddGrade(3.9F);
            // act
            var statisctics = employee.GetStatistics();
            // assert
            Assert.AreEqual(Math.Round(5.72, 2), Math.Round(statisctics.Average,2));
        }
    }
}