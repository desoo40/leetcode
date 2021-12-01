public class Solution_55 {
    public bool CanJump(int[] nums) {
        var len = nums.Length;
        var reached = new bool[len];
        reached[0] = true;

        for (int i = 0; i < len; i++)
            if (reached[i] == true)
            {
                if (i + nums[i] >= len - 1)
                    return true;
                
                for (int j = 1; j <= nums[i]; j++)
                    reached[i + j] = true;
            }
                

        return reached[len - 1];
    }
}