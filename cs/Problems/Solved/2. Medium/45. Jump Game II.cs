using System;

public class Solution_45     {
    public int Jump(int[] nums) {
        var len = nums.Length;
        var min = new int[len];

        for (int i = 0; i < len; i++)
        {
            if (min[i] == 0 && i != 0)
                continue;

            var forJ = i + nums[i] > len - 1 ? len - 1 - i : nums[i];

            for (int j = forJ; j > 0; j--)
                min[i + j] = min[i + j] == 0 ? min[i] + 1 : Math.Min(min[i + j], min[i] + 1);
        }
                
        return min[len - 1];
    }
}