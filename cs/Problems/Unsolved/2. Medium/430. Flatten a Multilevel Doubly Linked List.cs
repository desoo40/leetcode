using System;

// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}

public class Solution_430 {

    private Node FindLast(Node curr)
    {
        if (curr == null)
            return null;

        return curr.next == null ? curr.next : FindLast(curr.next);
    }

    public Node Flatten(Node head) {
        if (head == null)
            return null;

        var tmpNext = head.next;

        if (head.child != null)
        {
            head.child.prev = head;
            head.next = head.child;
        }

        head.next = Flatten(head.child);

        var tmpLast = FindLast(head.next);
        
        if (tmpLast == null)
            return head;

        tmpNext.prev = tmpLast;
        tmpLast.next = tmpNext;

        return Flatten(tmpNext);
    }
}
