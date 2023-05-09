using System;
using System.Collections.Generic;

public static class PalindromeChecker
{
    public static bool IsPalindrome(string input)
    {
        input = CleanString(input); // remove non-alphanumeric characters and convert to lowercase
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();
        foreach (char c in input)
        {
            stack.Push(c);
            queue.Enqueue(c);
        }
        while (stack.Count > 0)
        {
            if (stack.Pop() != queue.Dequeue())
            {
                return false;
            }
        }
        return true;
    }

    private static string CleanString(string input)
    {
        input = input.ToLowerInvariant();
        input = new string(Array.FindAll(input.ToCharArray(), char.IsLetterOrDigit));
        return input;
    }
}