public class Solution_724
{
    public int PivotIndex(int[] nums)
    {
        var len = nums.Length;
        var left = new int[len];
        var right = new int[len];

        for (int i = 1; i < len; i++)
        {
            left[i] += left[i - 1] + nums[i - 1];
            right[len - i - 1] += right[len - i] + nums[len - i];
        }

        for (int i = 0; i < len; i++)
        {
            if (left[i] == right[i])
                return i;
        }

        return -1;
    }
}