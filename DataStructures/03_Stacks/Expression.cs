namespace DataStructures._03_Stacks
{
    /// <summary>
    /// Provides methods to evaluate the balance of expressions containing brackets using a stack data structure.
    /// </summary>
    public static class Expression
    {
        private static readonly List<char> LeftBrackets = ['(', '<', '[', '{'];
        private static readonly List<char> RightBrackets = [')', '>', ']', '}'];

        /// <summary>
        /// Checks if the given expression has balanced brackets.
        /// </summary>
        /// <param name="expression">The expression to be checked.</param>
        /// <returns>True if the brackets in the expression are balanced, otherwise false.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the expression is null.</exception>
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

                if (!IsRightBracket(ch))
                {
                    continue;
                }

                if (!stack.TryPop(out var top))
                {
                    return false;
                }

                if (!BracketsMatch(top, ch))
                {
                    return false;
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
}
