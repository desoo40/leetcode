public class Solution_75 {
   public void SortColors(int[] nums) {
        var zeros = 0;
        var ones = 0;
        var twos = 0;

        var len = nums.Length;

        for (int i = 0; i < len; i++)
        {
            var currEl = nums[i];

            if (currEl == 0) zeros++;
            if (currEl == 1) ones++;
            if (currEl == 2) twos++;
        }

        
        for (int i = 0; i < len; i++)
        {
            if (i < zeros)
            {
                nums[i] = 0;
                continue;    
            }

            if (i < zeros + ones)
            {
                nums[i] = 1;
                continue;    
            }
            nums[i] = 2;
        }
    }
}