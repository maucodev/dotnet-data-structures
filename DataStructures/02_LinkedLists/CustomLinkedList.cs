using System.Text;

namespace DataStructures._02_LinkedLists;

public class CustomLinkedList
{
    private Node? _first;

    private Node? _last;

    public void AddFirst(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            _first = _last = node;

            return;
        }

        node.Next = _first;

        _first = node;
    }

    public void AddLast(int item)
    {
        var node = new Node(item);

        if (IsEmpty())
        {
            _first = _last = node;

            return;
        }

        if (_last != null)
        {
            _last.Next = node;
        }

        _last = node;
    }

    public bool Contains(int item)
    {
        return IndexOf(item) != -1;
    }

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

    public void RemoveFirst()
    {
        if (IsEmpty())
        {
            return;
        }

        if (_first == _last)
        {
            _first = _last = null;
            return;
        }

        var secondNode = _first!.Next;

        _first.Next = null;

        _first = secondNode;
    }

    private bool IsEmpty()
    {
        return _first == null;
    }
}