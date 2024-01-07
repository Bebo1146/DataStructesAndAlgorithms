namespace _4_BucketSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 2, 1, 2, 0, 0, 2 };

            Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static int[] Sort(int[] arr)
        {
            int[] counts = { 0, 0, 0 }; // Assuming arr only contains 0, 1 or 2

            foreach (int num in arr)
            {
                counts[num] += 1;
            }

            int i = 0;
            for (int n = 0; n < counts.Length; n++)
            {
                for (int j = 0; j < counts[n]; j++)
                {
                    arr[i] = n;
                    i++;
                }
            }

            return arr;
        }
    }
}
