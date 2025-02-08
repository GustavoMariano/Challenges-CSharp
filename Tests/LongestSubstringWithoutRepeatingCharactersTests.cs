using LongestSubstringWithoutRepeatingCharacters;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Test]
        public void ShouldReturn_3_abcabcbb()
        {
            //Arrange
            string str = "abcabcbb";

            //Action
            int result = UniqueCharacterSubstring.Solution(str);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void ShouldReturn_1_bbbbb()
        {
            //Arrange
            string str = "bbbbb";

            //Action
            int result = UniqueCharacterSubstring.Solution(str);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldReturn_3_pwwkew()
        {
            //Arrange
            string str = "pwwkew";

            //Action
            int result = UniqueCharacterSubstring.Solution(str);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void ShouldReturn_0()
        {
            //Arrange
            string str = "";

            //Action
            int result = UniqueCharacterSubstring.Solution(str);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ShouldReturn_1_()
        {
            //Arrange
            string str = " ";

            //Action
            int result = UniqueCharacterSubstring.Solution(str);

            //Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldReturn_2_au()
        {
            //Arrange
            string str = "au";

            //Action
            int result = UniqueCharacterSubstring.Solution(str);

            //Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void ShouldReturn_3_dvdf()
        {
            //Arrange
            string str = "dvdf";

            //Action
            int result = UniqueCharacterSubstring.Solution(str);

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
