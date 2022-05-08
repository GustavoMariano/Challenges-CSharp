using MinimalMovesToSolveTowerOfHanoi;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class MinimalMovesToSolveTowerOfHanoiTests
    {
        private int moves = 0;
        private int result = 0;
        private int expectedResult = 0;

        [Test]
        public void MustReturn_1_Move()
        {
            //Arrange
            expectedResult = 1;
            moves = 1;

            //Action
            result = TowerOfHanoi.CalculateMinimalMoves(moves);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void MustReturn_3_Moves()
        {
            //Arrange
            expectedResult = 3;
            moves = 2;

            //Action
            result = TowerOfHanoi.CalculateMinimalMoves(moves);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void MustReturn_127_Moves()
        {
            //Arrange
            expectedResult = 127;
            moves = 7;

            //Action
            result = TowerOfHanoi.CalculateMinimalMoves(moves);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
