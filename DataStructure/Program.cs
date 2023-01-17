namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");

            LinkedList objLinkedList = new LinkedList();
            objLinkedList.Add(70);
            objLinkedList.InsertFront(30);
            objLinkedList.InsertFront(56);
            objLinkedList.Display();

            Console.ReadLine();
        }
    }
}