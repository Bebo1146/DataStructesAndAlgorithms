namespace _3_QuickSort
{
    internal class Program
    {
        static void Main()
        {
            var arr = new[] { 4, 1, 3, 2 };
            QuickSorting(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static int[] QuickSorting(int[] arr, int startingIndex, int endingIndex)
        {
            if (endingIndex - startingIndex <= 0)
            {
                return arr;
            }

            int pivot = arr[endingIndex];
            int left = startingIndex;

            for (int i = startingIndex; i < endingIndex; i++)
            {
                if (arr[i] < pivot)
                {
                    int tmp = arr[left];
                    arr[left] = arr[i];
                    arr[i] = tmp;

                    left++;
                }
            }

            arr[endingIndex] = arr[left];
            arr[left] = pivot;

            QuickSorting(arr, startingIndex, left - 1);

            QuickSorting(arr, left + 1, endingIndex);

            return arr;
        }
    }
}
