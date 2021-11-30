using System;

public class Solution_198 {
    public int Rob(int[] nums) {
        var len = nums.Length;
        if (len == 1) return nums[0];
        if (len == 2) return Math.Max(nums[0], nums[1]);
        var max = new int[len];

        max[0] = nums[0];
        max[1] = nums[1];
        max[2] = max[0] + nums[2];

        for (int i = 3; i < len; i++)
            max[i] = Math.Max(nums[i] + max[i - 3], nums[i] + max[i - 2]);

        return Math.Max(max[len - 1], max[len - 2]);
    }
}