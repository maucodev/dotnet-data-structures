using DataStructures.Shared;

namespace DataStructures._06_Trees;

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

    /// <summary>
    /// Calculates the height of the tree.
    /// </summary>
    /// <returns>The height of the tree.</returns>
    public int Height()
    {
        return Height(_root);
    }

    /// <summary>
    /// Finds the minimum value in a binary tree.
    /// </summary>
    /// <returns>The minimum value in the tree.</returns>
    public int MinBinaryTreeValue()
    {
        if (_root == null)
        {
            throw new InvalidOperationException("The tree is empty");
        }

        return Min(_root);
    }

    /// <summary>
    /// Finds the minimum value in a no binary tree.
    /// </summary>
    /// <returns>The minimum value in the tree.</returns>
    public int Min()
    {
        if (_root == null)
        {
            throw new InvalidOperationException("The tree is empty");
        }

        var current = _root;
        var last = current;

        while (current != null)
        {
            last = current;
            current = current.LeftChild;
        }

        return last.Value;
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

    private static int Height(TreeNode? root)
    {
        if (root == null)
        {
            return -1;
        }

        if (IsLeaf(root))
        {
            return 0;
        }

        return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
    }

    private static int Min(TreeNode? root)
    {
        if (IsLeaf(root))
        {
            return root?.Value ?? 0;
        }

        var minLeft = Min(root?.LeftChild);
        var minRight = Min(root?.RightChild);

        return Math.Min(Math.Min(minLeft, minRight), root?.Value ?? int.MaxValue);
    }

    private bool IsEmpty()
    {
        return _root == null;
    }

    private static bool IsLeaf(TreeNode? node)
    {
        return node?.LeftChild == null && node?.RightChild == null;
    }
}