using NUnit.Framework;
using static ThingsInverter.BinaryTreeInverter;

namespace Challenges.Tests
{
    [TestFixture]
    public class BinaryTreeInverterTests
    {

        [Test]
        public void ShouldReturn_True()
        {
            // Arrange
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(7);

            TreeNode expected = new TreeNode(1);
            expected.Left = new TreeNode(3);
            expected.Right = new TreeNode(2);
            expected.Left.Left = new TreeNode(7);
            expected.Left.Right = new TreeNode(6);
            expected.Right.Left = new TreeNode(5);
            expected.Right.Right = new TreeNode(4);

            // Action
            TreeNode result = InvertTree(root);

            // Assert
            Assert.IsTrue(AreTreesEqual(expected, result));
        }

        #region Private Methods
        private bool AreTreesEqual(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null && tree2 == null)
                return true;

            if (tree1 == null || tree2 == null)
                return false;

            return tree1.Value == tree2.Value &&
                   AreTreesEqual(tree1.Left, tree2.Left) &&
                   AreTreesEqual(tree1.Right, tree2.Right);
        }
        #endregion Private Methods
    }
}
