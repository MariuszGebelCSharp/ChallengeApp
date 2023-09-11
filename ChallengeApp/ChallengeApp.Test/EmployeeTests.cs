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
            employee.AddGrade('a');
            employee.AddGrade(9);
            // act
            var statisctics = employee.GetStatistics();
            // assert
            Assert.AreEqual(100, statisctics.Max);
        }

        [Test]
        public void CheckIfMinValueIsCorrect()
        {
            // arrange
            Employee employee = new Employee("Waldemar", "Pawlak");
            employee.AddGrade(6);
            employee.AddGrade(10.1F);
            employee.AddGrade(7.45F);
            employee.AddGrade('d');
            employee.AddGrade(4.4F);
            // act
            var statisctics = employee.GetStatistics();
            // assert
            Assert.AreEqual(Math.Round(4.4, 2), Math.Round(statisctics.Min, 2));
        }
        [Test]
        public void CheckIfAverageValueIsCorrect()
        {
            // arrange
            Employee employee = new Employee("Wiktor", "Kowalski");
            employee.AddGrade(13);
            employee.AddGrade(7.6F);
            employee.AddGrade('e');
            employee.AddGrade(1.1F);
            employee.AddGrade('b');
            // act
            var statisctics = employee.GetStatistics();
            // assert
            Assert.AreEqual(Math.Round(24.34, 2), Math.Round(statisctics.Average,2));
        }

        [Test]
        public void CheckIfAverageLetterGetsCorrectLetter()
        {
            // arrange
            Employee employee = new Employee("Wiktor", "Kowalski");
            employee.AddGrade(13);
            employee.AddGrade(7.6F);
            employee.AddGrade(100);
            employee.AddGrade(1.1F);
            employee.AddGrade(80.6F);
            // act
            var statisctics = employee.GetStatistics();
            // assert
            Assert.AreEqual('C', statisctics.AverageLetter);
        }
    }
}