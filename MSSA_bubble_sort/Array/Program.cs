using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = new string[7];
            if (strArr[2] == "")
            {
                Console.WriteLine("Empty String");
            }
            else if (strArr[2] == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine("Unknown");
            }


            MyOwnArrayList myOwnList1 = new MyOwnArrayList();
            myOwnList1.Add(34);
            myOwnList1.ToString();
            //myOwnList1.Count
        }
    }

    class MyOwnArrayList
    {
        private int[] values;
        private int _count;
        public int Count { get; private set; }
        public int Capacity { get; set; }

        public MyOwnArrayList()
        {

        }

        public void Add(int n)
        {
            if (Count == Capacity)
            {
                Resize();
            }
            values[Count] = n;
            _count++;
        }

        private void Resize()
        {
            if(Capacity == 0)
            {
                values = new int[4];
                Capacity = 4;
            }
            else
            {
                Capacity *= 2;
                int[] oldValues = values;

                values = new int[Capacity];

                for (int i = 0; i < Count; i++)
                {
                    values[i] = oldValues[i];
                }
            }
        }

        //public override string ToString()
        //{
        //    string ret = "";
        //    for (int val = 0; val < values.Length; val++)  //foreach (int val in values)
        //    {
        //        ret = ret + " " + val;
        //    }
        //    return ret;
        //}

        public void Append(int n)
        {
            Add(n);
        }
    }
}
