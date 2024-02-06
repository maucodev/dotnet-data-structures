namespace DataStructures._03_Stacks;

public static class Expression
{
    public static bool IsBalanced(string expression)
    {
        ArgumentNullException.ThrowIfNull(nameof(expression));

        var stack = new Stack<char>();

        foreach (var character in expression)
        {
            if (character == '(')
            {
                stack.Push(character);
            }

            if (character == ')' && !stack.TryPop(out _))
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}