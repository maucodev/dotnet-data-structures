using System.Text;

namespace DataStructures._04_Queues;

/// <summary>
/// Provides methods for reversing and printing a queue of strings.
/// </summary>
public static class StringReverser
{
    /// <summary>
    /// Reverses the order of elements in the specified queue.
    /// </summary>
    /// <param name="queue">The queue to reverse.</param>
    public static void Reverse(Queue<string> queue)
    {
        var stack = new Stack<string>();

        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }
    }

    /// <summary>
    /// Returns a string representation of the elements in the specified queue.
    /// </summary>
    /// <param name="queue">The queue to print.</param>
    /// <returns>A string representation of the queue.</returns>
    public static string Print(Queue<string> queue)
    {
        var result = new StringBuilder();

        foreach (var item in queue)
        {
            result.Append(item);
        }

        return result.ToString();
    }
}