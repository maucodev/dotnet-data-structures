using System.Text;

namespace DataStructures._03_Stacks;

public static class StringReverser
{
    public static string Reverse(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        var stack = new Stack<char>();

        foreach (var item in input)
        {
            stack.Push(item);
        }

        var result = new StringBuilder();

        while (stack.Count > 0)
        {
            result.Append(stack.Pop());
        }

        return result.ToString();
    }
}