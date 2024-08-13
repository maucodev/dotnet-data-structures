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

            linkedList.Clear();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(50);
            linkedList.Reverse();
            Console.WriteLine($"Reversed: {string.Join(" ", linkedList.ToArray())}");

            linkedList.Clear();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(50);
            Console.WriteLine($"Original: {string.Join(" ", linkedList.ToArray())}");
            Console.WriteLine($"1th value from the end: {linkedList.GetKthValueFromTheEnd(1)}");
            Console.WriteLine($"3th value from the end: {linkedList.GetKthValueFromTheEnd(3)}");
            Console.WriteLine($"5th value from the end: {linkedList.GetKthValueFromTheEnd(5)}");

            Console.ReadLine();
        }
    }
}
