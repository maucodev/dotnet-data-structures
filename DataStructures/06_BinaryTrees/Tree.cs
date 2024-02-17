using DataStructures.Shared;

namespace DataStructures._06_BinaryTrees;

public class Tree
{
    private TreeNode? _root;

    /// <summary>
    /// Inserts a value to the tree.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    public void Insert(int value)
    {
        var node = new TreeNode(value);

        if (IsEmpty())
        {
            _root = node;
            return;
        }

        var current = _root;

        while (true)
        {
            if (value < current?.Value)
            {
                if (current.LeftChild == null)
                {
                    current.LeftChild = node;
                    break;
                }

                current = current.LeftChild;
            }
            else
            {
                if (current is { RightChild: null })
                {
                    current.RightChild = node;
                    break;
                }

                current = current?.RightChild;
            }
        }
    }

    /// <summary>
    /// Searches for a value in the tree.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns><c>true</c> if the value is found in the tree; otherwise, <c>false</c>.</returns>
    public bool Find(int value)
    {
        var current = _root;

        while (current != null)
        {
            if (value < current.Value)
            {
                current = current.LeftChild;
            }
            else if(value > current.Value)
            {
                current = current.RightChild;
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Performs a pre-order traversal of the tree.
    /// </summary>
    public void TraversePreOrder()
    {
        Console.WriteLine("\nTraverse Pre-Order...\n");
        TraversePreOrder(_root);
    }

    /// <summary>
    /// Performs an in-order traversal of the tree.
    /// </summary>
    public void TraverseInOrder()
    {
        Console.WriteLine("\nTraverse In-Order...\n");
        TraverseInOrder(_root);
    }

    /// <summary>
    /// Performs a post-order traversal of the tree.
    /// </summary>
    public void TraversePostOrder()
    {
        Console.WriteLine("\nTraverse Post-Order...\n");
        TraversePostOrder(_root);
    }

    private static void TraversePreOrder(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        Console.WriteLine(root.Value);
        TraversePreOrder(root.LeftChild);
        TraversePreOrder(root.RightChild);
    }

    private static void TraverseInOrder(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        TraversePreOrder(root.LeftChild);
        Console.WriteLine(root.Value);
        TraversePreOrder(root.RightChild);
    }

    private static void TraversePostOrder(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        TraversePreOrder(root.LeftChild);
        TraversePreOrder(root.RightChild);
        Console.WriteLine(root.Value);
    }

    private bool IsEmpty()
    {
        return _root == null;
    }
}