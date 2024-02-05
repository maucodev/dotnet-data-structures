namespace DataStructures._02_LinkedLists;

public class CustomLinkedList
{
    private Node? _first;

    private Node? _last;

    public void AddLast(int item)
    {
        var node = new Node(item);

        if (_first == null)
        {
            _first = _last = node;
        }

        if (_last != null)
        {
            _last.Next = node;
        }

        _last = node;
    }

    public void Print()
    {
        Console.WriteLine();
    }
}