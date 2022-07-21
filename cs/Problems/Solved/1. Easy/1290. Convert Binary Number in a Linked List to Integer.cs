using System;

public class Solution_1290
{
    public int GetDecimalValue(ListNode head)
    {
        var ans = "";
        while (head != null)
        {
            ans += head.val.ToString();
            head = head.next;
        }

        return Convert.ToInt32(ans, 2);
    }
}