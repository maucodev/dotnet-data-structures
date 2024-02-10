using DataStructures.Shared;

namespace DataStructures._04_Queues
{
    /// <summary>
    /// Provides methods to execute tests for custom queue implementations.
    /// </summary>
    public static class CustomQueueTests
    {
        /// <summary>
        /// Executes the tests for the custom queue implementations.
        /// </summary>
        public static void Execute()
        {
            TestStringReverser();
            TestCustomArrayQueue();
            TestCustomQueueWithTwoStacks();
            TestCustomPriorityQueue();
        }

        private static void TestStringReverser()
        {
            ConsoleUtilities.PrintTitle("Testing the Reverse method");

            var queue = new Queue<string>();
            
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            
            Console.WriteLine($"Queue: {StringReverser.Print(queue)}\n");
            
            StringReverser.Reverse(queue);
            
            Console.WriteLine($"Result: {StringReverser.Print(queue)}\n");
        }

        private static void TestCustomArrayQueue()
        {
            ConsoleUtilities.PrintTitle("Testing the Custom Array Queue method");

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
        }

        private static void TestCustomQueueWithTwoStacks()
        {
            ConsoleUtilities.PrintTitle("Testing the Custom Queue With Two Stacks");
            
            var customQueueWithTwoStacks = new CustomQueueWithTwoStacks();
            
            customQueueWithTwoStacks.Enqueue(10);
            customQueueWithTwoStacks.Enqueue(20);
            customQueueWithTwoStacks.Enqueue(30);
            customQueueWithTwoStacks.Enqueue(40);
            customQueueWithTwoStacks.Enqueue(50);
            
            customQueueWithTwoStacks.Dequeue();
            customQueueWithTwoStacks.Dequeue();
            customQueueWithTwoStacks.Dequeue();
            customQueueWithTwoStacks.Dequeue();
            
            Console.WriteLine($"Peek: {customQueueWithTwoStacks.Peek()}\n");
        }

        private static void TestCustomPriorityQueue()
        {
            ConsoleUtilities.PrintTitle("Testing the Custom Priority Queue");

            var priorityQueue = new CustomPriorityQueue();
            
            priorityQueue.Insert(1);
            priorityQueue.Insert(3);
            priorityQueue.Insert(6);
            priorityQueue.Insert(5);
            priorityQueue.Insert(4);
            priorityQueue.Insert(2);
            
            Console.WriteLine($"Queue: {priorityQueue}");

            priorityQueue.Insert(8);
            priorityQueue.Insert(10);
            priorityQueue.Insert(9);
            priorityQueue.Insert(7);

            Console.WriteLine($"Queue: {priorityQueue}");
            
            Console.WriteLine($"Removed: {priorityQueue.Remove()}\n");
            
            Console.WriteLine($"Queue: {priorityQueue}");
        }
    }
}
