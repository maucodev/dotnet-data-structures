using System.Text;

namespace DataStructures._03_Stacks
{
    /// <summary>
    /// Provides methods to reverse strings using a stack data structure.
    /// </summary>
    public static class StringReverser
    {
        /// <summary>
        /// Reverses the characters in a given string using a stack.
        /// </summary>
        /// <param name="input">The string to be reversed.</param>
        /// <returns>The reversed string.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the input string is null.</exception>
        public static string Reverse(string input)
        {
            ArgumentNullException.ThrowIfNull(input);

            var stack = new Stack<char>();

            // Push each character of the input string onto the stack.
            foreach (var item in input)
            {
                stack.Push(item);
            }

            var result = new StringBuilder();

            // Pop characters from the stack and append them to the result string.
            while (stack.Count > 0)
            {
                result.Append(stack.Pop());
            }

            return result.ToString();
        }
    }
}