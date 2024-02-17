using System.Text;
using DataStructures.Shared;

namespace DataStructures._06_Trees;

/// <summary>
/// Represents a tree data structure.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S3897:Classes that provide \"Equals(<T>)\" should implement \"IEquatable<T>\"", Justification = "We are building our method.")]
#pragma warning disable S4035
public class Tree
#pragma warning restore S4035
{
    internal TreeNode? Root;

    /// <summary>
    /// Inserts a value to the tree.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    public void Insert(int value)
    {
        var node = new TreeNode(value);

        if (IsEmpty())
        {
            Root = node;
            return;
        }

        var current = Root;

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
        var current = Root;

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
        TraversePreOrder(Root);
    }

    /// <summary>
    /// Performs an in-order traversal of the tree.
    /// </summary>
    public void TraverseInOrder()
    {
        Console.WriteLine("\nTraverse In-Order...\n");
        TraverseInOrder(Root);
    }

    /// <summary>
    /// Performs a post-order traversal of the tree.
    /// </summary>
    public void TraversePostOrder()
    {
        Console.WriteLine("\nTraverse Post-Order...\n");
        TraversePostOrder(Root);
    }

    /// <summary>
    /// Calculates the height of the tree.
    /// </summary>
    /// <returns>The height of the tree.</returns>
    public int Height()
    {
        return Height(Root);
    }

    /// <summary>
    /// Finds the minimum value in a binary tree.
    /// </summary>
    /// <returns>The minimum value in the tree.</returns>
    public int MinBinaryTreeValue()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("The tree is empty");
        }

        return Min(Root);
    }

    /// <summary>
    /// Finds the minimum value in a no binary tree.
    /// </summary>
    /// <returns>The minimum value in the tree.</returns>
    public int Min()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("The tree is empty");
        }

        var current = Root;
        var last = current;

        while (current != null)
        {
            last = current;
            current = current.LeftChild;
        }

        return last.Value;
    }

    /// <summary>
    /// Checks if the current tree is equal to another tree.
    /// </summary>
    /// <param name="other">The tree to compare with.</param>
    /// <returns><c>true</c> if the trees are equal; otherwise, <c>false</c>.</returns>
    public bool Equals(Tree? other)
    {
        return other != null && Equals(Root, other.Root);
    }

    /// <summary>
    /// Checks whether the tree is a binary search tree (BST).
    /// </summary>
    /// <returns><c>true</c> if the tree is a binary search tree; otherwise, <c>false</c>.</returns>
    public bool IsBinarySearchTree()
    {
        return IsBinarySearchTree(Root, int.MinValue, int.MaxValue);
    }

    /// <summary>
    /// Swaps the root node of the tree with its left child.
    /// </summary>
    public void SwapRoot()
    {
        var relay = Root?.LeftChild;

        if (Root == null)
        {
            return;
        }

        Root.LeftChild = Root.RightChild;
        Root.RightChild = relay;
    }

    /// <summary>
    /// Gets the nodes at distance k from the root node.
    /// </summary>
    /// <param name="k">The distance from the root node.</param>
    public string GetNodesAtKDistance(int k)
    {
        var result = new StringBuilder("[");

        GetNodesAtKDistance(Root, k, result);

        result.Append(']');

        return result.ToString();
    }

    /// <summary>
    /// Performs a level-order traversal of the tree.
    /// </summary>
    public void TraverseLevelOrder()
    {
        for (var i = 0; i <= Height(); i++)
        {
            Console.WriteLine($"\nNodes at level {i}: {GetNodesAtKDistance(i)}");
        }
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

    private static bool Equals(TreeNode? first, TreeNode? second)
    {
        if (first == null && second == null)
        {
            return true;
        }

        if (first != null && second != null)
        {
            return first.Value == second.Value && 
                   Equals(first.LeftChild, second.LeftChild) && 
                   Equals(first.RightChild, second.RightChild);
        }

        return false;
    }

    private static bool IsBinarySearchTree(TreeNode? root, int min, int max)
    {
        if (root == null)
        {
            return true;
        }

        if (root.Value < min || root.Value > max)
        {
            return false;
        }

        return IsBinarySearchTree(root.LeftChild, min, root.Value - 1) && 
               IsBinarySearchTree(root.RightChild, root.Value + 1, max);
    }

    private static void GetNodesAtKDistance(TreeNode? root, int k, StringBuilder stringBuilder)
    {
        if (root == null)
        {
            return;
        }

        if (k == 0)
        {
            stringBuilder.Append($" {root.Value} ");
            return;
        }

        GetNodesAtKDistance(root.LeftChild, k - 1, stringBuilder);

        GetNodesAtKDistance(root.RightChild, k - 1, stringBuilder);
    }

    private bool IsEmpty()
    {
        return Root == null;
    }

    internal static bool IsLeaf(TreeNode? node)
    {
        return node?.LeftChild == null && node?.RightChild == null;
    }
}