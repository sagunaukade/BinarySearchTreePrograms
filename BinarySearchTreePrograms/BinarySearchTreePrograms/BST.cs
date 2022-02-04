using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreePrograms
{
    public class BST<T> where T : IComparable<T>
    {
        public T nodeData { get; set; }
        public BST<T> leftTree { get; set; }

        public BST<T> rightTree { get; set; }

        public BST(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;

        public void Insert(T item)
        {
            T CurrNodeVal = this.nodeData;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BST<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                    leftCount++;
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BST<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);
                    rightCount++;
                }
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size " + " " + (1 + this.leftCount + this.rightCount));
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
    }
}
