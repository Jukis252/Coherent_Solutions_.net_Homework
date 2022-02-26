using CoherentHW3_Task2.Interfaces;

namespace CoherentHW3_Task2.Extension
{
    static class ReverseStack
    {
        public static IStack<T> Reverse<T>(this IStack<T> stack, int stackSize) where T : struct
        {
            IStack<T> reversedStack = new Entities.Stack<T>(stackSize);

            while (!stack.IsEmpty())
            {
                reversedStack.Push(stack.Pop());
            }
            return reversedStack;
        }
    }
}
