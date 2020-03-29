using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.Insert(21);
            myTree.Insert(3);
            myTree.Insert(-3);
            myTree.Insert(9);
            myTree.Insert(3);

            Console.WriteLine(myTree.GetMaxValue());

        }
    }

    class Node
    {
        public int Value { get; set; }
        public Node left, right;

        public Node(int newVal)
        {
            Value = newVal;
        }
    }

    class BinarySearchTree
    {
        //data
        Node root;

        //methods
        //isEmpty
        public bool IsEmpty()
        {
            return root == null;
        }
        //Insert
        public void Insert(int newValue)
        {
            //crate node
            Node newNode = new Node(newValue);

            //if the tree is empty
            if (IsEmpty())
            {
                root = newNode;
            }
            else
            {
                Node finger = root;
                while (true)
                {
                    if (newValue <= finger.Value)
                    {
                        if (finger.left != null)
                        {
                            finger = finger.left;
                        }
                        else
                        {
                            finger.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (finger.right != null)
                        {

                        finger = finger.right;
                        }
                        else
                        {
                            finger.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Delete
        //Traverse
        //GetMaxValue
        public int GetMaxValue()
        {
            if (IsEmpty())
            {
                throw new Exception("no max can be foun in an empty tree!");
            }

            Node finger = root;
            while (finger.right != null)
            {
                finger = finger.right;
            }
            return finger.Value;
        }
        //GetMinValue

        //ctor
        public BinarySearchTree()
        {
            root = null;
        }
    }
}
