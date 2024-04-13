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
}