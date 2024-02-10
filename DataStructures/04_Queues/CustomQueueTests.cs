namespace DataStructures._04_Queues;

public static class CustomQueueTests
{
    public static void Execute()
    {
        Console.WriteLine("Testing the Reverse method...\n");
        var queue = new Queue<string>();
        queue.Enqueue("a");
        queue.Enqueue("b");
        queue.Enqueue("c");
        Console.WriteLine($"Queue: {StringReverser.Print(queue)}");
        StringReverser.Reverse(queue);
        Console.WriteLine($"Result: {StringReverser.Print(queue)}\n");
    }
}