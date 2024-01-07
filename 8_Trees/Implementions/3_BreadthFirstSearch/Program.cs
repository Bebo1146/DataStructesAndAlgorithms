using _1_Tree;

namespace _3_BreadthFirstSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.Left);
            Console.WriteLine(root.Value);
            InOrder(root.Right);
        }

        public void PreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Value);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        public void PostOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.WriteLine(root.Value);
        }
    }
}
