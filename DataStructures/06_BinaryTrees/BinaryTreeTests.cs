using DataStructures.Shared;

namespace DataStructures._06_BinaryTrees;

public static class BinaryTreeTests
{
    public static void Execute()
    {
        InsertTest();
        FindTest();
        TraverseBinaryTreeTest();
        HeightTest();
    }

    private static void InsertTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Insert");

        var binaryTree = new BinaryTree();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(6);
        binaryTree.Insert(1);
        binaryTree.Insert(8);
        binaryTree.Insert(12);
        binaryTree.Insert(18);
        binaryTree.Insert(17);

        ConsoleUtilities.PrintFooter();
    }

    private static void FindTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Find");

        var binaryTree = new BinaryTree();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(6);
        binaryTree.Insert(1);
        binaryTree.Insert(8);
        binaryTree.Insert(12);
        binaryTree.Insert(18);
        binaryTree.Insert(17);

        Console.WriteLine($"The number {33} is in the tree? {binaryTree.Find(33)}");
        Console.WriteLine($"The number {17} is in the tree? {binaryTree.Find(17)}");

        ConsoleUtilities.PrintFooter();
    }

    private static void TraverseBinaryTreeTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Traverse Binary Tree");

        var binaryTree = new BinaryTree();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(6);
        binaryTree.Insert(1);
        binaryTree.Insert(8);
        binaryTree.Insert(12);
        binaryTree.Insert(18);
        binaryTree.Insert(17);

        Console.WriteLine("Pre Order");
        binaryTree.TraversePreOrder();

        Console.WriteLine("In Order");
        binaryTree.TraverseInOrder();

        Console.WriteLine("Post Order");
        binaryTree.TraversePostOrder();

        ConsoleUtilities.PrintFooter();
    }

    private static void HeightTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Height");

        var binaryTree = new BinaryTree();

        binaryTree.Insert(10);
        binaryTree.Insert(5);
        binaryTree.Insert(15);
        binaryTree.Insert(6);
        binaryTree.Insert(1);
        binaryTree.Insert(8);
        binaryTree.Insert(12);
        binaryTree.Insert(18);
        binaryTree.Insert(17);

        Console.WriteLine($"The binary tree height is {binaryTree.Height()}");

        ConsoleUtilities.PrintFooter();
    }
}