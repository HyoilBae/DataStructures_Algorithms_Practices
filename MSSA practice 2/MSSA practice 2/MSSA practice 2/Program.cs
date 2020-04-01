using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace MSSA_practice_2
{
    class Program
    {
        static void Method1()
        {

        }
        void  Method2()
        {

        }
        static void Main(string[] args)
        {

            int[] vals = { 1,6,7,8};
            int[] another = new int[10];
            
            Console.WriteLine(another[2]);//display the third value in vals2

            string[] strArr = new string[7];
            //Console.WriteLine(strArr[2]);
            if(strArr[2]=="")
                Console.WriteLine("empty string");
            else if(strArr[2]==null)
                Console.WriteLine("null");
            else
                Console.WriteLine("unknown");

            string str1 = "", str2 = null;
            str1.ToLower();
            // str2.ToLower();  -->will crash

            int[] ids =  { 2, 3, 8,9, -2, 10};
            //ids.Append(34);

            //List<int> myList = new List<int>(); -->List is a generic collection
            ArrayList myList = new ArrayList(); //-->ArrayList is non-generic
            //List<String> myList
            
            Console.WriteLine("count = {0}, capacity = {1}", myList.Count, myList.Capacity);

            myList.Add(2);
            Console.WriteLine("count = {0}, capacity = {1}", myList.Count, myList.Capacity);

            myList.Add(22);
            Console.WriteLine("count = {0}, capacity = {1}", myList.Count, myList.Capacity);

            myList.Add(24);
            Console.WriteLine("count = {0}, capacity = {1}", myList.Count, myList.Capacity);

            myList.Add(-1);
            Console.WriteLine("count = {0}, capacity = {1}", myList.Count, myList.Capacity);

            myList.Add(42);
            Console.WriteLine("count = {0}, capacity = {1}", myList.Count, myList.Capacity  );

            //myList.Add("MSSA");
            Console.WriteLine(myList);
            
            MyOwnArrayList myOwnList1 = new MyOwnArrayList(); //creates a new instance of MyOwnArrayList
            MyOwnArrayList myOwnList2 = new MyOwnArrayList();
            MyOwnArrayList myOwnList3 = new MyOwnArrayList();
            MyOwnArrayList myOwnList4 = new MyOwnArrayList();


            Console.WriteLine("count = {0}, capacity = {1}", myOwnList1.Count, myOwnList1.Capacity);

            myOwnList1.Add(2);
            Console.WriteLine("count = {0}, capacity = {1}", myOwnList1.Count, myOwnList1.Capacity);

            myOwnList1.Add(22);
            Console.WriteLine("count = {0}, capacity = {1}", myOwnList1.Count, myOwnList1.Capacity);

            myOwnList1.Add(24);
            Console.WriteLine("count = {0}, capacity = {1}", myOwnList1.Count, myOwnList1.Capacity);

            myOwnList1.Add(-1);
            Console.WriteLine("count = {0}, capacity = {1}", myOwnList1.Count, myOwnList1.Capacity);

            myOwnList1.Append(42);
            Console.WriteLine("count = {0}, capacity = {1}", myOwnList1.Count, myOwnList1.Capacity);

            Console.WriteLine(myOwnList1);


            Testing myTest = new Testing();
            //myTest.MyProperty = 7;
            Console.WriteLine(myTest.MyProperty);

            String str = "";
            str.MyMSSAMethod();
            
        }
    }



    class Testing
    {
        public int MyProperty { get; private set; }
    }
    class MyOwnArrayList
    {
        //data
        private int[] values;//we will store in here all the values of the list

        private int _count;
        public int Count { get { return _count; }  }

        public int Capacity { get; private set; }

        //private int _capacity;
        //public int Capacity { get { return _capacity; }  
        //    set { if(value>0) _capacity = value; } }

        //methods
        public void Add(int someValue)
        {
            //if the array is full ... then double the size ... resize
            if (Count == Capacity)
                Resize();
            values[Count] = someValue;
            _count++;
        }

        //methods
        public void Append(int someValue)
        {
            Add(someValue);
        }

        private void Resize()
        {
            if(Capacity==0)
            {
                values = new int[4];
                Capacity = 4;
            }
            else //we double the capacity each time
            {
                Capacity *= 2;//Capacity = Capacity * 2;
                int[] oldValues = values; //keep track of the old values ... create a handle to that array

                values = new int[Capacity];//values now points to a new block, larger block

                //copy all the values from the old block into the new block
                for(int i=0; i<Count; i++)
                {
                    values[i] = oldValues[i];
                }
            }
        }


        public override string ToString()
        {
            string ret = "";
            for(int i=0; i<Count;i++)
                ret = ret + " " + values[i];
            return ret;
        }
        //ctor - we do initialization in here ...
        public MyOwnArrayList()
        {
            values = new int[0];
            //Capacity = 0;
            //Count = 0;
        }
    }
}


namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int MyMSSAMethod(this String str)
        {
            return -1;
        }
    }
}
