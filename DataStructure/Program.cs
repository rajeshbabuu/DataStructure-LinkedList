namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");

            LinkedList objLinkedList = new LinkedList();
            objLinkedList.Add(70);
            objLinkedList.InsertLast(30);
            objLinkedList.InsertLast(56);
            objLinkedList.Display();

            Console.ReadLine();
        }
    }
}