public class Solution_53 {
    public int MaxSubArray(int[] nums) {
        var maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            var currMax = int.MinValue;
            var currSum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                currSum += nums[i];

                if (currSum > currMax)
                    currMax = currSum;
            }

            if(currMax > maxSum)
                maxSum = currMax;
        }

        return maxSum;s
    }
}