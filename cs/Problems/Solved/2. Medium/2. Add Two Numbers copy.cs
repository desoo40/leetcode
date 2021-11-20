 public class Solution_2 {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
 
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var tmpSum = l1.val + l2.val;
        var head = new ListNode(tmpSum % 10);
        var additional = tmpSum >= 10 ? 1 : 0;
        l1 = l1.next;
        l2 = l2.next;

        var currNode = head;

        while(l1 != null || l2 != null)
        {
            var lhs = l1 == null ? 0 : l1.val;
            var rhs = l2 == null ? 0 : l2.val;;

            tmpSum = lhs + rhs + additional;
            currNode.next = new ListNode(tmpSum % 10);

            additional = tmpSum >= 10 ? 1 : 0;
            currNode = currNode.next;

            l1 = l1 == null ? l1 : l1.next;
            l2 = l2 == null ? l2 : l2.next;
        }

        if (additional == 1)
            currNode.next = new ListNode(1);

        return head;
    }
}