using System.Text;

namespace DataStructures._02_LinkedLists;

public class CustomLinkedList
{
    private Node? _first;

    private Node? _last;

    private int _size;

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
            // Store the third element
            var k = j.Next;

            // The second element points to the first element
            j.Next = i;

            // Forward one position
            i = j;
            j = k;
        }

        // The last item points to the first item
        _last = _first;
        _last.Next = null;

        // The first element is now the last element
        _first = i;
    }

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

    public int GetSizeV2()
    {
        return _size;
    }

    private bool IsEmpty()
    {
        return _first == null;
    }

    private bool IsSingle()
    {
        return _first == _last;
    }
}