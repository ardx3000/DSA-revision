using System;

namespace DSA_Revision.Data_Structure
{
    class Queue<T>
    {
        private T[] data;
        private int front, rear;

        public Queue(int capacity) 
        {
            data = new T[capacity];
            front = -1;
            rear = -1;
        }

        bool IsFull()
        {
            return front == 0 && rear == data.Length - 1;
        }

        bool IsEmpty()
        {
            return front == -1;
        }

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
