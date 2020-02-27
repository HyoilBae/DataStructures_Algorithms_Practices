using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_ArrayDS
{
    class Program
    {
        // Complete the reverseArray function below.
        static int[] reverseArray(int[] a)
        {
            //Create List Generic type
            List<int> intGenericArr = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                intGenericArr.Add(a[a.Length - 1 - i]);
            }
            a = intGenericArr.ToArray();
            return a;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arrCount = Convert.ToInt32(Console.ReadLine());
            int arrCount = Convert.ToInt32(Console.ReadLine());
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //int[] res = reverseArray(arr);
            int[] res = reverseArray(arr);
            //textWriter.WriteLine(string.Join(" ", res));
            Console.WriteLine(string.Join(" ", res));
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
