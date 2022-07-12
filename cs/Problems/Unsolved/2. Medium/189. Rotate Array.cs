using System;
public class Solution_189
{
    public void Rotate(int[] nums, int k)
    {
        var min = 0;
        var max = nums.Length - 1;
        var res = new int[nums.Length];

        while (min < max)
        {
            res[min] = nums[max - k];
            res[max] = nums[max - k - min];
        }
    }
}