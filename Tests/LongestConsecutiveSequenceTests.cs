using LongestConsecutiveSequence;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class LongestConsecutiveSequenceTests
    {
        private List<int> sequence;

        [Test]
        public void MustToReturn_Three()
        {
            //Arrange
            sequence = new() { 3, 2, 1, 100, 101 };

            //Action
            int result = LongestConsecutiveSeq.LongestConsecutiveSequenceValidator(sequence);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void MustToReturn_Four()
        {
            //Arrange
            sequence = new() { 100, 4, 200, 1, 3, 2 };

            //Action
            int result = LongestConsecutiveSeq.LongestConsecutiveSequenceValidator(sequence);

            //Assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void MustToReturn_Nine()
        {
            //Arrange
            sequence = new() { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

            //Action
            int result = LongestConsecutiveSeq.LongestConsecutiveSequenceValidator(sequence);

            //Assert
            Assert.AreEqual(9, result);
        }
    }
}
