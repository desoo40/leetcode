public class Solution_704
{
    public int Search(int[] nums, int target)
    {
        var min = 0;
        var max = nums.Length - 1;

        while (min <= max)
        {
            var mid = (max + min) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] > target) max = mid - 1;
            else min = mid + 1;
        }

        return -1;
    }
}