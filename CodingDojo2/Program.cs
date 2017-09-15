using System;
using System.Collections.Generic;

namespace CodingDojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CodingDojo2 - let's get ready to rumble!");

            //create stacks with different datatypes.
            Console.WriteLine("\nInteger Stack");
            Stack<int> intStack = new Stack<int>();
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine("read: {0}", intStack.Peek());
            intStack.Push(4);
            Console.WriteLine("{0} removed", intStack.Pop());
            intStack.Push(5);
            Console.WriteLine("{0} removed", intStack.Pop());
            Console.WriteLine("{0} removed", intStack.Pop());
            Console.WriteLine("read: {0}", intStack.Peek());
            Console.WriteLine("{0} removed", intStack.Pop());

            Console.WriteLine("\nString Stack");
            Stack<string> stringStack = new Stack<string>();
            stringStack.Push("Test1");
            stringStack.Push("Test2");
            Console.WriteLine("read: {0}", stringStack.Peek());
            stringStack.Push("Test4");
            Console.WriteLine("{0} removed", stringStack.Pop());
            Console.WriteLine("{0} removed", stringStack.Pop());
            Console.WriteLine("{0} removed", stringStack.Pop());
            //Console.WriteLine("read: {0}", stringStack.Peek()); //nullpointer exception

            Console.WriteLine("\nBoolean Stack");
            Stack<Boolean> booleanStack = new Stack<Boolean>();
            //Console.WriteLine("{0} removed", booleanStack.Pop()); //nullpointerexception
            booleanStack.Push(true);
            booleanStack.Push(false);
            Console.WriteLine("read: {0}", booleanStack.Peek());
            booleanStack.Push(true);
            Console.WriteLine("{0} removed", booleanStack.Pop());
            Console.WriteLine("{0} removed", booleanStack.Pop());
            Console.WriteLine("read: {0}", booleanStack.Peek());
            Console.WriteLine("{0} removed", booleanStack.Pop());



            Console.ReadLine();
        }
    }
}
