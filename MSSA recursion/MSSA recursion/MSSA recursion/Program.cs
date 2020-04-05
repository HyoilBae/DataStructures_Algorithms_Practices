using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for(int i=0;i<1000;i++)
                    Console.WriteLine(  "Fib({0})={1}", i, Fibonacci3(i) );
            }
            catch (Exception eeeee)
            {
                Console.WriteLine(eeeee.Message);
            }

            Console.WriteLine("MSSA");
        }

        public static int Fibonacci(int index)
        {
            if (index < 0)
                throw new Exception("you can't use negatives");

            else if (index == 0)
                return 0;
            else if (index == 1)
                return 1;
            else
                return Fibonacci(index - 2) + Fibonacci(index - 1);
        }

        //will store computed values of Fibonacci
        public static Dictionary<int,long> memory = new Dictionary<int, long>(); 

        public static long FibonacciWithMemoization(int index)
        {
            if (index < 0)
                throw new Exception("you can't use negatives");

            if (memory.ContainsKey(index))
                return memory[index];
            else if(index==0)
            {
                return 0;
            }
            else if (index == 1)
            {
                return 1;
            }
            else
            {
                long newVal = FibonacciWithMemoization(index - 2) + FibonacciWithMemoization(index - 1);
                memory.Add(index,newVal);
                return newVal;
            }
              
        }

        public static long Fibonacci3(int index)
        {
            if (index < 0)
                throw new Exception("you can't use negatives");

            else if (index == 0)
                return 0;
            else if (index == 1)
                return 1;
            else
            {
                long ret = 0;
                long retM1 = 0;
                long retM2 = 1;
                for (int i = 2; i <= index; i++)
                {
                    ret = retM1 + retM2;
                    retM2 = retM1;
                    retM1 = ret;
                }
                return ret;

            }
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
