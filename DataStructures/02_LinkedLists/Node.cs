namespace DataStructures._02_LinkedLists;

/// <summary>
/// Represents a node in a linked list.
/// </summary>
public class Node(int value)
{
    /// <summary>
    /// Gets or sets the value stored in the node.
    /// </summary>
    public int Value { get; set; } = value;

    /// <summary>
    /// Gets or sets the reference to the next node in the linked list.
    /// </summary>
    public Node? Next { get; set; }
}