namespace CodingDojo2.Stack
{
    class Node<T> //this class represents one element in a stack
    {
        public T Value { get; set; } //each element has a value. type T of the value is defined during instantiation of the stack. by defining get and set, we can access the value just by addressing it directly eg "stack.element.value"
        public Node<T> Next { get; set; } //each element has a successor element (or null if the last element). this element is of type node while the nodes type is set during instantiation. get and set is defined the same way as for the value
    }
}
