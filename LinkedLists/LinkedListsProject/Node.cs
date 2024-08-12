namespace LinkedListsProject;

/// <summary>
/// Represents a node in a singly linked list.
/// </summary>
public class Node
{
    /// <summary>
    /// Gets or sets the value of the node.
    /// </summary>
    /// <value>
    /// The integer value stored in the node.
    /// </value>
    public int Value { get; set; }

    /// <summary>
    /// Gets or sets the reference to the next node in the linked list.
    /// </summary>
    /// <value>
    /// The next <see cref="Node"/> in the linked list, or <c>null</c> if this is the last node.
    /// </value>
    public Node Next { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Node"/> class with the specified value.
    /// </summary>
    /// <param name="value">The value to be stored in the node.</param>
    public Node(int value)
    {
        Value = value;
    }
}
