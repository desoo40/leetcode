using System.Collections.Generic;

public class Solution_1929
{
    public int[] GetConcatenation(int[] nums)
    {
        List<int> list = new List<int>();
        list.AddRange(nums);
        list.AddRange(nums);

        return list.ToArray();
    }
}