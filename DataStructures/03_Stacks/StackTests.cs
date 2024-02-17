using DataStructures.Shared;

namespace DataStructures._03_Stacks;

/// <summary>
/// Provides methods to execute tests on the Stack class.
/// </summary>
public static class StackTests
{
    /// <summary>
    /// Executes various tests on the Stack class.
    /// </summary>
    public static void Execute()
    {
        TestStack();
        TestStackWithTwoQueue();
    }

    private static void TestStack()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing the Push method");

        var stack = new Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"{stack}\n");

        ConsoleUtilities.PrintHeaderTitle("Testing the Pop method");
            
        stack.Pop();
            
        Console.WriteLine($"{stack}\n");

        ConsoleUtilities.PrintHeaderTitle("Testing the Peek method");

        Console.WriteLine($"{stack}");
        Console.WriteLine($"Peeked value: {stack.Peek()}");
        Console.WriteLine($"{stack}\n");
    }

    private static void TestStackWithTwoQueue()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing Stack With Two Queues");

        var stack = new StackWithTwoQueues();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine($"Push: {stack}");

        stack.Pop();
        stack.Pop();
        stack.Pop();

        Console.WriteLine($"Pop: {stack}");

        Console.WriteLine($"Peek: {stack.Peek()}");

        Console.WriteLine($"Size: {stack.Size()}");
    }
}