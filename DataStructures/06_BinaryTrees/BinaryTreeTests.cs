using DataStructures.Shared;

namespace DataStructures._06_BinaryTrees;

/// <summary>
/// Provides methods to test binary trees algorithms.
/// </summary>
public static class BinaryTreeTests
{
    /// <summary>
    /// Executes the binary tree tests.
    /// </summary>
    public static void Execute()
    {
        TestBinaryTree();
    }

    private static void TestBinaryTree()
    {
        ConsoleUtilities.PrintTitle("Binary Tree");

        var tree = new Tree();

        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(9);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(8);
        tree.Insert(10);

        tree.Print();

        Console.WriteLine($"\nIncludes the value {3}? >> {tree.Find(3)}");
        Console.WriteLine($"\nIncludes the value {10}? >> {tree.Find(10)}");
    }
}