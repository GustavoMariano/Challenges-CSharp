using NUnit.Framework;
using OddOrEvenVerificator;

namespace Challenges.Tests
{
    [TestFixture]
    public class OddOrEvenTests
    {
        int number = 0;

        [Test]
        public void ShouldReturn_2_Is_Even()
        {
            //Arrange
            number = 2;
            string expectedResult = "2 is Even";

            //Action
            string result = OddOrEven.Verificator(number);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_3_Is_Odd()
        {
            //Arrange
            number = 3;
            string expectedResult = "3 is Odd";

            //Action
            string result = OddOrEven.Verificator(number);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_0_Is_Even()
        {
            //Arrange
            number = 0;
            string expectedResult = "0 is Even";

            //Action
            string result = OddOrEven.Verificator(number);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
