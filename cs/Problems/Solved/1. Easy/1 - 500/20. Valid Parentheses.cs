using System.Collections.Generic;

public class Solution_20 {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count == 0)
            {
                stack.Push(s[i]);
                continue;
            }

            if (s[i] == ')' && '('== stack.Peek())
                stack.Pop();
            else if (s[i] == ']' && '['== stack.Peek())
                stack.Pop();
            else if (s[i] == '}' && '{'== stack.Peek())
                stack.Pop();
            else
                stack.Push(s[i]);
        }

        return stack.Count == 0 ? true : false;
    }
}