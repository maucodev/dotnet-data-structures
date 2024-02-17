using System.Text;
using DataStructures.Shared;

namespace DataStructures._06_Trees;

/// <summary>
/// Represents a binary tree data structure.
/// </summary>
public class BinaryTree : Tree
{
    /// <summary>
    /// Checks whether two given values are siblings in the tree.
    /// </summary>
    /// <param name="first">The first value.</param>
    /// <param name="second">The second value.</param>
    /// <returns><c>true</c> if the values are siblings; otherwise, <c>false</c>.</returns>
    public bool AreSibling(int first, int second)
    {
        return AreSibling(Root, first, second);
    }

    /// <summary>
    /// Checks if the tree contains a specific value.
    /// </summary>
    /// <param name="value">The value to check for.</param>
    /// <returns><c>true</c> if the value is found in the tree; otherwise, <c>false</c>.</returns>
    public bool Contains(int value)
    {
        return Contains(Root, value);
    }

    /// <summary>
    /// Retrieves the ancestors of a node with the specified value in the tree.
    /// </summary>
    /// <param name="value">The value of the node whose ancestors to retrieve.</param>
    /// <returns>A string containing the values of the ancestors of the specified node.</returns>
    public string GetAncestors(int value)
    {
        var result = new StringBuilder("[");

        GetAncestors(Root, value, result);

        result.Append(']');

        return result.ToString();
    }

    /// <summary>
    /// Finds the maximum value in the tree.
    /// </summary>
    /// <returns>The maximum value in the tree.</returns>
    public int Max()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("The tree is empty");
        }

        return Max(Root);
    }

    /// <summary>
    /// Calculates the number of nodes in the tree.
    /// </summary>
    /// <returns>The number of nodes in the tree.</returns>
    public int Size()
    {
        return Size(Root);
    }

    /// <summary>
    /// Counts the total number of leaf nodes in the tree.
    /// </summary>
    /// <returns>The total number of leaf nodes in the tree.</returns>
    public int TotalLeaves()
    {
        return TotalLeaves(Root);
    }

    private static bool GetAncestors(TreeNode? root, int value, StringBuilder stringBuilder)
    {
        if (root == null)
        {
            return false;
        }

        if (root.Value == value)
        {
            return true;
        }

        if (!GetAncestors(root.LeftChild, value, stringBuilder) &&
            !GetAncestors(root.RightChild, value, stringBuilder))
        {
            return false;
        }

        stringBuilder.Append($" {root.Value} ");

        return true;
    }

    private static bool AreSibling(TreeNode? root, int first, int second)
    {
        if (root == null)
        {
            return false;
        }

        var result = false;

        if (root is { LeftChild: not null, RightChild: not null })
        {
            result = (root.LeftChild.Value == first && root.RightChild.Value == second) ||
                     (root.RightChild.Value == first && root.LeftChild.Value == second);
        }

        return result || 
               AreSibling(root.LeftChild, first, second) || 
               AreSibling(root.RightChild, first, second);
    }

    private static bool Contains(TreeNode? root, int value)
    {
        if (root == null)
        {
            return false;
        }

        if (root.Value == value)
        {
            return true;
        }

        return Contains(root.LeftChild, value) || Contains(root.RightChild, value);
    }

    private static int Max(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        return root.RightChild == null 
            ? root.Value 
            : Max(root.RightChild);
    }

    private static int Size(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        if (IsLeaf(root))
        {
            return 1;
        }

        return 1 + Size(root.LeftChild) + Size(root.RightChild);
    }

    private static int TotalLeaves(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        if (IsLeaf(root))
        {
            return 1;
        }

        return TotalLeaves(root.LeftChild) + TotalLeaves(root.RightChild);
    }
}