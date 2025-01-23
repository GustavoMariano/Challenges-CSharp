using NUnit.Framework;
using System.Collections.Generic;
using TopKFrequentElements;

namespace Challenges.Tests
{
    [TestFixture]
    public class TopKFrequentElementsTests
    {
        private List<int> sequence;

        [Test]
        public void MustToReturn_One()
        {
            //Arrange
            sequence = new() { 1, 1, 1, 2, 2, 3 };

            //Action
            int result = TopFrequentElements.Validator(sequence);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MustToReturn_Three()
        {
            //Arrange
            sequence = new() { 3, 2, 1, 8, 3, 4, 9, 10 };

            //Action
            int result = TopFrequentElements.Validator(sequence);

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
