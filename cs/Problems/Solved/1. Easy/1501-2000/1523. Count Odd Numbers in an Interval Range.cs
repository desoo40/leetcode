public class Solution_1523
{
    public int CountOdds(int low, int high)
    {
        int res = 0;

        if (low == high)
        {
            if (low % 2 != 0) return 1;
            return 0;
        }

        var cnt = high - low + 1;
        var between = cnt / 2;

        if (high % 2 == 1 && low % 2 == 1) res++;
        res += between;

        return res;
    }
}