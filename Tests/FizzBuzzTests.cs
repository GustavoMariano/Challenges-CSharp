using FizzBuzz;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_Input3()
        {
            //Arrange
            int n = 3;
            string[] expectedResult = new string[] { "1", "2", "Fizz" };

            //Action
            IList<string> result = FizzBuzzSolution.Solution(n);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FizzBuzz_Input5()
        {
            //Arrange
            int n = 5;
            string[] expectedResult = new string[] { "1", "2", "Fizz", "4", "Buzz" };

            //Action
            IList<string> result = FizzBuzzSolution.Solution(n);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void FizzBuzz_Input15()
        {
            //Arrange
            int n = 15;
            string[] expectedResult = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            //Action
            IList<string> result = FizzBuzzSolution.Solution(n);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
