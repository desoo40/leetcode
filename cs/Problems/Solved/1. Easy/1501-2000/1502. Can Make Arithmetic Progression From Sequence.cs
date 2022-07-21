using System.Collections;
using System.Linq;

public class Solution_1502
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        var lst = arr.ToList();
        lst.Sort();
        var prevDiff = lst[1] - lst[0];
        for (int i = 2; i < lst.Count; i++)
            if (lst[i] - lst[i - 1] != prevDiff) return false;

        return true;
    }
}