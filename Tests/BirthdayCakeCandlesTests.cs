using BirthdayCakeCandles;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class BirthdayCakeCandlesTests
    {
        private List<int> listInt;
        private int expectedResult = 0;

        [Test]
        public void ShouldReturn_One()
        {
            //Arrange
            expectedResult = 1;
            listInt = new() { 1, 2, 3, 4 };

            //Action
            int result = BirthdayCake.birthdayCakeCandles(listInt);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_Two()
        {
            //Arrange
            expectedResult = 2;
            listInt = new() { 3, 2, 1, 3 };

            //Action
            int result = BirthdayCake.birthdayCakeCandles(listInt);

            //Action
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_Three()
        {
            //Arrange
            expectedResult = 3;
            listInt = new() { 4, 4, 4, 3 };

            //Action
            int result = BirthdayCake.birthdayCakeCandles(listInt);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
