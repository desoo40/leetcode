using System;
public class Solution_977
{
    public int[] SortedSquares(int[] nums)
    {
        var min = 0;
        var max = nums.Length - 1;
        var res = new int[nums.Length];
        var currInt = max;

        while (min <= max)
        {
            var left = nums[min] * nums[min];
            var right = nums[max] * nums[max];

            if (right > left)
            {
                res[currInt] = right;
                max--;
            }
            else
            {
                res[currInt] = left;
                min++;
            }
            currInt--;
        }

        return res;
    }
}