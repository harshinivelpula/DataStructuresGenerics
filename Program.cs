using DataStructuresGeneric;
using System.Collections.Generic;

namespace DataStructureGeneric
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to data structure problem using generics");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2,30);
            list.Display();
            Console.ReadKey();
        }
    }
}