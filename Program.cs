using DataStructuresGeneric;

namespace DataStructureGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dequeue DQueue = new Dequeue();
            DQueue.Enqueue(56);
            DQueue.Enqueue(30);
            DQueue.Enqueue(70);
            DQueue.Dequeu();
            DQueue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}