using DataStructures._01_Arrays;
using DataStructures._02_LinkedLists;
using DataStructures._03_Stacks;
using DataStructures._04_Queues;
using DataStructures._05_HashTables;
using DataStructures._06_Trees;
using DataStructures.Shared;

namespace DataStructures;

/// <summary>
/// Entry point for the DataStructures program.
/// </summary>
public static class DataStructures
{
    /// <summary>
    /// Main method to execute different data structure tests based on user input.
    /// </summary>
    public static void Main()
    {
        switch (GetOption().KeyChar)
        {
            case '1':
                ArrayTests.Execute();
                break;

            case '2':
                LinkedListTests.Execute();
                break;

            case '3':
                StackTests.Execute();
                break;

            case '4':
                QueueTests.Execute();
                break;

            case '5':
                HashTableTests.Execute();
                break;

            case '6':
                TreeTests.Execute();
                break;

            default:
                Console.WriteLine("Option not valid!");
                break;
        }

        Console.ReadLine();
    }

    /// <summary>
    /// Prompts the user to select a data structure option.
    /// </summary>
    /// <returns>The selected option as a ConsoleKeyInfo object.</returns>
    private static ConsoleKeyInfo GetOption()
    {
        ConsoleUtilities.PrintHeaderTitle("Data Structures Project");

        Console.Write("What data structure do you want to run? ");

        var input = Console.ReadKey();

        Console.Clear();

        return input;
    }
}