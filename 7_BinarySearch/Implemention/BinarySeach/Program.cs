namespace BinarySeach
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 3, 3, 4, 5, 6, 7, 8 };

            var targetsIndex = BinarySearch(arr, 5);

            Console.WriteLine(targetsIndex);
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (target > arr[mid])
                {
                    left = mid + 1;
                }
                else if (target < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
