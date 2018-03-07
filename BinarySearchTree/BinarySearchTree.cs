using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public int data;
        public int node;
        public BinarySearchTree left;
        public BinarySearchTree right;

        public BinarySearchTree(int data)
        {
            this.data = data;
        }
        public bool ExistingNumber()
        {
            return (right == null && left == null);
        }
        public void Loop()
        {
            //need to use a while loop
            //need to show what happens for first value null == 0 (if else)
            //need to use else to show what happens right or left
        }
        public void AddMethod(int data)
        { if (node == 0)
            {
                if (right == null)
                {
                    right = new BinarySearchTree(data);
                }
                else if (left == null)
                {
                    left = new BinarySearchTree(data);
                }
            }
           else if (node > 0)
            {
                if (left)
                {
                    left.AddMethod(data);
                }
                else if (right)
                {
                    right.AddMethod(data);
                }
            }

        }
        public void SearchMethod()
        {
            
        }
        public void DisplaySearchMethod()
        {
            if (left != null)
            {
                Console.WriteLine(data);
            }
            if (right != null)
            {
                Console.WriteLine(data);
            }
        }
    }
}
