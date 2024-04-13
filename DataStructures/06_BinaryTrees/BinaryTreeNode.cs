namespace DataStructures._06_BinaryTrees;

public class BinaryTreeNode(int value)
{
    public int Value { get; set; } = value;

    public BinaryTreeNode? LeftChild { get; set; }

    public BinaryTreeNode? RightChild { get; set;}

    public override string ToString()
    {
        return Value.ToString();
    }
}