namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void IntType_ValueType()
        {
            // arrange
            int number1 = 3;
            int number2 = 2;    
     
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void FloatType_ValueType()
        {
            // arrange
            float number1 = 33.89F;
            float number2 = 3.12F;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void DoubleType_ValueType()
        {
            // arrange
            double number1 = 3.8;
            double number2 = 3.8;

            Assert.AreEqual(number1, number2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }

        [Test]
        public void ComparingTwoStrings()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            // act

            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }
 
        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            // act

            // assert
            Assert.AreNotEqual(user1, user2);
        }
    }
}
