using AddTwoNumbers;
using NUnit.Framework;

namespace Challenges.Tests
{
    [TestFixture]
    public class AddTwoNumbersTests
    {
        [Test]
        public void ShouldReturn_708()
        {
            //Arrange
            AddTwoNum addTwoNumClass = new AddTwoNum();
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode expectedResult = new ListNode(7, new ListNode(0, new ListNode(8)));

            //Action
            ListNode result = addTwoNumClass.Solution(l1, l2);

            //Assert
            Assert.IsTrue(AreEqual(expectedResult, result));
        }

        [Test]
        public void ShouldReturn_0()
        {
            //Arrange
            AddTwoNum addTwoNumClass = new AddTwoNum();
            ListNode l1 = new ListNode(0);
            ListNode l2 = new ListNode(0);
            ListNode expectedResult = new ListNode(0);

            //Action
            ListNode result = addTwoNumClass.Solution(l1, l2);

            //Assert
            Assert.IsTrue(AreEqual(expectedResult, result));
        }

        [Test]
        public void ShouldReturn_89990001()
        {
            //Arrange
            AddTwoNum addTwoNumClass = new AddTwoNum();
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            ListNode expectedResult = new ListNode(8, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));

            //Action
            ListNode result = addTwoNumClass.Solution(l1, l2);

            //Assert
            Assert.IsTrue(AreEqual(expectedResult, result));
        }

        private bool AreEqual(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val) return false;
                l1 = l1.next;
                l2 = l2.next;
            }
            return l1 == null && l2 == null;
        }
    }
}
