using MinMaxSum;
using NUnit.Framework;
using System.Collections.Generic;

namespace Challenges.Tests
{
    [TestFixture]
    public class MinMaxSumTests
    {
        List<int> listInt;

        [Test]
        public void BasicCases()
        {
            listInt = new() { 1, 2, 3, 4, 5 };
            Assert.AreEqual("10 14", Sum.minMaxSum(listInt));

            listInt = new() { 7, 69, 2, 221, 8974 };
            Assert.AreEqual("299 9271", Sum.minMaxSum(listInt));

            listInt = new() { 5, 5, 5, 5, 5 };
            Assert.AreEqual("20 20", Sum.minMaxSum(listInt));

            listInt = new() { 256741038, 623958417, 467905213, 714532089, 938071625 };
            Assert.AreEqual("2063136757 2744467344", Sum.minMaxSum(listInt));

            listInt = new() { 769082435, 210437958, 673982045, 375809214, 380564127 };
            Assert.AreEqual("1640793344 2199437821", Sum.minMaxSum(listInt));
        }
    }
}
