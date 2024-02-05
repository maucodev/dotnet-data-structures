namespace DataStructures._02_LinkedLists;

public static class CustomLinkedListTests
{
    public static void Execute()
    {
        var numbers = new CustomLinkedList();

        Console.WriteLine("Testing the AddLast method...\n");
        numbers.AddLast(1);
        numbers.AddLast(2);
        numbers.AddLast(3);
        numbers.Print();
    }
}