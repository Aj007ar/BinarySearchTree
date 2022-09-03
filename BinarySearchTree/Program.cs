namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BSTOperations<int> Bst = new BSTOperations<int>(56);
            Bst.Insert(30);
            Bst.Insert(70);
            Console.WriteLine("Display using inorder traversal:");
            Bst.Display();
            Console.WriteLine(" ");
            Bst.SizeOfTree();
        }
    }
}