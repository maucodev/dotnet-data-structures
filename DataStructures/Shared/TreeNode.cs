namespace DataStructures.Shared;

/// <summary>
/// Represents a node in a tree.
/// </summary>
public class TreeNode(int value)
{
    /// <summary>
    /// Gets or sets the value stored in the node.
    /// </summary>
    public int Value { get; set; } = value;

    /// <summary>
    /// Gets or sets the left child of the node.
    /// </summary>
    public TreeNode? LeftChild { get; set; }

    /// <summary>
    /// Gets or sets the right child of the node.
    /// </summary>
    public TreeNode? RightChild { get; set; }
}