using System;

namespace Binary_Tree_Longest_Consecutive_Sequence
{
    class Program
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static void Main(string[] args)
        {
            // root =   [1, null, 3, 2, 4, null, null, null, 5]
        }

        public int LongestConsecutive(TreeNode root)
        {
            int[] max = new int[1];
            LongestConsecutiveHelper(root, max, 0, 0);
            return max[0];
        }

        void LongestConsecutiveHelper(TreeNode root, int[] max, int count, int target)
        {
            if (root == null) return;
            if (root.val == target)
            {
                count++;
            }
            else
            {
                count = 1;
            }

            max[0] = Math.Max(max[0], count);
            LongestConsecutiveHelper(root.left, max, count, root.val + 1);
            LongestConsecutiveHelper(root.right, max, count, root.val + 1);
        }
    }
}
