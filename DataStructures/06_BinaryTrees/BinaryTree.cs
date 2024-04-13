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
}