﻿using _1_Tree;

namespace _4_BreathFirstSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public void BfsTraversal(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root != null)
            {
                queue.Enqueue(root);
            }

            int level = 0;
            while (queue.Count > 0)
            {
                Console.WriteLine("level " + level + ": ");
                int levelLength = queue.Count;
                for (int i = 0; i < levelLength; i++)
                {
                    TreeNode curr = queue.Dequeue();
                    Console.WriteLine(curr.Value);
                    if (curr.Left != null)
                    {
                        queue.Enqueue(curr.Left);
                    }
                    if (curr.Right != null)
                    {
                        queue.Enqueue(curr.Right);
                    }
                }
                level++;
                Console.WriteLine();
            }
        }
    }
}
