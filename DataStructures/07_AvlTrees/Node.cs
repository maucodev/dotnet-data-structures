namespace DataStructures._07_AvlTrees;

/// <summary>
/// Represents a node in an AVL tree.
/// </summary>
public class Node(int value)
{
    /// <summary>
    /// Gets or sets the value stored in the node.
    /// </summary>
    public int Value { get; set; } = value;

    /// <summary>
    /// Gets or sets the left child of the node.
    /// </summary>
    public Node? LeftChild { get; set; }

    /// <summary>
    /// Gets or sets the right child of the node.
    /// </summary>
    public Node? RightChild { get; set; }
}