namespace CountBits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // Count the number of 1 bits in an int
        public static int CountBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }
                n = n >> 1; // same as n / 2
            }
            return count;
        }
    }
}
