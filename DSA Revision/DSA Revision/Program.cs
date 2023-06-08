using DSA_Revision.Data_Structure;


namespace DSA_Revision
{
    class Program
    {
        //Class that test the Queue data type.
        public void QueueTest()
        {
            //I have used the namespace to point to my data type and not the one from Generic
            Data_Structure.Queue<int> queue = new Data_Structure.Queue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.PrintQueue();

            queue.Dequeue();

            queue.PrintQueue();
        }

        //Class that test the Stack data type.
        public void StackTest()
        {
            //I have used the namespace to point to my data type and not the one from Generic
            Data_Structure.Stack<int> stack = new Data_Structure.Stack<int>(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            List<int> templist= new List<int>(stack);

            Console.WriteLine(stack.Count());
            foreach (int items in stack)
            {
                Console.Write(items);
            }
            Console.WriteLine();    
            stack.Pop();
            foreach (int items in stack)
            {
                Console.Write(items);
            }

        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.StackTest();
            obj.QueueTest();
        }
    }
}