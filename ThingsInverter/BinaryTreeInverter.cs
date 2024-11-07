namespace ThingsInverter
{
    public class BinaryTreeInverter
    {
        public class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int value)
            {
                Value = value;
            }
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;

            InvertTree(root.Left);
            InvertTree(root.Right);

            return root;
        }
    }
}