using System;

namespace Stack.Model
{
    public class Stack<T>
    {

        private class Node
        {
            public T Item { get; set; }
            public Node Prev { get; set; }
            public Node(T item)
            {
                Item = item;
            }
        }

        public int Count { get; private set; }     
        public void Push(T item)
        {
            Node node = new Node(item);
            node.Prev = Top;
            Top = node;
            Count++;
        }
        public T Pop()
        {
            if (Top == null)
                throw new Exception("Стек пуст");
            T result = Top.Item;
            Top = Top.Prev;
            Count--;
            return result;
        }
        public T Peek()
        {
            if (Top != null) return Top.Item;
            throw new Exception("Стек пуст");
        }
        private Node Top { get; set; }

    }
}
