using System;

// this one from the first attemp, no debugging
public class Solution_35
{
    public int SearchInsert(int[] nums, int target)
    {
        var len = nums.Length;
        var min = 0;
        var max = len - 1;

        while (true)
        {
            if (min < 0) return 0;
            if (max == len) return len - 1;
            if (max - min == 1) return nums[min] > target ? min : max;

            var mid = min + (max - min) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[mid] > target)
                max = mid - 1;

            if (nums[mid] < target)
                max = mid + 1;
        }
        return 0;
    }
}