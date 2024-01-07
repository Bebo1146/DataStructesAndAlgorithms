using _1_Tree;

namespace _2_BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool SearchNode(TreeNode root, int target)
        {
            if (root == null)
            {
                return false;
            }

            if (target > root.Value)
            {
                return SearchNode(root.Right, target);
            }
            if (target < root.Value)
            {
                return SearchNode(root.Left, target);
            }

            return true;
        }

        public TreeNode Insert(TreeNode root, int val)
        {
            if (root is null)
            {
                return new TreeNode(val);
            }

            if (val > root.Value)
            {
                root.Right = Insert(root.Right, val);
            }
            else if (val < root.Value)
            {
                root.Left = Insert(root.Left, val);
            }

            return root;
        }

        public TreeNode Remove(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (val > root.Value)
            {
                root.Right = Remove(root.Right, val);
            }
            else if (val < root.Value)
            {
                root.Left = Remove(root.Left, val);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                } 
                if (root.Right == null)
                {
                    return root.Left;
                }

                TreeNode minNode = MinValueNode(root.Right);
                root.Value = minNode.Value;
                root.Right = Remove(root.Right, minNode.Value);
            }

            return root;
        }

        public TreeNode MinValueNode(TreeNode root)
        {
            TreeNode curr = root;
            while (curr != null && curr.Left != null)
            {
                curr = curr.Left;
            }

            return curr;
        }
    }
}
