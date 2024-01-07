namespace _2_MergeSort
{
    internal class Program
    {
        static void Main()
        {
            var arr = new[] { 2, 1, 4, 3 };

            MergeSorting(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static int[] MergeSorting(int[] arr, int startingIndex, int endingIndex)
        {
            if (startingIndex < endingIndex)
            {
                int middleIndex = (startingIndex + endingIndex) / 2; // most programming languages round down
                MergeSorting(arr, startingIndex, middleIndex);
                MergeSorting(arr, middleIndex + 1, endingIndex);

                Merge(arr, startingIndex, middleIndex, endingIndex);
            }

            return arr;
        }

        public static void Merge(int[] arr, int startIndex, int middleIndex, int endIndex)
        {
            int leftLength = (middleIndex - startIndex) + 1;
            int rightLength = endIndex - middleIndex;

            var tempLeft = new int[leftLength];
            var tempRight = new int[rightLength];

            for (int a = 0; a < leftLength; a++)
            {
                tempLeft[a] = arr[startIndex + a];
            }

            for (int b = 0; b < rightLength; b++)
            {
                tempRight[b] = arr[middleIndex + 1 + b];
            }

            int i = 0;
            int j = 0;
            int k = startIndex;

            while (i < leftLength && j < rightLength)
            {
                if (tempLeft[i] <= tempRight[j])
                {
                    arr[k] = tempLeft[i];
                    i++;
                }
                else
                {
                    arr[k] = tempRight[j];
                    j++;
                }
                k++;
            }

            while (i < leftLength)
            {
                arr[k] = tempLeft[i];
                i++;
                k++;
            }

            while (j < rightLength)
            {
                arr[k] = tempRight[j];
                j++;
                k++;
            }
        }
    }
}
