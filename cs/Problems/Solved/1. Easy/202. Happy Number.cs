using System;
using System.Collections.Generic;
using System.Linq;

public class Solution_202
{
    public HashSet<int> visited = new HashSet<int>();
    public bool SumOfN(int n)
    {
        var str = n.ToString();
        var sum = str.Select(x =>
        {
            var kek = x - '0';
            return kek * kek;
        }).Sum();
        if (sum == 1) return true;
        if (visited.Contains(sum)) return false;
        visited.Add(sum);
        return SumOfN(sum);
    }

    public bool IsHappy(int n)
    {
        return SumOfN(n);
    }
}