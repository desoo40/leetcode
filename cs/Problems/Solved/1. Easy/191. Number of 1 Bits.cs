using System;
public class Solution_191
{
    public int HammingWeight(uint n)
    {
        var cnt = 0;

        while (n != 0)
        {
            if (n % 2 == 0)
                return cnt + 1;

            var tmp = n;
            if (tmp << 31 >> 31 == 1)
                cnt++;

            n >>= 1;
        }

        return cnt;
    }
}