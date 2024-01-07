namespace _2_RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num_1 = new[]
            {
                3, 2, 2, 3
            };
            var value_1 = RemoveElement(num_1, 3);

            for (int i = 0; i < value_1; i++)
            {
                Console.Write($"{num_1[i]} ");
            }

            Console.WriteLine();

            var num_2 = new[]
            {
                0, 1, 2, 2, 3, 0, 4, 2
            };
            var value_2 = RemoveElement(num_2, 2);

            for (int i = 0; i < value_2; i++)
            {
                Console.Write($"{num_2[i]} ");
            }
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            return index;
        }
    }
}
