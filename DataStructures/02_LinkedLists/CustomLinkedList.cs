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
        }

        if (_last != null)
        {
            _last.Next = node;
        }

        _last = node;
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
        Console.WriteLine();
    }

    private bool IsEmpty()
    {
        return _first == null && _last == null;
    }
}