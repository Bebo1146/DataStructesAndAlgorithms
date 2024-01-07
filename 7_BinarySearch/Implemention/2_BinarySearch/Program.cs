namespace _2_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foundValue = binarySearch(0, 100);

            Console.WriteLine(foundValue);
        }

        public static int binarySearch(int low, int high)
        {
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (isCorrect(mid) > 0)
                {
                    high = mid - 1;
                }
                else if (isCorrect(mid) < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        // 10 is gonna be some target value which we need to tipp
        public static int isCorrect(int n)
        {
            if (n > 10)
            {
                return 1;
            }
            else if (n < 10)
            {
                return -1;
            }

            return 0;
        }
    }
}
