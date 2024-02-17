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
}