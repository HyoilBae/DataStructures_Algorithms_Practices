using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_LowestCoomonAncestorOfBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //root = [6, 2, 8, 0, 4, 7, 9, null, null, 3, 5];

            
            
            
        }
    }

    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val < root.val && q.val < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else if (p.val > root.val && q.val > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                return root;
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
