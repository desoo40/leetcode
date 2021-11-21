using System;

// this one from the first attemp, no debugging
public class Solution_540 {
    public int SingleNonDuplicate(int[] nums) {
        var len = nums.Length;
        var leftBorder = 0;
        var rightBorder = len - 1;
        
        while(true)
        {
            var mid = (rightBorder - leftBorder) / 2 + leftBorder;

            var midVal = nums[mid];
            var leftToMidVal = mid - 1 >= 0 ? nums[mid - 1] : -1;
            var rightToMidVal = mid + 1 < len ? nums[mid + 1] : -1;

            if (midVal != leftToMidVal && midVal != rightToMidVal)
                return midVal;

            if (midVal == leftToMidVal)
            {
                var elemsToRightCnt = (len - 1) - mid;
                var toRightIsEven = elemsToRightCnt % 2;

                if (toRightIsEven != 0)
                    leftBorder = mid + 1;
                else
                    rightBorder = mid - 2;

            }

            if (midVal == rightToMidVal)
            {
                var elemsToLeftCnt = mid;
                var toLeftIsEven = elemsToLeftCnt % 2;

                if (toLeftIsEven != 0)
                    rightBorder = mid - 1;
                else
                    leftBorder = mid + 2;

            }
        }
    }
}