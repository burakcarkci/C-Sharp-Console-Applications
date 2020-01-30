using System;
using System.Collections.Generic;

namespace ReversingQueue
{
    public class ReversingQueueWithStack
    {
        private readonly Queue<int> _queue = new Queue<int>();
        private readonly Stack<int> _stack = new Stack<int>();

        public void EnQueue(int num)
        {
            _queue.Enqueue(num);
        }

        public void DeQueue()
        {
            if (_queue.Count == 0)
            {
                throw new Exception("Queue is already empty!");
            }
            else
            {
                _queue.Dequeue();
            }
        }

        public void PrintQueue()
        {
            if (_queue.Count == 0)
            {
                throw new Exception("Queue is empty!");
            }
            else
            {
                foreach (int nums in _queue)
                {
                    Console.WriteLine(nums);
                }
            }
        }

        public void RemoveFromQueue()
        {
            while (_queue.Count != 0)
            {
                _stack.Push(_queue.Dequeue());
            }
        }

        public void AddBackToQueue()
        {
            while (_stack.Count != 0)
            {
                _queue.Enqueue(_stack.Pop());
            }
        }
    }
}