using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            for (int i = 1; i < 5; i++)
                stack.Push(i);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();

            stack.Pop();
        }
    }
}
