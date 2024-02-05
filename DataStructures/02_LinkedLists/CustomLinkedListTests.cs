namespace DataStructures._02_LinkedLists;

public static class CustomLinkedListTests
{
    public static void Execute()
    {
        var numbers = new CustomLinkedList();

        Console.WriteLine("Testing the AddLast method...\n");
        numbers.AddLast(2);
        numbers.AddLast(3);
        numbers.Print();

        Console.WriteLine("Testing the AddFirst method...\n");
        numbers.AddFirst(1);
        numbers.Print();

        Console.WriteLine("Testing the IndexOf method...\n");
        Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");
        Console.WriteLine($"Index of 2: {numbers.IndexOf(2)}");
        Console.WriteLine($"Index of 3: {numbers.IndexOf(3)}");
        Console.WriteLine($"Index of 4: {numbers.IndexOf(4)}");

        Console.WriteLine("Testing the Contains method...\n");
        Console.WriteLine($"Contains 1: {numbers.Contains(1)}");
        Console.WriteLine($"Contains 4: {numbers.Contains(4)}");
    }
}