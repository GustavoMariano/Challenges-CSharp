using NUnit.Framework;
using QuicksortAlgorithm;

namespace Challenges.Tests
{
    [TestFixture]
    public class QuicksortAlgorithmTests
    {
        [Test]
        public void ShouldReturn_Array_FourNumbers()
        {
            //Arrange
            int[] array = { 3, 2, 4, 1 };
            int[] expectedResult = { 1, 2, 3, 4 };

            //Action
            var result = QSortAlgorithm.Quicksort(array);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldReturn_Array_TenNumbers()
        {
            //Arrange
            int[] array = { 527, 184, 693, 872, 305, 941, 76, 458, 612, 389 };
            int[] expectedResult = { 76, 184, 305, 389, 458, 527, 612, 693, 872, 941 };

            //Action
            var result = QSortAlgorithm.Quicksort(array);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
