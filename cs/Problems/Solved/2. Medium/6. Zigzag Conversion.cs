using System;
using System.Collections.Generic;

public class Solution_6
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        var list = new List<string>();

        for (int i = 0; i < numRows; i++)
            list.Add("");

        for (int i = 0; i < s.Length;)
        {
            for (int j = 0; j < numRows && i < s.Length; j++, i++)
                list[j] += s[i];

            for (int j = 0; j < numRows - 2 && i < s.Length; j++, i++)
                list[numRows - j - 2] += s[i];
        }

        return String.Join("", list);
    }
}