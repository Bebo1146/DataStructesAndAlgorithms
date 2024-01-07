namespace _3_AdjacencyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public Dictionary<string, List<string>> BuildAdjList()
        {
            Dictionary<string, List<string>> adjList = new();

            string[][] edges =
            {
                new[] { "A", "B" },
                new[] { "B", "C" }
            };

            adjList.Add("A", new List<string>());
            adjList.Add("B", new List<string>());

            foreach (var edge in edges)
            {
                string src = edge[0], dst = edge[1];
                if (!adjList.ContainsKey(src))
                {
                    adjList.Add(src, new List<string>());
                }
                if (!adjList.ContainsKey(dst))
                {
                    adjList.Add(dst, new List<string>());
                }

                adjList[src].Add(dst);
            }

            return adjList;
        }

        // Count paths (backtracking)
        public int Dfs(string node, string target, Dictionary<string, List<string>> adjList, HashSet<string> visit)
        {
            if (visit.Contains(node))
            {
                return 0;
            }
            if (node == target)
            {
                return 1;
            }
            int count = 0;

            visit.Add(node);

            foreach (string neighborin in adjList[node])
            {
                count += Dfs(neighborin, target, adjList, visit);
            }
            visit.Remove(node);

            return count;
        }

        // Shortest path from node to target.
        public int BFS(string node, string target, Dictionary<string, List<string>> adjList)
        {
            int length = 0;
            HashSet<string> visit = new HashSet<string>();
            Queue<string> q = new Queue<string>();
            visit.Add(node);
            q.Enqueue(node);

            while (q.Count != 0)
            {
                int queueLength = q.Count; // needed because the size of the q, will change often
                for (int i = 0; i < queueLength; i++)
                {
                    string curr = q.Peek();
                    q.Dequeue();
                    if (curr.Equals(target))
                    {
                        return length;
                    }
                    foreach (string neighbor in adjList[curr])
                    {
                        if (!visit.Contains(neighbor))
                        {
                            visit.Add(neighbor);
                            q.Enqueue(neighbor);
                        }
                    }
                }
                length++;
            }

            return length;
        }
    }
}
