using NUnit.Framework;
using SortCsv;

namespace Challenges.Tests
{
    [TestFixture]
    public class SortCsvTests
    {

        [Test]
        public void ShouldHandleTheExample()
        {
            Assert.AreEqual("Adam,Beth,Charles,Danielle,Eric\n3907,17945,10091,10088,10132\n48,2,12,13,11", MorseCode.SortCsvColumns("Beth,Charles,Danielle,Adam,Eric\n17945,10091,10088,3907,10132\n2,12,13,48,11"));
        }
    }
}
