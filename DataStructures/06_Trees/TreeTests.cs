using DataStructures.Shared;

namespace DataStructures._06_Trees;

/// <summary>
/// Provides methods to test binary trees algorithms.
/// </summary>
public static class TreeTests
{
    /// <summary>
    /// Executes the binary tree tests.
    /// </summary>
    public static void Execute()
    {
        TestBinaryTree();
        TestTreeTraversal();
        TestEquals();
        TestValidatingBinarySearchTree();
        TestKDistanceFromRoot();
        TestLevelOrderTraversal();
        TestBinaryTreeFunctions();
    }

    private static void TestBinaryTree()
    {
        ConsoleUtilities.PrintHeaderTitle("Binary Tree");

        var tree = new Tree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        Console.WriteLine($"\nIncludes the value {3}? >> {tree.Find(3)}");
        Console.WriteLine($"\nIncludes the value {10}? >> {tree.Find(10)}");
    }

    private static void TestTreeTraversal()
    {
        ConsoleUtilities.PrintHeaderTitle("Tree Traversal");

        var tree = new Tree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        tree.TraversePreOrder();

        tree.TraverseInOrder();

        tree.TraversePostOrder();

        Console.WriteLine($"\nThe height of the tree is: {tree.Height()}");

        Console.WriteLine($"\nThe min value (binary tree) is: {tree.MinBinaryTreeValue()}");

        Console.WriteLine($"\nThe min value (no binary tree) is: {tree.Min()}");
    }

    private static void TestEquals()
    {
        ConsoleUtilities.PrintHeaderTitle("Equals");

        var tree = new Tree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        var copyTree = new Tree();

        copyTree.Insert(7);
        copyTree.Insert(4);
        copyTree.Insert(9);
        copyTree.Insert(1);
        copyTree.Insert(6);
        copyTree.Insert(8);
        copyTree.Insert(10);

        Console.WriteLine($"\nAre equals: {tree.Equals(copyTree)}");

        Console.WriteLine($"\nAre equals: {tree.Equals(new Tree())}");

        Console.WriteLine($"\nAre equals: {tree.Equals(null)}");
    }

    private static void TestValidatingBinarySearchTree()
    {
        ConsoleUtilities.PrintHeaderTitle("Validating Binary Search Tree");

        var tree = new Tree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        Console.WriteLine($"\nIs a valid BST: {tree.IsBinarySearchTree()}");

        tree.SwapRoot();

        Console.WriteLine($"\nIs a valid BST: {tree.IsBinarySearchTree()}");
    }

    private static void TestKDistanceFromRoot()
    {
        ConsoleUtilities.PrintHeaderTitle("K Distance From Root");

        var tree = new Tree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        Console.WriteLine($"\nNodes at 0 distance: {tree.GetNodesAtKDistance(0)}");

        Console.WriteLine($"\nNodes at 1 distance: {tree.GetNodesAtKDistance(1)}");

        Console.WriteLine($"\nNodes at 2 distance: {tree.GetNodesAtKDistance(2)}");
    }

    private static void TestLevelOrderTraversal()
    {
        ConsoleUtilities.PrintHeaderTitle("Level Order Traversal");

        var tree = new Tree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        tree.TraverseLevelOrder();
    }

    private static void TestBinaryTreeFunctions()
    {
        ConsoleUtilities.PrintHeaderTitle("Binary Tree Functions");

        var tree = new BinaryTree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        Console.WriteLine($"The size is: {tree.Size()}\n");

        Console.WriteLine($"The total leaves is: {tree.TotalLeaves()}\n");

        Console.WriteLine($"The max value is: {tree.Max()}\n");

        Console.WriteLine($"Contains the 9 value: {tree.Contains(9)}\n");

        Console.WriteLine($"Contains the 15 value: {tree.Contains(15)}\n");

        Console.WriteLine($"Are 7 and 1 sibling: {tree.AreSibling(7, 1)}\n");

        Console.WriteLine($"Are 8 and 10 sibling: {tree.AreSibling(8, 10)}\n");

        Console.WriteLine($"The ancestors of 10 are: {tree.GetAncestors(10)}\n");

        Console.WriteLine($"Is a perfect tree: {tree.IsPerfect()}\n");

        tree.Insert(11);

        Console.WriteLine($"Is a perfect tree: {tree.IsPerfect()}\n");
    }
}