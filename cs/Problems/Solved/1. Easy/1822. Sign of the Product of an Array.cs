
public class Solution_1822
{
    public int ArraySign(int[] nums)
    {
        var minus = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) return 0;
            if (nums[i] < 0)
            {
                if (minus) minus = false;
                else minus = true;
            }
        }

        return minus ? -1 : 1;
    }
}