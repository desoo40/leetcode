public class Solution_53
{
    public int MaxSubArray(int[] nums)
    {
        var len = nums.Length;

        if (len == 1) return nums[0];

        var max = new int[len];

        max[0] = nums[0];
        var maxVal = nums[0];

        for (int i = 1; i < len; i++)
        {
            if (nums[i] > nums[i] + max[i - 1])
                max[i] = nums[i];
            else if (nums[i] + max[i - 1] > nums[i])
                max[i] = nums[i] + max[i - 1];
            else
                max[i] = nums[i];

            if (max[i] > maxVal)
                maxVal = max[i];
        }

        return maxVal;
    }
}