using System;
using System.Linq;

public class Solution_1356
{
    public int[] SortByBits(int[] arr)
    {
        return (from el in arr
                orderby Convert.ToString(el, 2).Count(x => x == '1')
                select el).ToArray();
    }
}