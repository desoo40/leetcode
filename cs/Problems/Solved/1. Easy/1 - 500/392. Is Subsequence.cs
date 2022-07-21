using System;
public class Solution_392
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        if (s.Length >= t.Length)
        {
            if (s == t) return true;
            else return false;
        }

        var k = 0;

        foreach (var ch in t)
        {
            if (k == s.Length) return true;
            if (ch == s[k])
                k++;
        }
        return k == s.Length;
    }
}