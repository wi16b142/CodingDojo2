using System;

namespace CodingDojo2.Stack //class stack and node share the namespace codingdojo2.stack
{
    class Stack<T> //class stack is of generic type. you select the type of the stack when instantiaton it eg with <int>
    {
        private Node<T> current; //current first element of the stack

        public void Push(T element)
        {
            if(current == null) //check if stack is empty
            {
                //if empty we insert the first element which then points to null
                Node<T> newNode = new Node<T>() { Value = element, Next = null }; //create new element of type node using type of stack, set the elements value to the given value from the parameter and the next element is null

            }
            else
            {
                //if the stack is not empty, we create a new element, this element points to the original current element
                Node<T> newNode = new Node<T>() { Value = element, Next = current };
                //set the new element to the current first element
                current = newNode;
            }
        }

        public T Pop() //pop returns the first element in the stack and then removes it from the stack. returntype depends on type T of stack
        {
            if(current.Next != null) //check if stack is empty after pop
            {
                //not empty after pop
                T temp = current.Value; //store element value to be removed in temp
                current = current.Next; //set the current element to the original currents next element.
                return temp; //return the popped element value
            }else
            {   
                //empty after pop
                throw new NullReferenceException(); //throw NullRefEx meaning that stack is empty
            }
           
        }

        public T Peek() //peek returns current first element. return type depends on chosen type T of stack
        {
            if(current != null) //check if stack is not empty
            {
                //not empty
                return current.Value; //return value of current element
            }
            else
            {
                //empty
                return default(T); //returns for the type of T the default value. For nullables it's "null" for others it's "0"
            }
        }
    }
}
