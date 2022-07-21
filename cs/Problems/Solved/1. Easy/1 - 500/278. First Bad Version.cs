using System;
public class Solution_278
{
    bool IsBadVersion(int version)
    {
        return true;
    }

    public int FirstBadVersion(int n)
    {
        var min = 1;
        var max = n;

        while (min < max)
        {
            var mid = min + (max - min) / 2;

            if (IsBadVersion(mid)) max = mid;
            else min = mid + 1;
        }

        return max;
    }

}