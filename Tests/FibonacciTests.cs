using FibonacciSequence;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        private int repetions = 0;
        [Test]
        public void ShouldReturn_1_1_2()
        {
            //Arrange
            repetions = 3;
            List<int> expectedResult = new() { 1, 1, 2 };

            //Action
            List<int> result = Fibonacci.FibonacciSequenceGenerator(repetions);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        public void ShouldReturn_1_1_2_3_5_8_13_21_34()
        {
            //Arrange
            repetions = 9;
            List<int> expectedResult = new() { 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            //Action
            List<int> result = Fibonacci.FibonacciSequenceGenerator(repetions);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
