using System.Collections;


namespace DSA_Revision.Data_Structure
{
    class Stack<T>: IEnumerable<T>
    {
        /* Stack is a data type that is based on the Last-in-First-Out (LIFO) concept.
         * This means that the first element that is pushed in the stack it will be the last element that will be poped from the stack.
         * This data type has different usescase:
         * One use case is the back system from the web browsers since you want to back "remove" the active page "last one inserted".
         * Other user case can be reversing a word.
         * The class also extends in IEnumerable to be able to use "foreach" loops to enumerate the items in the stack.
         * */

        private T[] data;
        private int top;

        //Constructor to create a stack
        public Stack(int capacity)
        {
            data = new T[capacity];
            top = -1;
        }

        //Add elements into stack
        public void Push(T item) 
        {
            if (top == data.Length - 1)
            {
                //If the Stack is full it will resize it to be able to accept new elemetns 
                Array.Resize(ref data, data.Length * 2);
            }
            data[++top] = item;
        }

        //Remove elements from the stack
        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            T item = data[top];
            data[top--] = default(T);
            return item;
        }

        //Check if the stack is empty "0 elements"
        bool IsEmpty() 
        {
            return top == -1;
        }

        //Check the number of elements in the stack
        public int Count()
        {
            return top + 1;
        }

        //Enumerate over the items in the stack
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = top; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        //Getter for enumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
