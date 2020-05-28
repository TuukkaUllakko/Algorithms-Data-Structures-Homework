using System;
using System.Text;

namespace part4
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public void AddFirst(int n)
        {
            Node node = new Node(n, this.tail, null);
                                                            
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.head.previous = node;
                node.next = this.head;
                this.head = node;
            }
        }

        public void AddLast(int n)
        {
            Node node = new Node(n, null, this.head);
            
            if (this.tail == null)
            {
                this.tail = node;
                this.head = tail;
            }
            else
            {
                this.tail.next = node;
                node.previous = this.tail;
                this.tail = node;
            }
            

        }

        public void RemoveFirst()
        {
            this.head = this.head.next;
            this.head.previous = null;
        }

        public void RemoveLast()
        {
            this.tail = this.tail.previous;
            this.tail.next = null;
        }

        public int GetNode(int x)
        {
            Node current = this.head;
            for (int i = 0; i < x; i++)
            {
                current = current.next;
            }
            return current.value;
        }

        public override string ToString()
        {
            Node current = this.head;
            StringBuilder builder = new StringBuilder();

            while (current != null)
            {
                builder.Append(current.value.ToString() + " ");
                current = current.next;
            }
            return builder.ToString();
        }
    }
}