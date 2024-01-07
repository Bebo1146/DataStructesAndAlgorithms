namespace _6_MinStack
{
    internal class Program
    {
        static void Main()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            minStack.GetMin(); // return -3
            minStack.Pop();
            minStack.Top();    // return 0
            minStack.GetMin(); // return -2
        }

        public class MinStack
        {
            public MinStack()
            {
                myStack = new Stack<int>();
                myMin = int.MaxValue;
            }

            public void Push(int val)
            {
                if (val <= myMin)
                {
                    myStack.Push(myMin);
                    myMin = val;
                }

                myStack.Push(val);
            }

            public void Pop()
            {
                int peek = myStack.Pop();
                if (peek == myMin)
                {
                    myMin = myStack.Pop();
                }
            }

            public int Top()
            {
                return myStack.Peek();
            }

            public int GetMin()
            {
                return myStack.Min();
            }

            private int myMin;
            private Stack<int> myStack;
        }
    }
}
