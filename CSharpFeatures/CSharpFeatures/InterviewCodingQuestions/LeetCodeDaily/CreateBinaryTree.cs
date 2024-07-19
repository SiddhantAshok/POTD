using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    //public class TreeNode
    //{
    //    public int Value { get; set; }
    //    public TreeNode Left { get; set; }
    //    public TreeNode Right { get; set; }

    //    public TreeNode(int value)
    //    {
    //        Value = value;
    //        Left = null;
    //        Right = null;
    //    }
    //}

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


    class CreateBinaryTree
    {
        public TreeNode CreateBinaryTreeByDescription(int[][] descriptions)
        {
            Dictionary<int, TreeNode> nodes = new Dictionary<int, TreeNode>();
            HashSet<int> children = new HashSet<int>();

            // Create all nodes and build the relationships
            foreach (var description in descriptions)
            {
                int parent = description[0];
                int child = description[1];
                bool isLeft = description[2] == 1;

                if (!nodes.ContainsKey(parent))
                {
                    nodes[parent] = new TreeNode(parent);
                }

                if (!nodes.ContainsKey(child))
                {
                    nodes[child] = new TreeNode(child);
                }

                if (isLeft)
                {
                    nodes[parent].left = nodes[child];
                }
                else
                {
                    nodes[parent].right = nodes[child];
                }

                children.Add(child);
            }

            // Find the root (node that is never a child)
            TreeNode root = null;
            foreach (var node in nodes)
            {
                if (!children.Contains(node.Key))
                {
                    root = node.Value;
                    break;
                }
            }

            return root;

        }

        public TreeNode CreateBinaryTreeViaDescription(int[][] descriptions)
        {

            Stack<BinaryTree> lstTrees = new Stack<BinaryTree>();
            BinaryTree binaryTree = new BinaryTree();
            lstTrees.Push(binaryTree);
            foreach (var description in descriptions)
            {
                int parent = description[0];
                int child = description[1];
                int isLeft = description[2];
                //if (binaryTree.Root == null)
                //{
                //    binaryTree.Root.Value = parent;
                //    if (isLeft == 1)
                //    {
                //        binaryTree.Root.Left.Value = child;
                //    }
                //    else
                //    {
                //        binaryTree.Root.Right.Value = child;
                //    }
                //}
                //else
                //{
                var parentnode = lstTrees.Peek().PreOrderTraversal(lstTrees.Peek().Root, parent);
                if (parentnode != null)
                {
                    if (lstTrees.Peek().Root.val == parentnode.val)
                    {
                        lstTrees.Peek().Insert(child, new TreeNode(child), isLeft == 1 ? true : false);
                    }
                    else
                    {
                        //binaryTree.Insert(child, parentnode, isLeft == 1 ? true : false);
                        if (isLeft == 1)
                        {
                            parentnode.left = new TreeNode(child);
                        }
                        else
                        {
                            parentnode.right = new TreeNode(child);
                        }
                    }
                }
                else
                {
                    var childNode = lstTrees.Peek().PreOrderTraversal(lstTrees.Peek().Root, child);
                    if (childNode != null)
                    {
                        lstTrees.Peek().Root = new TreeNode(parent);
                        lstTrees.Peek().Insert(child, childNode, isLeft == 1 ? true : false);
                    }
                    else
                    {
                        if (lstTrees.Peek().Root != null)
                        {
                            BinaryTree childTree = new BinaryTree();
                            childTree.Root.val = parent;
                            if (isLeft == 1)
                            {
                                childTree.Root.left = new TreeNode(child);
                            }
                            else
                            {
                                childTree.Root.right = new TreeNode(child);
                            }
                            lstTrees.Push(childTree);
                        }
                        else
                        {
                            lstTrees.Peek().Insert(parent, new TreeNode(child), isLeft == 1 ? true : false);
                        }
                    }
                }
                //}

            }
            return binaryTree.Root;
        }

    }

    public class BinaryTree
    {
        public TreeNode Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        // Insert a node into the binary tree
        public void Insert(int value, TreeNode node, bool isLeft)
        {
            if (Root == null)
            {
                Root = new TreeNode(value);
                InsertRec(Root, node, isLeft);
            }
            else
            {
                //var node = PreOrderTraversal(Root, value);
                //if (node != null)
                //{
                InsertRec(Root, node, isLeft);
                //}
                //else
                //{
                //    InsertRec(Root, new TreeNode(value), isLeft);
                //}
            }
        }

        private void InsertRec(TreeNode root, TreeNode newNode, bool isLeft)
        {
            //if (newNode.Value < root.Value)
            if (isLeft)
            {
                if (root.left == null)
                {
                    root.left = newNode;
                }
                else
                {
                    InsertRec(root.left, newNode, isLeft);
                }
            }
            else
            {
                if (root.right == null)
                {
                    root.right = newNode;
                }
                else
                {
                    InsertRec(root.right, newNode, isLeft);
                }
            }
        }

        // Pre-order traversal
        public TreeNode PreOrderTraversal(TreeNode node, int value)
        {
            //if (node != null)
            //{
            //    //Console.Write(node.Value + " ");
            //    if (node.Value == value)
            //    {
            //        return node;
            //    }
            //    PreOrderTraversal(node.Left, value);
            //    PreOrderTraversal(node.Right, value);
            //}
            //return null;

            if (node != null)
            {
                if (node.val == value)
                {
                    return node;
                }

                TreeNode leftResult = PreOrderTraversal(node.left, value);
                if (leftResult != null)
                {
                    return leftResult;
                }

                TreeNode rightResult = PreOrderTraversal(node.right, value);
                if (rightResult != null)
                {
                    return rightResult;
                }
            }
            return null;
        }
    }
}
