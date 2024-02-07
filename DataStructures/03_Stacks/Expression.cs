namespace DataStructures._03_Stacks;

public static class Expression
{
    private static readonly List<char> LeftBrackets = ['(', '<', '[', '{'];
    private static readonly List<char> RightBrackets = [')', '>', ']', '}'];

    public static bool IsBalanced(string expression)
    {
        ArgumentNullException.ThrowIfNull(nameof(expression));

        var stack = new Stack<char>();

        foreach (var ch in expression)
        {
            if (IsLeftBracket(ch))
            {
                stack.Push(ch);
            }

            if (IsRightBracket(ch))
            {
                if (!stack.TryPop(out char top))
                {
                    return false;
                }

                if (!BracketsMatch(top, ch))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    private static bool IsLeftBracket(char ch)
    {
        return LeftBrackets.Contains(ch);
    }

    private static bool IsRightBracket(char ch)
    {
        return RightBrackets.Contains(ch);
    }

    private static bool BracketsMatch(char left, char right)
    {
        return LeftBrackets.IndexOf(left) == RightBrackets.IndexOf(right);
    }
}