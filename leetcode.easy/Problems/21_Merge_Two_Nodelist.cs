namespace leetcode.easy.Problems
{
    internal class _21_Merge_Two_Nodelist
    {
        //1,2,4
        //1,3,4
        //1,1,2,3,4,4
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Dummy node to act as the starting point of the merged list
            Queue<ListNode> mergedNodeLIst = new Queue<ListNode>();
            //ListNode current = new ListNode(0);

            while (list1 != null & list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    ListNode temp = new ListNode(list1.val);
                    mergedNodeLIst.Enqueue(temp);
                    list1 = list1.next;
                }
                else
                {
                    ListNode temp = new ListNode(list2.val);
                    mergedNodeLIst.Enqueue(temp);
                    list2 = list2.next;
                }
            }
            // If any elements are left in list1 or list2, append them
            if (list1 != null)
            {
                mergedNodeLIst.Enqueue(list1);
            }
            else if (list2 != null)
            {
                mergedNodeLIst.Enqueue(list2);
            }

            return ConnectNodes(mergedNodeLIst);

        }

        private ListNode ConnectNodes(Queue<ListNode> nodes)
        {
            if (nodes.Count == 0)
                return null;  // If the queue is empty, return null

            // Start by getting the first node as the head
            ListNode head = nodes.Dequeue();
            ListNode current = head;

            // Link the remaining nodes
            while (nodes.Count > 0)
            {
                current.next = nodes.Dequeue();  // Link to the next node
                current = current.next;          // Move to the next node
            }

            return head;  // Return the head of the newly linked list
        }

        public class ListNode
        {
            public int val;         // Stores the value of the node
            public ListNode next;   // Points to the next node

            // Constructor to initialize a node with a value
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;  // By default, the next node is null
            }
        }
    }
}
