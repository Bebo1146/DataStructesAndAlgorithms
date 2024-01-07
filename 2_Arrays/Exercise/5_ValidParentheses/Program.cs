namespace _5_ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstInput = "()";
            var secondInput = "()[]{}";
            var thirdInput = "(]";
            var fourthInput = "({})";
            var fifthInput = "({])";

            Console.WriteLine(IsValid(firstInput));
            Console.WriteLine(IsValid(secondInput));
            Console.WriteLine(IsValid(thirdInput));
            Console.WriteLine(IsValid(fourthInput));
            Console.WriteLine(IsValid(fifthInput));
        }
        
        public static bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var pairs = new Dictionary<char, char>
            {
                [')'] = '(',
                [']'] = '[',
                ['}'] = '{'
            };

            foreach (char c in s)
            {
                if (!pairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0 || stack.Pop() != pairs[c])
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
