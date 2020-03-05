using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            //arr.add
            //Node n1; //this is just a pointer
            //Node n2 = new Node(17); //this is an instance
            //Node someNode = new Node(7);
            //Node anotherNode = new Node(11);
            //anotherNode.Next = someNode;

            SinglyLinkedList myList = new SinglyLinkedList();
            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddFirst(3);
            myList.Print();
            myList.Insert(10000, 3);

            myList.Append(4);
            myList.Append(10);
            myList.Append(20);
            myList.Append(30);
            myList.Append(100);
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            myList.DeleteFirst();
            myList.Print();
            try
            {
                myList.DeleteFirst();
                myList.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }


        class Node
        {
            //to store
            public int Value { get; set; }
            public Node Next { get; set; }

            //Constructor
            public Node(int someVal)
            {
                Value = someVal;
            }
        }

        class SinglyLinkedList
        {
            //data
            Node head;

            //behavior
            //AddFirst
            public void AddFirst(int someValue)
            {
                //create a new node
                Node newNode = new Node(someValue);

                //link in the new node
                newNode.Next = head;

                //move the head to the left
                head = newNode;
            }
            //AddLast  /Append
            public void Append(int someValue)
            {
                AddLast(someValue);
            }
            public void AddLast(int someValue)
            {
                if (head == null)//the edge case in here
                {
                    AddFirst(someValue);
                    return;
                }
                //create new node
                Node newNode = new Node(someValue);

                //traverse the list... to get to the last not-null node in the list
                Node finger = head;
                while (finger.Next != null)
                {
                    finger = finger.Next;
                }
                //when you get here finger points to the last not-null node
                //link in the new node
                finger.Next = newNode;
            }

            //DeleteFirst
            public void DeleteFirst()
            {
                if (head == null)
                {
                    throw new Exception("You can't delete first from an empyu list");
                }
                else
                {
                    head = head.Next;

                }
            }
            //DeleteLast
            public void DeleteLast()
            {
                if (head == null)//first edge case
                {
                    throw new Exception("you can't delete last of an empty list!!");
                }
                else if (head.Next == null)
                {
                    head = null;
                }
                else
                {
                Node finger = head;
                while(finger.Next.Next != null)
                {
                    finger = finger.Next;

                    //linkout the last node
                }
                    finger.Next = null;
                }
            }
            //Insert
            public void Insert(int someValue, int index)
            {
                //create a new node
                Node newNode = new Node(someValue);

                //need to find the node at position index - 1
                Node finger = head;
                for (int position = 0; finger.Next != null && position < index; position++)
                {
                    finger = finger.Next;
                }
                //link in the node
                newNode.Next = finger.Next;
                finger.Next = newNode;
            }
            //Delete
            //Print / travers
            public void Print()
            {
                if (head == null)//if the list is empty
                {
                    Console.WriteLine("The List is empty");
                }
                else
                {
                    Node finger = head;
                    while (finger != null)
                    {
                        Console.WriteLine(finger.Value + " ");
                        finger = finger.Next; //finger.Next.Next.Next.Next....and so and so
                    }
                    Console.WriteLine();
                }
            }
            //constructor
            public SinglyLinkedList()
            {
                //head = null;
            }



        }
    }
}
