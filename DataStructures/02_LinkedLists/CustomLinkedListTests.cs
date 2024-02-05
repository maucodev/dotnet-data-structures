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
        numbers.Print();

        Console.WriteLine("Testing the Contains method...\n");
        Console.WriteLine($"Contains 1: {numbers.Contains(1)}");
        Console.WriteLine($"Contains 4: {numbers.Contains(4)}");
        numbers.Print();

        Console.WriteLine("Testing the RemoveFirst method...\n");
        numbers = new CustomLinkedList();
        numbers.AddFirst(1);
        numbers.Print();
        numbers.RemoveFirst();
        numbers.RemoveFirst();
        numbers.Print();

        Console.WriteLine("Testing the RemoveLast method...\n");
        numbers = new CustomLinkedList();
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.Print();
        numbers.RemoveLast();
        numbers.Print();
        numbers.RemoveLast();
        numbers.RemoveLast();
        numbers.Print();

        Console.WriteLine("Testing the GetSize method...\n");
        numbers = new CustomLinkedList();
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.AddLast(3);
        numbers.Print();
        Console.WriteLine($"Size: {numbers.GetSize()}\n");

        Console.WriteLine("Testing the GetSizeV2 method...\n");
        numbers = new CustomLinkedList();
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.RemoveFirst();
        numbers.RemoveLast();
        numbers.Print();
        Console.WriteLine($"Size V2: {numbers.GetSizeV2()}\n");

        Console.WriteLine("Finished program");
    }
}