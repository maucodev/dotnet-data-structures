using DataStructures.Shared;

namespace DataStructures._03_Stacks
{
    /// <summary>
    /// Provides methods to execute tests on the CustomStack class.
    /// </summary>
    public static class CustomStackTests
    {
        /// <summary>
        /// Executes various tests on the CustomStack class.
        /// </summary>
        public static void Execute()
        {
            ConsoleUtilities.PrintTitle("Testing the Push method");

            var stack = new CustomStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine($"{stack}\n");

            ConsoleUtilities.PrintTitle("Testing the Pop method");
            
            stack.Pop();
            
            Console.WriteLine($"{stack}\n");

            ConsoleUtilities.PrintTitle("Testing the Peek method");

            Console.WriteLine($"{stack}");
            Console.WriteLine($"Peeked value: {stack.Peek()}");
            Console.WriteLine($"{stack}\n");
        }
    }
}
