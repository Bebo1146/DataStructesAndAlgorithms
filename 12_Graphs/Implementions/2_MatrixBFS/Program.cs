namespace _2_MatrixBFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = { 
                { 0, 0, 0, 0 }, 
                { 1, 1, 0, 0 }, 
                { 0, 0, 0, 1 }, 
                { 0, 1, 0, 0 }
            };
        }

        public int BFS(int[,] matrix)
        {
            int rowEndpoint = matrix.GetLength(0); int columnEndpoint = matrix.GetLength(1);
            Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
            queue.Enqueue((0, 0));
            int length = 1;
            while (queue.Any())
            {
                for (int i = 0; i < queue.Count(); i++)
                {
                    (int row, int col) = queue.Dequeue();
                    if (row < 0 || row >= rowEndpoint || col < 0 || col >= columnEndpoint || matrix[row, col] == 1)
                    {
                        continue;
                    }
                    if (row == rowEndpoint - 1 && col == columnEndpoint - 1)
                    {
                        return length;
                    }
                    matrix[row, col] = 1;

                    queue.Enqueue((row - 1, col));
                    queue.Enqueue((row - 1, col + 1));
                    queue.Enqueue((row, col + 1));
                    queue.Enqueue((row + 1, col + 1));

                    queue.Enqueue((row + 1, col));
                    queue.Enqueue((row + 1, col - 1));
                    queue.Enqueue((row, col - 1));
                    queue.Enqueue((row - 1, col - 1));
                }
                length++;
            }

            return -1; // This should never be called
        }
    }
}
