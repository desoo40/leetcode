using System;

// this one from the first attemp, no debugging
public class Solution_35 {
    public int SearchInsert(int[] nums, int target) {
        var len = nums.Length;
        var leftBorder = 0;
        var rightBorder = len - 1;

        while(true)
        {
            if (leftBorder < 0) return 0;
            if (rightBorder == len) return len - 1;
            if (rightBorder - leftBorder == 1) return nums[leftBorder] > target ? leftBorder : rightBorder;
            
            var mid = leftBorder + (leftBorder + rightBorder) / 2;

            if (nums[mid] == target)
                return mid;
            
            if (nums[mid] > target)
                rightBorder = mid - 1;

            if (nums[mid] < target)
                rightBorder = mid + 1;
        }
        return 0;
    }
}