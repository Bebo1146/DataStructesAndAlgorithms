namespace _1_DimensionDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // Brute Force
        public static int BruteForce(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return BruteForce(n - 1) + BruteForce(n - 2);
        }

        // Memoization
        public static int Memoization(int n, int[] cache)
        {
            if (n <= 1)
            {
                return n;
            }

            if (cache[n] != 0)
            {
                return cache[n];
            }

            cache[n] = Memoization(n - 1, cache) + Memoization(n - 2, cache);

            return cache[n];
        }

        // Dynamic Programming, Bottom up
        public static int Dp(int n)
        {
            if (n < 2)
            {
                return n;
            }

            int[] dp = { 0, 1 };
            int i = 2;
            while (i <= n)
            {
                int tmp = dp[1];
                dp[1] = dp[0] + dp[1];
                dp[0] = tmp;
                i++;
            }

            return dp[1];
        }
    }
}
