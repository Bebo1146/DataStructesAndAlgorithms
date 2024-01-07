namespace Exercise
{
    internal class Program
    {
        static void Main()
        {
            var nums_1 = new []
            {
                1, 1, 2
            };
            var nums_2 = new[]
            {
                0, 0, 1, 1, 1, 2, 2, 3, 3, 4
            };

            var til_1 = RemoveDuplicates(nums_1);
            var til_2 = RemoveDuplicates(nums_2);

            for (int i = 0; i < til_1; i++)
            {
                Console.Write($"{nums_1[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < til_2; i++)
            {
                Console.Write($"{nums_2[i]} ");
            }
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
