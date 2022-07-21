using System;
using System.Linq;

public class Solution_557
{
    public string ReverseWords(string s)
    {
        return string.Join(' ', s.Split(' ').Select(x => new String(x.ToCharArray().Reverse().ToArray())).ToList());
    }
}