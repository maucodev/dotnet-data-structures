namespace DataStructures._07_AvlTrees;

/// <summary>
/// Represents a node in an AVL tree.
/// </summary>
public class Node(int value)
{
    /// <summary>
    /// Gets or sets the height of the AVL tree.
    /// </summary>
    /// <remarks>
    /// The height represents the maximum distance from the root node to any leaf node.
    /// </remarks>
    public int Height { get; set; }

    /// <summary>
    /// Gets or sets the left child of the node.
    /// </summary>
    public Node? LeftChild { get; set; }

    /// <summary>
    /// Gets or sets the right child of the node.
    /// </summary>
    public Node? RightChild { get; set; }

    /// <summary>
    /// Gets or sets the value stored in the node.
    /// </summary>
    public int Value { get; set; } = value;
}