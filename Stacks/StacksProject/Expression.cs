using System.Collections.Generic;

namespace StacksProject;

/// <summary>
/// Represents an expression and provides methods to check if the brackets in the expression are balanced.
/// </summary>
public class Expression
{
    private readonly Stack<char> _stack = new();
    private readonly List<char> _leftBrackets = ['(', '<', '[', '{'];
    private readonly List<char> _rightBrackets = [')', '>', ']', '}'];

    /// <summary>
    /// Initializes a new instance of the <see cref="Expression"/> class with the specified expression.
    /// </summary>
    /// <param name="expression">The expression to be checked for balanced brackets.</param>
    public Expression(string expression)
    {
        Input = expression;
    }

    /// <summary>
    /// Gets the input expression.
    /// </summary>
    public string Input { get; }

    /// <summary>
    /// Determines whether the brackets in the input expression are balanced.
    /// </summary>
    /// <returns>True if the brackets are balanced; otherwise, false.</returns>
    public bool IsBalanced()
    {
        foreach (var item in Input)
        {
            if (IsLeftBracket(item))
            {
                _stack.Push(item);
                continue;
            }

            if (!IsRightBracket(item))
            {
                continue;
            }

            if (IsEmpty())
            {
                return false;
            }

            var left = _stack.Pop();

            if (!BracketsMatch(left, item))
            {
                return false;
            }
        }

        return _stack.Count == 0;
    }

    /// <summary>
    /// Determines whether the stack of brackets is empty.
    /// </summary>
    /// <returns>True if the stack is empty; otherwise, false.</returns>
    private bool IsEmpty()
    {
        return _stack.Count == 0;
    }

    /// <summary>
    /// Determines whether the specified left and right brackets match.
    /// </summary>
    /// <param name="left">The left bracket.</param>
    /// <param name="right">The right bracket.</param>
    /// <returns>True if the brackets match; otherwise, false.</returns>
    private bool BracketsMatch(char left, char right)
    {
        return _leftBrackets.IndexOf(left) == _rightBrackets.IndexOf(right);
    }

    /// <summary>
    /// Determines whether the specified character is a right bracket.
    /// </summary>
    /// <param name="item">The character to check.</param>
    /// <returns>True if the character is a right bracket; otherwise, false.</returns>
    private bool IsRightBracket(char item)
    {
        return _rightBrackets.Contains(item);
    }

    /// <summary>
    /// Determines whether the specified character is a left bracket.
    /// </summary>
    /// <param name="item">The character to check.</param>
    /// <returns>True if the character is a left bracket; otherwise, false.</returns>
    private bool IsLeftBracket(char item)
    {
        return _leftBrackets.Contains(item);
    }
}
