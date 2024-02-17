namespace DataStructures._07_AvlTrees;

/// <summary>
/// Represents an AVL tree data structure.
/// </summary>
public class AvlTree
{
    private Node? _root;

    /// <summary>
    /// Inserts a value into the AVL tree while maintaining balance.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    public void Insert(int value)
    {
        _root = Insert(_root, value);
    }

    private static Node Insert(Node? root, int value)
    {
        if (root == null)
        {
            return new Node(value);
        }

        if (value < root.Value)
        {
            root.LeftChild = Insert(root.LeftChild, value);
        }
        else
        {
            root.RightChild = Insert(root.RightChild, value);
        }

        return root;
    }
}