using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var l1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            };

            var l2 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                                {
                                    next = new ListNode(7)
                                    {
                                        next = new ListNode(8)
                                        {
                                            next = new ListNode(9)
                                            {
                                                next = new ListNode(10)
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            var result2 = splitListToParts(l2, 3);
            var result = splitListToParts(l1, 5);
        }

        public static ListNode[] splitListToParts(ListNode root, int k)
        {
            ListNode cur = root;
            int N = 0;
            while (cur != null)
            {
                cur = cur.next;
                N++;
            }

            int width = N / k;
            int rem = N % k;

            ListNode[] ans = new ListNode[k];
            cur = root;
            for (int i = 0; i < k; ++i)
            {
                ListNode head = new ListNode(0);
                var write = head;

                for (int j = 0; j < width + (i < rem ? 1 : 0); ++j)
                {
                    var temp = new ListNode(cur.val);
                    write = write.next = temp;

                    if (cur != null) 
                        cur = cur.next;
                }

                ans[i] = head.next;
            }
            return ans;
        }

        public static ListNode[] splitListToParts2(ListNode root, int k)
        {
            ListNode cur = root;
            int N = 0;
            while (cur != null)
            {
                cur = cur.next;
                N++;
            }

            int width = N / k;
            int rem = N % k;

            ListNode[] ans = new ListNode[k];
            cur = root;
            for (int i = 0; i < k; ++i)
            {
                ListNode head = cur;
                for (int j = 0; j < width + (i < rem ? 1 : 0) - 1; ++j)
                {
                    if (cur != null) cur = cur.next;
                }
                if (cur != null)
                {
                    ListNode prev = cur;
                    cur = cur.next;
                    prev.next = null;
                }
                ans[i] = head;
            }
            return ans;
        }
    }
}

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
