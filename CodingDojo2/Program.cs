using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CodingDojo2 - let's get ready to rumble!");

            //create obj stack with first node (value = 4)
            Stack myStack = new Stack(4);
        }

        class Stack
        {
            class node
            {
                int number;
                private node next = null;
                internal node(int num)
                {
                    int number = num;
                }
            }            

            private node first;

            public Stack(int num)
            {
                this.first = new node(num);
            }

            public void push(int num)
            {
                Console.WriteLine("push {0} in stack", num);
            }

            public void pop()
            {
                Console.WriteLine("pop from stack");
            }

            public void peek()
            {
                Console.WriteLine("peek element from top of the stack");
            }
        }
    }
}
