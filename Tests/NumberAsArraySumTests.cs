using NumberAsArraySum;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class NumberAsArraySumTests
    {
        [Test]
        public void Test1()
        {
            //Arrange
            int[] inputNumbers = new[] { 1, 2, 3};
            int[] expected = new[] { 1, 2, 4 };

            //Action
            int[] result = NumberAsArray.Increment(inputNumbers);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            int[] inputNumbers = new[] { 9, 9, 9 };
            int[] expected = new[] { 1, 0, 0, 0 };

            //Action
            int[] result = NumberAsArray.Increment(inputNumbers);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
