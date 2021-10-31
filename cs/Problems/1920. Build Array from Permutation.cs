using System;
public class Solution_1920 {
    public int[] BuildArray(int[] nums) {
        var len = nums.Count();
        var newArr = new int[len];

        for (int i = 0; i < len; i++)
            newArr[i] = nums[nums[i]];

        return newArr;
    }
}