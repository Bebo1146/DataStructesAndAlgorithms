namespace SortingImplemtions
{
    internal class Program
    {
        static void Main()
        {
            var arr = new[] { 2, 1, 4, 3, 2 };

            InsertionSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && arr[j + 1] < arr[j])
                {
                    int tmp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = tmp;
                    j--;
                }
            }

            return arr;
        }

    }
}
