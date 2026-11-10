using System;
using System.Collections.Generic;
using System.Text;

namespace Week12Assignment12._1
{
    public class Node
    {
        public int Data { get; set; }
        public Node next;

        public Node(int value)
        {
            Data = value;
            next = null;
        }
    }

    public class LL
    {
        private Node head;
        private Node tail;
        private int size;
        public int Size { get { return size; } }
        public LL()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddFirst(int item)
        {
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                newNode.next = head;
                this.head = newNode;
            }
            size++;
        }

        public void AddLast(int item)
        {
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                tail.next = newNode;
                this.tail = newNode;
            }
            size++;
        }

        public void Display()
        {
            Node tempNode = head;
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }
            else
            {
                while (tempNode != null)
                {
                    Console.Write(tempNode.Data + " ");
                    tempNode = tempNode.next;
                }
            }
        }

        public bool IsPalindrome()
        {
            if (IsEmpty())
                return true;

            // 1. Find the middle of the linked list
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            // 2. Reverse the second half
            Node secondHalf = Reverse(slow);

            // 3. Compare the first and second halves
            Node firstHalf = head;

            while (secondHalf != null)
            {
                if (firstHalf.Data != secondHalf.Data)
                    return false;

                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }

            return true;
        }

        private Node Reverse(Node head)
        {
            Node prev = null;
            Node current = head;

            while (current != null)
            {
                Node next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
