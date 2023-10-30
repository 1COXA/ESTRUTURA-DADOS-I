using System;

namespace PilhaStack
{
    public class Stack
    {
        private string[] items;
        private int top;
        private int maxSize;

        public Stack(int capacity)
        {
            maxSize = capacity;
            items = new string[maxSize];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public bool Push(string data)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top++;
            items[top] = data;
            return true;
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }
            string value = items[top];
            top--;
            return value;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }
            return items[top];
        }

        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }
            Console.WriteLine("Elementos na pilha:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
