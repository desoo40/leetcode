public class Solution_496
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var arr = new int[nums1.Length];
        for (int k = 0; k < nums1.Length; k++)
        {
            var greater = nums1[k];
            var found = false;
            for (int i = 0; i < nums2.Length; i++)
            {
                if (found)
                {
                    if (nums2[i] > greater)
                    {
                        greater = nums2[i];
                        break;
                    }
                    continue;
                }

                if (nums2[i] == nums1[k])
                {
                    found = true;
                }
            }
            arr[k] = greater == nums1[k] ? -1 : greater;
        }
        return arr;
    }
}