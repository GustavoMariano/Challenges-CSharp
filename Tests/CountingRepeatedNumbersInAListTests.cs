using CountingRepeatedNumbersInAList;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class CountingRepeatedNumbersInAListTests
    {
        [Test]
        public void FizzBuzz_Input3()
        {
            //Arrange
            List<int> inputIntList= new () { 4, 17, 23, 4, 89, 23, 50, 61, 77, 4, 17, 90, 11, 12, 13, 50, 61, 70, 80, 90 };
            int expectedResult = 6;

            //Action
            int result = CountingRepeatedNumbers.CountRepeatedNumbers(inputIntList);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
