namespace DataStructures._02_LinkedLists;

public class Node(int value)
{
    public int Value { get; set; } = value;

    public Node? Next { get; set; }
}