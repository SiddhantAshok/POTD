using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{

    class BinaryTreeTraversal
    {
        public IList<int> InorderTraversal(TreeNode root) {
            var inorderTraverse = new List<int>();
            //InOrderTraversalRecursion(root, ref inorderTraverse);
            InOrderTraverse(root, ref inorderTraverse);

            return inorderTraverse;
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            var inorderTraverse = new List<int>();
            PreOrderTraversal(root, ref inorderTraverse);

            return inorderTraverse;
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            var inorderTraverse = new List<int>();
            PostOrderTraversal(root, ref inorderTraverse);

            return inorderTraverse;
        }

        public void InOrderTraversalRecursion(TreeNode root, ref List<int> inorderTraverse)
        {
            //var inorderTraverse = new List<int>();
            if (root != null)
            {
                InOrderTraversalRecursion(root.left, ref inorderTraverse);
                // Console.Write(node.Value + " ");
                inorderTraverse.Add(root.val);
                InOrderTraversalRecursion(root.right, ref inorderTraverse);
            }

            //return inorderTraverse;

        }

        public void InOrderTraverse(TreeNode root, ref List<int> inorderTraverse)
        {
            if (root == null) return;

            Stack<TreeNode> treeNodes = new Stack<TreeNode>();
            TreeNode current = root;

            while (current != null || treeNodes.Count > 0 )
            {

                while (current != null)
                {
                    treeNodes.Push(current);
                    current = current.left;
                }

                current = treeNodes.Pop();
                inorderTraverse.Add(current.val);
                current = current.right;

            }

        }

        public void PreOrderTraversal(TreeNode root, ref List<int> inorderTraverse)
        {
            //var inorderTraverse = new List<int>();
            if (root != null)
            {
                inorderTraverse.Add(root.val);
                PreOrderTraversal(root.left, ref inorderTraverse);
                // Console.Write(node.Value + " ");
                PreOrderTraversal(root.right, ref inorderTraverse);
            }

            //return inorderTraverse;

        }

        public void PostOrderTraversal(TreeNode root, ref List<int> inorderTraverse)
        {
            //var inorderTraverse = new List<int>();
            if (root != null)
            {
                PostOrderTraversal(root.left, ref inorderTraverse);
                // Console.Write(node.Value + " ");
                PostOrderTraversal(root.right, ref inorderTraverse);
                inorderTraverse.Add(root.val);
            }

            //return inorderTraverse;

        }


    }
}
