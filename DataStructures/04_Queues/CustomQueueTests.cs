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

        Console.WriteLine("Testing the Custom Array Queue method...\n");
        var customQueue = new CustomArrayQueue(5);
        customQueue.Enqueue(10);
        customQueue.Enqueue(20);
        customQueue.Enqueue(30);
        customQueue.Enqueue(40);
        customQueue.Enqueue(50);
        Console.WriteLine($"Enqueue: {customQueue}");
        customQueue.Dequeue();
        customQueue.Dequeue();
        customQueue.Dequeue();
        customQueue.Dequeue();
        customQueue.Dequeue();
        Console.WriteLine($"Dequeue: {customQueue}");
        customQueue.Enqueue(60);
        customQueue.Enqueue(70);
        customQueue.Enqueue(80);
        customQueue.Enqueue(90);
        customQueue.Enqueue(100);
        Console.WriteLine($"Enqueue: {customQueue}");
        customQueue.Dequeue();
        customQueue.Dequeue();
        Console.WriteLine($"Dequeue: {customQueue}");
        customQueue.Enqueue(110);
        Console.WriteLine($"Enqueue: {customQueue}");
        customQueue.Dequeue();
        Console.WriteLine($"Dequeue: {customQueue}");

        Console.WriteLine("Testing ended!\n");
    }
}