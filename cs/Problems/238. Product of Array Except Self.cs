public class Solution_238 {
     public int[] ProductExceptSelf(int[] nums) {
        
        var prod = 1;

        for (int i = 0; i < nums.Length; i++)
            prod *= nums[i];

        for (int i = 0; i < nums.Length; i++)
            nums[i] = prod / nums[i];

        return nums;
    }
}   