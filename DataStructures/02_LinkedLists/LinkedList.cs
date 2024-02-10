using System.Text;
using DataStructures.Shared;

namespace DataStructures._02_LinkedLists;

/// <summary>
/// Represents a custom linked list data structure.
/// </summary>
public class LinkedList
{
    private Node? _first;
    private Node? _last;
    private int _size;

    /// <summary>
    /// Adds an item to the beginning of the linked list.
    /// </summary>
    /// <param name="item">The item to be added.</param>
    public void AddFirst(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            _first = _last = node;
            _size++;
            return;
        }

        node.Next = _first;
        _first = node;
        _size++;
    }

    /// <summary>
    /// Adds an item to the end of the linked list.
    /// </summary>
    /// <param name="item">The item to be added.</param>
    public void AddLast(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            _first = _last = node;
            _size++;
            return;
        }

        if (_last != null)
        {
            _last.Next = node;
        }

        _last = node;
        _size++;
    }

    /// <summary>
    /// Checks if the linked list contains the specified item.
    /// </summary>
    /// <param name="item">The item to search for.</param>
    /// <returns>True if the item is found, otherwise false.</returns>
    public bool Contains(int item)
    {
        return IndexOf(item) != -1;
    }

    /// <summary>
    /// Gets the value of the kth node from the end of the linked list.
    /// </summary>
    /// <param name="k">The index of the node from the end.</param>
    /// <returns>The value of the kth node from the end.</returns>
    /// <exception cref="ArgumentException">Thrown when the specified k value is invalid.</exception>
    public int GetKthFromTheEnd(int k)
    {
        if (k > _size || k <= 0)
        {
            throw new ArgumentException("The k value must be greater than 0 and less than or equal to the size of the list.");
        }

        var a = _first;
        var b = _first;

        for (var i = 0; i < k - 1; i++)
        {
            b = b?.Next;

            if (b == null)
            {
                throw new ArgumentException("The k value must be less than or equal to the size of the list.");
            }
        }

        while (b != _last)
        {
            a = a?.Next;
            b = b?.Next;
        }

        return a!.Value;
    }

    /// <summary>
    /// Checks if the linked list contains a loop.
    /// </summary>
    /// <param name="createLoop">Flag to create a loop in the list for testing purposes.</param>
    /// <returns>True if the linked list contains a loop, otherwise false.</returns>
    public bool HasLoop(bool createLoop = false)
    {
        if (IsEmpty() || IsSingle())
        {
            return false;
        }

        if (createLoop)
        {
            _last!.Next = _first?.Next;
        }

        var slow = _first;
        var fast = _first;

        while (fast?.Next != null)
        {
            slow = slow?.Next;
            fast = fast.Next.Next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// Returns the index of the first occurrence of the specified item in the linked list.
    /// </summary>
    /// <param name="item">The item to search for.</param>
    /// <returns>The index of the item if found; otherwise, -1.</returns>
    public int IndexOf(int item)
    {
        var index = 0;
        var current = _first;

        while (current != null)
        {
            if (current.Value == item)
            {
                return index;
            }

            current = current.Next;
            index++;
        }

        return -1;
    }

    /// <summary>
    /// Prints the elements of the linked list.
    /// </summary>
    public void Print()
    {
        var current = _first;
        var contentResult = new StringBuilder("[ ");

        while (current != null)
        {
            contentResult.Append($"{current.Value} ");
            current = current.Next;
        }

        contentResult.Append(']');

        Console.WriteLine($"{contentResult}\n");
    }

    /// <summary>
    /// Prints the middle element(s) of the linked list.
    /// </summary>
    public void PrintMiddle()
    {
        if (IsEmpty())
        {
            Console.WriteLine("[ ]\n");
            return;
        }

        if (IsSingle())
        {
            Console.WriteLine($"[ {_first!.Value} ]\n");
            return;
        }

        var a = _first;
        var b = _first;

        while (b != null && b != _last && b.Next != _last)
        {
            a = a?.Next;
            b = b.Next?.Next;
        }

        Console.WriteLine(b == _last ? $"[ {a!.Value} ]\n" : $"[ {a!.Value} {a.Next!.Value} ]\n");
    }

    /// <summary>
    /// Removes the first node from the linked list.
    /// </summary>
    public void RemoveFirst()
    {
        if (IsEmpty())
        {
            return;
        }

        if (IsSingle())
        {
            EmptyList();
            return;
        }

        var secondNode = _first!.Next;
        _first.Next = null;
        _first = secondNode;
        _size--;
    }

    /// <summary>
    /// Removes the last node from the linked list.
    /// </summary>
    public void RemoveLast()
    {
        if (IsEmpty())
        {
            return;
        }

        if (IsSingle())
        {
            EmptyList();
            return;
        }

        var previous = GetPrevious(_last);

        if (previous == null)
        {
            return;
        }

        _last = previous;
        _last.Next = null;
        _size--;
    }

    /// <summary>
    /// Reverses the elements of the linked list.
    /// </summary>
    public void Reverse()
    {
        if (IsEmpty() || IsSingle())
        {
            return;
        }

        var i = _first;
        var j = _first!.Next;

        while (j != null)
        {
            var k = j.Next;
            j.Next = i;
            i = j;
            j = k;
        }

        _last = _first;
        _last.Next = null;
        _first = i;
    }

    /// <summary>
    /// Converts the linked list to an array.
    /// </summary>
    /// <returns>An array containing the elements of the linked list.</returns>
    public int[] ToArray()
    {
        var array = new int[_size];
        var index = 0;
        var current = _first;

        while (current != null)
        {
            array[index++] = current.Value;
            current = current.Next;
        }

        return array;
    }

    private void EmptyList()
    {
        _first = _last = null;
        _size = 0;
    }

    private Node? GetPrevious(Node? node)
    {
        var current = _first;

        while (current != null)
        {
            if (current.Next == node)
            {
                return current;
            }

            current = current.Next;
        }

        return null;
    }

    private bool IsEmpty()
    {
        return _first == null;
    }

    private bool IsSingle()
    {
        return _first == _last;
    }

    /// <summary>
    /// Gets the size of the linked list.
    /// </summary>
    /// <returns>The size of the linked list.</returns>
    public int GetSize()
    {
        if (IsEmpty())
        {
            return 0;
        }

        if (IsSingle())
        {
            return 1;
        }

        var size = 0;
        var current = _first;

        while (current != null)
        {
            current = current.Next;
            size++;
        }

        return size;
    }

    /// <summary>
    /// Gets the size of the linked list.
    /// </summary>
    /// <returns>The size of the linked list.</returns>
    public int GetSizeV2()
    {
        return _size;
    }
}