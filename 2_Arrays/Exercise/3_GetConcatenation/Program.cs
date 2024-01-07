namespace _3_GetConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums_1 = new[]
            {
                1, 2, 1
            };
            var nums_1Duplicated = GetConcatenation(nums_1);

            foreach (var num in nums_1Duplicated)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            var nums_2 = new[]
            {
                1, 3, 2, 1
            };
            var nums_2Duplicated = GetConcatenation(nums_2);

            foreach (var num in nums_2Duplicated)
            {
                Console.Write($"{num} ");
            }
        }

        public static int[] GetConcatenation(int[] nums)
        {
            var newNums = new int[nums.Length * 2];

            var index = 0;
            for (int i = 0; i < newNums.Length; i++)
            {
                if (index == nums.Length)
                {
                    index = 0;
                }

                newNums[i] = nums[index];
                index++;
            }

            return newNums;
        }
    }
}
