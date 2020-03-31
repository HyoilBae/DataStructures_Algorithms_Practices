using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 3, 5, 7, 9};
            ////arr.add
            //Node n1; //this is just a pointer
            //Console.WriteLine(n1);
            //Node n2 = new Node(17); //this is an instance
            //Console.WriteLine(n2);
            Node someNode = new Node(7);
            Node anotherNode = new Node(11);
            anotherNode.Next = someNode;

            SinglyLinkedList myList = new SinglyLinkedList();
           
            myList.Append(10);
            myList.Append(20);
            myList.Append(30);
            myList.Append(40);

            //myList.Insert(35, 0);
            myList.Delete(4);
            //myList.DeleteFirst();
            myList.Print();


            //try
            //{
            //    myList.DeleteFirst();
            //    myList.Print();
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //LinkedList<int>  myList2 = new LinkedList<int>();
            ////myList2.

        }

        class Node
        {
            //to store
            public int Value { get; set; }
            public Node Next { get; set; }
            //ctor
            public Node(int someVal)
            {
                Value = someVal;
                //Next = null;
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
            //AddLast / Append
            public void Append(int someValue)
            {
                AddLast(someValue);
            }

            public void AddLast(int someValue)
            {
                if (head == null) //the edge case in here
                {
                    AddFirst(someValue);
                    return;
                }
                //create a new node
                Node newNode = new Node(someValue);

                //traverse the list ... to get to the last not-null node in the list
                Node finger = head;
                while(finger.Next!=null)
                {
                    finger = finger.Next;
                }

                //when you get here finger points to the last not null node
                //link in the new node
                finger.Next = newNode;

            }
            
            //DeleteFirst
            public void DeleteFirst()
            {
                if (head == null)//edge case
                    throw new Exception("you can't delete first from an empty list");
                else
                    head = head.Next; //move the head, let the GC garbage collector deallocate memory 
            }
            //DeleteLast
            public void DeleteLast()
            {
                if(head==null)//first edge case
                {
                    throw new Exception("you can't delete last of an empty list!!!");
                    
                }
                else if(head.Next==null)//edge case when we have only one node
                {
                    head = null;
                }
                else
                {
                    Node finger = head;

                    while (finger.Next.Next != null)
                    {
                        finger = finger.Next;//move right
                    }

                    //now finger points to the node before the last in the list
                    //linkout the last node
                    finger.Next = null;
                }
               
            }
            //Insert
            public void Insert(int someValue, int index)
            {
                //if list is null and position ==0
                if( (index==0) && (head == null))
                {
                    AddFirst(someValue);
                    return;
                }
                //create a new node
                Node newNode = new Node(someValue);

                //need to find the node at position index - 1
                Node finger = head ;
                for (int pos = 0; pos < index - 1; pos++)
                {
                    if(finger==null)
                    {
                        Console.WriteLine("error");
                        return;
                    }
                    finger = finger.Next;
                }

                //link in the node
                newNode.Next = finger.Next;
                finger.Next = newNode;

            }

            //Delete
            public void Delete(int index)
            {
                if(index < 0)
                {
                    return;
                }
                if(index == 0)
                {
                    DeleteFirst();
                }
                else
                {
                    //need to find the node at position index - 1
                    Node finger = head;
                    for (int pos = 0; pos < index-1 ; pos++)
                    {
                        if (finger == null)
                        {
                            Console.WriteLine("error");
                            return;
                        }
                        finger = finger.Next;
                    }

                    //link out 
                    if(finger!= null && finger.Next!=null)
                         finger.Next = finger.Next.Next;
                    else
                        Console.WriteLine("error2");
                }
            }

            //Print / traverse
            public void Print()
            {
                if(head == null)//if the list is empty
                    Console.WriteLine("The List is empty");
                else
                {
                    Node finger = head;
                    while(finger!=null)
                    {
                        Console.Write(finger.Value+ " ");
                        finger = finger.Next; //move finger to the right
                    }
                    Console.WriteLine();
                }
            }

            //ctor
            public SinglyLinkedList()
            {
                //head = null;
            }

        }
    }
}
