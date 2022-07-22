using System.Collections.Generic;

public class Solution_217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i])) return true;
            set.Add(nums[i]);
        }
        return false;
    }
}