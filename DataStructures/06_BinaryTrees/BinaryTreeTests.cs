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
        MinTest();
        MinBinarySearchTreeTest();
        EqualsTest();
        IsBinarySearchTreeTest();
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

    private static void MinTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Min");

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

        Console.WriteLine($"The min value is {binaryTree.Min()}");

        ConsoleUtilities.PrintFooter();
    }

    private static void MinBinarySearchTreeTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Min/Max Binary Search Tree");

        var binarySearchTree = new BinaryTree();

        binarySearchTree.Insert(10);
        binarySearchTree.Insert(5);
        binarySearchTree.Insert(15);
        binarySearchTree.Insert(6);
        binarySearchTree.Insert(1);
        binarySearchTree.Insert(8);
        binarySearchTree.Insert(12);
        binarySearchTree.Insert(18);
        binarySearchTree.Insert(17);

        binarySearchTree.SwapRoot();

        Console.WriteLine($"The min value is {binarySearchTree.MinInBinarySearchTree()}");

        Console.WriteLine($"The max value is {binarySearchTree.MaxInBinarySearchTree()}");

        ConsoleUtilities.PrintFooter();
    }

    private static void EqualsTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Equals");

        var binaryTreeOne = new BinaryTree();
        var binaryTreeTwo = new BinaryTree();

        binaryTreeOne.Insert(10);
        binaryTreeOne.Insert(5);
        binaryTreeOne.Insert(15);
        binaryTreeOne.Insert(6);
        binaryTreeOne.Insert(1);
        binaryTreeOne.Insert(8);
        binaryTreeOne.Insert(12);
        binaryTreeOne.Insert(18);
        binaryTreeOne.Insert(17);

        binaryTreeTwo.Insert(10);
        binaryTreeTwo.Insert(5);
        binaryTreeTwo.Insert(15);
        binaryTreeTwo.Insert(6);
        binaryTreeTwo.Insert(1);
        binaryTreeTwo.Insert(8);
        binaryTreeTwo.Insert(12);
        binaryTreeTwo.Insert(18);
        binaryTreeTwo.Insert(17);

        Console.WriteLine($"Are equals? {binaryTreeOne.Equals(binaryTreeTwo)}");

        ConsoleUtilities.PrintFooter();
    }

    private static void IsBinarySearchTreeTest()
    {
        ConsoleUtilities.PrintHeaderTitle("Testing: Is Binary Search Tree");

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

        Console.WriteLine($"Is binary search tree? {binaryTree.IsBinarySearchTree()}");

        binaryTree.SwapRoot();

        Console.WriteLine($"Is binary search tree? {binaryTree.IsBinarySearchTree()}");

        ConsoleUtilities.PrintFooter();
    }
}