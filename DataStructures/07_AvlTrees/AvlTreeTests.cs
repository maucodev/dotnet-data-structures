using DataStructures.Shared;

namespace DataStructures._07_AvlTrees;

/// <summary>
/// Provides methods to test AVL trees algorithms.
/// </summary>
public static class AvlTreeTests
{
    /// <summary>
    /// Executes the AVL tree tests.
    /// </summary>
    public static void Execute()
    {
        TestAvlTreeFunctions();
    }

    private static void TestAvlTreeFunctions()
    {
        ConsoleUtilities.PrintHeaderTitle("AVL Tree Functions");

        var tree = new AvlTree();

        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(30);
        tree.Insert(40);

        Console.WriteLine($"Is balanced: {tree.IsBalanced()}");
    }
}