using System;

namespace DSA_Revision.Data_Structure
{
    class Queue<T>
    {

        /*Queue is a data type that is based of the First-in-First-Out (FIFO) concept.
         * This means that the first element that is queued will also be the first element to be dequeued.
         * This data type has different usecases:
         * CPU scheduling , Disk scheduling.
         * Whean data is transfer asynchronously.
         * Handling of interrupts in real-time systems.
         */

        private T[] data;
        private int front, rear;

        //Constructor to create a queue
        public Queue(int capacity) 
        {
            data = new T[capacity];
            front = -1;
            rear = -1;
        }

        //Check if the queue is full
        bool IsFull()
        {
            return front == 0 && rear == data.Length - 1;
        }

        //Check if the queue is empty
        bool IsEmpty()
        {
            return front == -1;
        }

        //Add element into queue
        public void Enqueue(T element)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            if (IsEmpty())
            {
                front = 0;
            }
            rear++;
            data[rear] = element;
            Console.WriteLine($"Inserted {element}");
        }

        //Remove elements from queue
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T element = data[front];

            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                front++;
            }
            Console.WriteLine($"Deleted -> {element}");
            return element;
        }

        //Display the queue
        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue: ");
            for (int i = front; i <= rear; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
