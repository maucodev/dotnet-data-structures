using DataStructures.Shared;
using System.Text;

namespace DataStructures._04_Queues;

/// <summary>
/// Represents a queue implemented using a linked list.
/// </summary>
public class QueueWithLinkedList
{
    private Node? _headNode;
    private Node? _tailNode;
    private int _totalNodes;

    /// <summary>
    /// Adds an item to the end of the queue.
    /// </summary>
    /// <param name="item">The item to add to the queue.</param>
    public void Enqueue(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            _headNode = _tailNode = node;
            _totalNodes++;
            return;
        }

        _tailNode!.Next = node;
        _tailNode = node;
        _totalNodes++;
    }

    /// <summary>
    /// Removes and returns the item at the beginning of the queue.
    /// </summary>
    /// <returns>The item at the beginning of the queue.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
    public int Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        int value;

        if (_headNode == _tailNode)
        {
            value = _headNode!.Value;
            _headNode = _tailNode = null;
        }
        else
        {
            value = _headNode!.Value;
            var nextNode = _headNode.Next;
            _headNode.Next = null;
            _headNode = nextNode;
        }

        _totalNodes--;

        return value;
    }

    /// <summary>
    /// Returns the item at the beginning of the queue without removing it.
    /// </summary>
    /// <returns>The item at the beginning of the queue.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the queue is empty.</exception>
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        return _headNode?.Value ?? throw new InvalidOperationException("Something was wrong.");
    }

    /// <summary>
    /// Checks whether the queue is empty.
    /// </summary>
    /// <returns>True if the queue is empty, otherwise false.</returns>
    public bool IsEmpty()
    {
        return _totalNodes == 0;
    }

    /// <summary>
    /// Gets the number of items in the queue.
    /// </summary>
    /// <returns>The number of items in the queue.</returns>
    public int Size()
    {
        return _totalNodes;
    }

    /// <summary>
    /// Returns a string representation of the queue.
    /// </summary>
    /// <returns>A string representing the contents of the queue.</returns>
    public override string ToString()
    {
        if (IsEmpty())
        {
            return "[ ]\n";
        }

        var current = _headNode;
        var contentResult = new StringBuilder("[ ");

        while (current != null)
        {
            contentResult.Append($"{current.Value} ");
            current = current.Next;
        }

        contentResult.Append(']');

        return contentResult.ToString();
    }
}