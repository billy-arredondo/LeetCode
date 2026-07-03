namespace LeetCode.Core.Common;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode? FromValues(params int[] values)
    {
        ListNode? head = null;

        for (int i = values.Length - 1; i >= 0; i--)
        {
            head = new ListNode(values[i], head);
        }

        return head;
    }

    public int[] ToArray()
    {
        var values = new List<int>();
        ListNode? current = this;

        while (current is not null)
        {
            values.Add(current.val);
            current = current.next;
        }

        return values.ToArray();
    }
}
