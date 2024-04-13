#pragma warning disable S1206
#pragma warning disable CS0659

namespace DataStructures._06_BinaryTrees;

public class BinaryTree
{
    private BinaryTreeNode? _root;

    public void Insert(int value)
    {
        var node = new BinaryTreeNode(value);

        if (_root is null)
        {
            _root = node;
            return;
        }

        var current = _root;

        while (true)
        {
            if (value < current?.Value)
            {
                if (current.LeftChild is null)
                {
                    current.LeftChild = node;
                    break;
                }

                current = current.LeftChild;
            }
            else
            {
                if (current is not null && current.RightChild is null)
                {
                    current.RightChild = node;
                    break;
                }

                current = current?.RightChild;
            }
        }
    }

    public bool Find(int value)
    {
        var current = _root;

        while (current is not null)
        {
            if (value < current.Value)
            {
                current = current.LeftChild;
            }
            else if (value > current.Value)
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

    public void TraversePreOrder()
    {
        TraversePreOrder(_root);
    }

    public void TraverseInOrder()
    {
        TraverseInOrder(_root);
    }

    public void TraversePostOrder()
    {
        TraversePostOrder(_root);
    }

    public int Height()
    {
        return Height(_root);
    }

    public int Min()
    {
        return Min(_root);
    }

    public int MinInBinarySearchTree()
    {
        return MinInBinarySearchTree(_root);
    }

    public int MaxInBinarySearchTree()
    {
        return MaxInBinarySearchTree(_root);
    }

    public bool IsBinarySearchTree()
    {
        return IsBinarySearchTree(_root, int.MinValue, int.MaxValue);
    }

    public void SwapRoot()
    {
        if (_root is not null)
        {
            (_root.RightChild, _root.LeftChild) = (_root.LeftChild, _root.RightChild);
        }
    }

    public override bool Equals(object? obj)
    {
        return AreEquals(_root, (obj as BinaryTree)?._root);
    }

    private static void TraversePreOrder(BinaryTreeNode? root)
    {
        if (root is null)
        {
            return;
        }

        Console.WriteLine(root);

        TraversePreOrder(root.LeftChild);

        TraversePreOrder(root.RightChild);
    }

    private static void TraverseInOrder(BinaryTreeNode? root)
    {
        if (root is null)
        {
            return;
        }

        TraversePreOrder(root.LeftChild);

        Console.WriteLine(root);

        TraversePreOrder(root.RightChild);
    }

    private static void TraversePostOrder(BinaryTreeNode? root)
    {
        if (root is null)
        {
            return;
        }

        TraversePreOrder(root.LeftChild);

        TraversePreOrder(root.RightChild);

        Console.WriteLine(root);
    }

    private static int Height(BinaryTreeNode? root)
    {
        if (root is null)
        {
            return -1;
        }

        if (IsLeaf(root))
        {
            return 0;
        }

        return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
    }

    private static int Min(BinaryTreeNode? root)
    {
        if (root is null)
        {
            return int.MaxValue;
        }

        if (IsLeaf(root))
        {
            return root.Value;
        }

        var minLeft = Min(root.LeftChild);
        var minRight = Min(root.RightChild);
        var minChildren = Math.Min(minLeft, minRight);

        return Math.Min(minChildren, root.Value);
    }

    private static int MinInBinarySearchTree(BinaryTreeNode? root)
    {
        ArgumentNullException.ThrowIfNull(root);

        var current = root;
        var last = current;

        while (current is not null)
        {
            last = current;
            current = current.LeftChild;
        }

        return last.Value;
    }

    private static int MaxInBinarySearchTree(BinaryTreeNode? root)
    {
        ArgumentNullException.ThrowIfNull(root);

        var current = root;
        var last = current;

        while (current is not null)
        {
            last = current;
            current = current.RightChild;
        }

        return last.Value;
    }

    private static bool IsLeaf(BinaryTreeNode? root)
    {
        return root?.LeftChild is null &&
               root?.RightChild is null;
    }

    private static bool AreEquals(BinaryTreeNode? first, BinaryTreeNode? second)
    {
        if (first is null && second is null)
        {
            return true;
        }

        if (first is not null && second is not null)
        {
            return first.Value == second.Value &&
                   AreEquals(first.LeftChild, second.LeftChild) &&
                   AreEquals(first.RightChild, second.RightChild);
        }

        return false;
    }

    private static bool IsBinarySearchTree(BinaryTreeNode? root, int minValue, int maxValue)
    {
        if (root is null)
        {
            return true;
        }

        if (root.Value < minValue || root.Value > maxValue)
        {
            return false;
        }

        return IsBinarySearchTree(root.LeftChild, minValue, root.Value - 1) &&
               IsBinarySearchTree(root.RightChild, root.Value + 1, maxValue);
    }
}