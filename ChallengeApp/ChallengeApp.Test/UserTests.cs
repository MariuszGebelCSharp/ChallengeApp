using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {     
        [Test]
        public void WhenEmployeeGetPlusScores()
        {
            // arrange
            Employee employee = new Employee("Dorota", "Gil", 23);
            employee.AddScore(4);
            employee.AddScore(1);
            employee.AddScore(7);
            employee.AddScore(8);
            employee.AddScore(2);
            // act
            var result = employee.Result;
            // assert
           Assert.AreEqual(22, result);
        }

        [Test]
        public void WhenEmployeeGetPlusAndMinusScores()
        {
            // arrange
            Employee employee = new Employee("Waldemar", "Pawlak", 53);
            employee.AddScore(5);
            employee.AddScore(3);
            employee.SubtractScore(7);
            employee.SubtractScore(1);
            employee.AddScore(7);
            // act
            var result = employee.Result;
            // assert
            Assert.AreEqual(7, result);
        }
        [Test]
        public void WhenEmployeeGetPlusAndMinusAndSpecialBonusScores()
        {
            // arrange
            Employee employee = new Employee("Wiktor", "Kowalski", 48);
            employee.AddScore(5);
            employee.DoubleScorePlusBonus(6);
            employee.SubtractScore(10);
            employee.SubtractScore(12);
            employee.AddScore(7);
            // act
            var result = employee.Result;
            // assert
            Assert.AreEqual(7, result);
        }

    }
}