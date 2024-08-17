using System;

namespace StacksProject
{
    internal abstract class Program
    {
        public static void Main()
        {
            var stack = new CustomStack<char>(5);

            stack.Push('f');
            stack.Push('e');
            stack.Push('d');
            stack.Push('c');
            stack.Push('b');
            stack.Push('a');

            Console.WriteLine($"Original: {stack}");

            stack.Reverse();

            Console.WriteLine($"Reversed: {stack}");

            stack.Pop();

            Console.WriteLine($"Pop: {stack}");

            Console.WriteLine($"Empty: {stack.IsEmpty()}");

            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Peek: {stack.Peek()}");

            var expression = new Expression("(1 + 2)");
            Console.WriteLine($"{expression.Input} is balanced: {expression.IsBalanced()}");

            expression = new Expression("(1 + 2");
            Console.WriteLine($"{expression.Input} is balanced: {expression.IsBalanced()}");

            expression = new Expression("((1 + 2");
            Console.WriteLine($"{expression.Input} is balanced: {expression.IsBalanced()}");

            expression = new Expression(")1 + 2(");
            Console.WriteLine($"{expression.Input} is balanced: {expression.IsBalanced()}");

            expression = new Expression("(1 + 2]");
            Console.WriteLine($"{expression.Input} is balanced: {expression.IsBalanced()}");

            expression = new Expression("(1 + 2>");
            Console.WriteLine($"{expression.Input} is balanced: {expression.IsBalanced()}");

            expression = new Expression("(1 + 2}");
            Console.WriteLine($"{expression.Input} is balanced: {expression.IsBalanced()}");

            Console.ReadLine();
        }
    }
}
