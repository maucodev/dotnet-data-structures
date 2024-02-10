using DataStructures.Shared;

namespace DataStructures._02_LinkedLists;

/// <summary>
/// Contains methods to test the functionality of the LinkedList class.
/// </summary>
public static class LinkedListTests
{
    /// <summary>
    /// Executes the tests for the LinkedList class.
    /// </summary>
    public static void Execute()
    {
        var numbers = new LinkedList();

        TestAddLast(numbers);
        TestAddFirst(numbers);
        TestIndexOf(numbers);
        TestContains(numbers);
        TestRemoveFirst();
        TestRemoveLast();
        TestGetSize();
        TestGetSizeV2();
        TestToArray();
        TestReverse();
        TestGetKthFromTheEnd();
        TestPrintMiddle();
        TestHasLoop();
    }

    private static void TestAddLast(LinkedList numbers)
    {
        ConsoleUtilities.PrintTitle("Testing the AddLast method");

        numbers.AddLast(2);
        numbers.AddLast(3);
        numbers.Print();
    }

    private static void TestAddFirst(LinkedList numbers)
    {
        ConsoleUtilities.PrintTitle("Testing the AddFirst method");

        numbers.AddFirst(1);
        numbers.Print();
    }

    private static void TestIndexOf(LinkedList numbers)
    {
        ConsoleUtilities.PrintTitle("Testing the IndexOf method");

        Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");
        Console.WriteLine($"Index of 2: {numbers.IndexOf(2)}");
        Console.WriteLine($"Index of 3: {numbers.IndexOf(3)}");
        Console.WriteLine($"Index of 4: {numbers.IndexOf(4)}");

        numbers.Print();
    }

    private static void TestContains(LinkedList numbers)
    {
        ConsoleUtilities.PrintTitle("Testing the Contains method");

        Console.WriteLine($"Contains 1: {numbers.Contains(1)}");
        Console.WriteLine($"Contains 4: {numbers.Contains(4)}");

        numbers.Print();
    }

    private static void TestRemoveFirst()
    {
        ConsoleUtilities.PrintTitle("Testing the RemoveFirst method");

        var numbers = new LinkedList();

        numbers.AddFirst(1);

        numbers.Print();
            
        numbers.RemoveFirst();
        numbers.RemoveFirst();
            
        numbers.Print();
    }

    private static void TestRemoveLast()
    {
        ConsoleUtilities.PrintTitle("Testing the RemoveLast method");

        var numbers = new LinkedList();
            
        numbers.AddFirst(1);
            
        numbers.AddLast(2);
            
        numbers.Print();
            
        numbers.RemoveLast();
            
        numbers.Print();
            
        numbers.RemoveLast();
        numbers.RemoveLast();
            
        numbers.Print();
    }

    private static void TestGetSize()
    {
        ConsoleUtilities.PrintTitle("Testing the GetSize method");

        var numbers = new LinkedList();
            
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.AddLast(3);
            
        numbers.Print();
            
        Console.WriteLine($"Size: {numbers.GetSize()}\n");
    }

    private static void TestGetSizeV2()
    {
        ConsoleUtilities.PrintTitle("Testing the GetSizeV2 method");

        var numbers = new LinkedList();
            
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.RemoveFirst();
        numbers.RemoveLast();
            
        numbers.Print();
            
        Console.WriteLine($"Size V2: {numbers.GetSizeV2()}\n");
    }

    private static void TestToArray()
    {
        ConsoleUtilities.PrintTitle("Testing the ToArray method");
            
        var numbers = new LinkedList();
            
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.Print();
            
        var array = numbers.ToArray();
            
        Console.WriteLine($"Size of the array: {array.Length}\n");
    }

    private static void TestReverse()
    {
        ConsoleUtilities.PrintTitle("Testing the Reverse method");

        var numbers = new LinkedList();
            
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.AddLast(3);
        numbers.Print();
            
        numbers.Reverse();
            
        numbers.Print();
    }

    private static void TestGetKthFromTheEnd()
    {
        ConsoleUtilities.PrintTitle("Testing the GetKthFromTheEnd method");
            
        var numbers = new LinkedList();
            
        numbers.AddFirst(10);
        numbers.AddLast(20);
        numbers.AddLast(30);
        numbers.AddLast(40);
        numbers.AddLast(50);
            
        numbers.Print();
            
        Console.WriteLine($"Element at the position 1 from the end: {numbers.GetKthFromTheEnd(1)}");
        Console.WriteLine($"Element at the position 3 from the end: {numbers.GetKthFromTheEnd(3)}");
        Console.WriteLine($"Element at the position 5 from the end: {numbers.GetKthFromTheEnd(5)}\n");
    }

    private static void TestPrintMiddle()
    {
        ConsoleUtilities.PrintTitle("Testing the PrintMiddle method");

        var numbers = new LinkedList();
            
        numbers.AddFirst(1);
        numbers.AddLast(2);
        numbers.AddLast(3);
        numbers.AddLast(4);
        numbers.AddLast(5);
        numbers.AddLast(6);
        numbers.AddLast(7);
        numbers.Print();
        numbers.PrintMiddle();
        numbers.RemoveLast();
        numbers.RemoveLast();
        numbers.RemoveLast();
        numbers.Print();
            
        numbers.PrintMiddle();
    }

    private static void TestHasLoop()
    {
        ConsoleUtilities.PrintTitle("Testing the HasLoop method");
            
        var numbers = new LinkedList();
            
        numbers.AddFirst(10);
        numbers.AddLast(20);
        numbers.AddLast(30);
        numbers.AddLast(40);
        numbers.AddLast(50);
            
        numbers.Print();
            
        Console.WriteLine($"Has loop: {numbers.HasLoop()}\n");
            
        Console.WriteLine($"Has loop: {numbers.HasLoop(createLoop: true)}\n");
    }
}