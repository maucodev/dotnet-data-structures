namespace DataStructures._03_Stacks;

public static class CustomStackTests
{
    public static void Execute()
    {
        var stack = new CustomStack();

        Console.WriteLine("Testing the Push method...\n");
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine($"{stack}\n");

        Console.WriteLine("Testing the Pop method...\n");
        stack.Pop();
        Console.WriteLine($"{stack}\n");

        Console.WriteLine("Testing the Peek method...\n");
        Console.WriteLine($"{stack}");
        Console.WriteLine($"Peeked value: {stack.Peek()}");
        Console.WriteLine($"{stack}\n");

        Console.WriteLine("Finished program");
    }
}