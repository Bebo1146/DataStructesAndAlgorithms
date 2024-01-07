namespace _1_Tree
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int val, TreeNode left = null, TreeNode right = null)
        {
            Value = val;
            Left = left;
            Right = right;
        }
    }
}
