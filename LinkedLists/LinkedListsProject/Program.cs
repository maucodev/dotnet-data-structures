using System;

namespace LinkedListsProject
{
    internal abstract class Program
    {
        private static void Main()
        {
            var linkedList = new CustomLinkedList();

            Console.WriteLine($"Total items: {linkedList.Size}");

            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            linkedList.AddFirst(5);

            Console.WriteLine($"Index of 1: {linkedList.IndexOf(1)}");
            Console.WriteLine($"Index of 20: {linkedList.IndexOf(20)}");

            Console.WriteLine($"Contains 8: {linkedList.Contains(8)}");
            Console.WriteLine($"Contains 30: {linkedList.Contains(30)}");

            linkedList.RemoveFirst();

            linkedList.RemoveLast();

            Console.WriteLine($"Total items: {linkedList.Size}");

            Console.WriteLine($"Array format: {string.Join(" ", linkedList.ToArray())}");

            Console.ReadLine();
        }
    }
}
