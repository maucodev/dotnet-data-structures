using System;

namespace ArraysProject
{
    internal abstract class Program
    {
        private static void Main()
        {
            var numbers = new CustomArray(3);

            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(40);
            numbers.Insert(50);
            Console.WriteLine(numbers);

            numbers.RemoveAt(2);
            Console.WriteLine(numbers);

            Console.WriteLine($"Index of 50: {numbers.IndexOf(50)}");
            Console.WriteLine($"Index of 13: {numbers.IndexOf(13)}");

            Console.WriteLine($"Highest value: {numbers.Max()}");

            var intersectNumbers = new CustomArray(3);
            intersectNumbers.Insert(10);
            intersectNumbers.Insert(30);
            intersectNumbers.Insert(50);
            intersectNumbers.Insert(70);
            Console.WriteLine($"Intersected values: {numbers.Intersect(intersectNumbers)}");

            Console.WriteLine($"Reversed values: {numbers.Reverse()}");

            Console.WriteLine($"Original values: {numbers}");

            numbers.InsertAt(30, 2);
            Console.WriteLine($"Inserted 30 at index 2: {numbers}");

            numbers.InsertAt(15, 0);
            Console.WriteLine($"Inserted 15 at index 0: {numbers}");

            numbers.InsertAt(45, 5);
            Console.WriteLine($"Inserted 45 at index 5: {numbers}");

            Console.ReadLine();
        }
    }
}
