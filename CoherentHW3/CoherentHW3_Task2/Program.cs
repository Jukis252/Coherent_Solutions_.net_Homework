using CoherentHW3_Task2.Interfaces;
using CoherentHW3_Task2.Extension;

namespace CoherentHW3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstStack();
        }

        public static void FirstStack()
        {
            IStack<int> firstStack = new Entities.Stack<int>(10);
            Console.WriteLine("First stack (int) type:");
            if (firstStack.IsEmpty())
            {
                for (int i = 0; i < firstStack.Size; i++)
                {
                    firstStack.Push(i);
                    Console.Write(firstStack.Peek() + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Is stack empty: " + firstStack.IsEmpty());
            Console.WriteLine("Last element: " + firstStack.Peek());
            firstStack.Pop();
            Console.WriteLine("After Pop last digit: "+firstStack.Peek()); 
            IStack<int> reversedStack = firstStack.Reverse(firstStack.Size-1); // -1 just for that empty spaces would not become 0;
            Console.WriteLine($"Reversed string {reversedStack}");

        }
    }
}