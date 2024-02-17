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

    private static Node? Balance(Node? root)
    {
        if (IsLeftHeavy(root))
        {
            if (BalanceFactor(root?.LeftChild) < 0 && root?.LeftChild != null)
            {
                root.LeftChild = RotateLeft(root.LeftChild);
            }

            return RotateRight(root);
        }

        if (!IsRightHeavy(root))
        {
            // The node is in balance
            return root;
        }

        if (BalanceFactor(root?.RightChild) > 0 && root?.RightChild != null)
        {
            root.RightChild = RotateRight(root.RightChild);
        }

        return RotateLeft(root);
    }

    private static int BalanceFactor(Node? node)
    {
        return node == null 
            ? 0 
            : Height(node.LeftChild) - Height(node.RightChild);
    }

    private static int Height(Node? node)
    {
        return node?.Height ?? -1;
    }

    private static bool IsLeftHeavy(Node? node)
    {
        return BalanceFactor(node) > 1;
    }

    private static bool IsRightHeavy(Node? node)
    {
        return BalanceFactor(node) < -1;
    }

    private static Node? Insert(Node? root, int value)
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

        SetHeight(root);

        root = Balance(root);

        return root;
    }

    private static Node? RotateLeft(Node? root)
    {
        var newRoot = root?.RightChild;

        if (root != null)
        {
            root.RightChild = newRoot?.LeftChild;

            if (newRoot == null)
            {
                return newRoot;
            }

            newRoot.LeftChild = root;

            SetHeight(root);
        }

        SetHeight(newRoot);

        return newRoot;
    }

    private static Node? RotateRight(Node? root)
    {
        var newRoot = root?.LeftChild;

        if (root != null)
        {
            root.LeftChild = newRoot?.RightChild;

            if (newRoot == null)
            {
                return newRoot;
            }

            newRoot.RightChild = root;

            SetHeight(root);
        }

        SetHeight(newRoot);

        return newRoot;
    }

    private static void SetHeight(Node? node)
    {
        if (node == null)
        {
            return;
        }

        node.Height = Math.Max(Height(node.LeftChild), Height(node.RightChild)) + 1;
    }
}