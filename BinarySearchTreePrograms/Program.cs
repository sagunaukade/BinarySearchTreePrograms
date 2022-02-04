using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the binary search tree programs");
            Console.WriteLine("\n1.Insertion.");
            Console.WriteLine("\n2.Insert more elements");
            Console.WriteLine("\n3.Search elements");

            Console.WriteLine("Enter the option!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            BST<int> binarySearchTree = new BST<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                case 2:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    binarySearchTree.GetSize();
                    break;
                case 3:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    bool result = binarySearchTree.IfExists(63, binarySearchTree);
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
