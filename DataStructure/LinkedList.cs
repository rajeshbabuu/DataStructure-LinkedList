﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        internal Node head;

        public void Add(int data)
        {
            Node objNode = new Node(data);
            if (this.head == null)
            {
                this.head = objNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = objNode;
            }
            Console.WriteLine($"\n{objNode.data} inserted into Linked List");
        }

        public void InsertLast(int new_data)
        {
            Node objnew_Node = new Node(new_data);
            objnew_Node.data = new_data;
            objnew_Node.next = null;
            if (head == null)
            {
                head = objnew_Node;
            }
            else
            {
                Node temp = new Node(new_data);
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = objnew_Node;
            }
            Console.WriteLine($"\n{objnew_Node.data} is added at last");
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinkedList is empty");
                return;
            }
            Console.Write("\nLinked List => ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
