namespace DataStructures._03_Stacks;

public static class CustomStackTests
{
    public static void Execute()
    {
        Console.WriteLine("Testing the Reverse method...\n");
        Console.WriteLine($"Reverse string result: {StringReverser.Reverse("abc")}\n");

        Console.WriteLine("Testing the IsBalanced method...\n");
        var expression = "(1+2)";
        Console.WriteLine($"Expression: {expression}");
        Console.WriteLine($"Is balanced result: {Expression.IsBalanced(expression)}");
        expression = "(1+2";
        Console.WriteLine($"Expression: {expression}");
        Console.WriteLine($"Is balanced result: {Expression.IsBalanced(expression)}\n");
    }
}