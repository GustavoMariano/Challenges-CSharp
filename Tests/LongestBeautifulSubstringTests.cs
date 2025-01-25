using LongestBeautifulSubstring;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class LongestBeautifulSubstringTests
    {
        [Test]
        public void MustToReturn_Thirteen()
        {
            //Arrange
            string inputString = "abcdeaeiaaioaaaaeiiiiouuuooaauuaeiu";
            string expected = "13";

            //Action
            string result = LongestBeautifulSub.Validator(inputString);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MustToReturn_Zero()
        {
            //Arrange
            string inputString = "aaaaa";
            string expected = "0";

            //Action
            string result = LongestBeautifulSub.Validator(inputString);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void MustToReturn_Five()
        {
            //Arrange
            string inputString = "aeiou";
            string expected = "5";

            //Action
            string result = LongestBeautifulSub.Validator(inputString);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
