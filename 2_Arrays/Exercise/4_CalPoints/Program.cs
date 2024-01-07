namespace _4_CalPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameInformation_1 = new[]
            {
                "5", "2", "C", "D", "+"
            };
            var pointsFromGame_1 = CalPoints(gameInformation_1);

            Console.WriteLine(pointsFromGame_1);

            var gameInformation_2 = new[]
            {
                "5", "-2", "4", "C", "D", "9", "+", "+"
            };
            var pointsFromGame_2 = CalPoints(gameInformation_2);

            Console.WriteLine(pointsFromGame_2);

            var gameInformation_3 = new[]
            {
                "1", "C"
            };
            var pointsFromGame_3 = CalPoints(gameInformation_3);

            Console.WriteLine(pointsFromGame_3);
        }

        public static int CalPoints(string[] operations)
        {
            var stack = new List<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                if (int.TryParse(operations[i], out var num))
                {
                    stack.Add(num);
                }
                else
                {
                    if (operations[i] == "C")
                    {
                        stack.Remove(stack[^1]);
                    }
                    else if (operations[i] == "D")
                    {
                        stack.Add(stack[^1] * 2);
                    }
                    else // +
                    {
                        stack.Add(stack[^1] + stack[^2]);
                    }
                }
            }

            return stack.Sum();
        }
    }
}
