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
    /// Prints the tree with its nodes and leaves using inorder traversal.
    /// </summary>
    public void Print()
    {
        PrintInorder(_root);
    }

    private bool IsEmpty()
    {
        return _root == null;
    }

    private void PrintInorder(TreeNode? node)
    {
        while (true)
        {
            if (node == null)
            {
                return;
            }

            PrintInorder(node.LeftChild);

            Console.WriteLine(_root != null && node.Value == _root.Value 
                ? $"<Root>: {node.Value}" 
                : $"Node: {node.Value}");

            node = node.RightChild;
        }
    }
}