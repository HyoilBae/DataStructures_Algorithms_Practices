using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_DiagonalDifference
{
    class Program
    {


        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int x = 0;
            int y = arr[0].Count - 1;
            int sum = 0;
            for (int index = 0; index < arr.Count; index++)
            {
                //sum -= arr[x][x] - arr[x++][y--]; can also be simplified as below:
                sum = sum - (arr[x][x] - arr[x++][y--]);
            }
            return Math.Abs(sum);
        }

        //static int diagonalDifference(int[][] a)
        //{
        //    int row = 0;
        //    int column = a[0].Length - 1;
        //    int sum = 0;
        //    for (int index = 0; index < a.Length; index++)
        //    {
        //        sum -= a[row][row] - a[row++][column--];
                
        //    }
        //    return Math.Abs(sum);
        //}

        //1st diagonal: 0,0 ;  1,1 ;  2,2.
        //2nd diagonal: 2,0  ;  1,1  ;   0,2.

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            int result = diagonalDifference(arr);
            Console.WriteLine(result);


            //int[][] arr = new int[3][]
            //{
            //   new int[] {11, 2, 4},
            //   new int[] {4, 5, 6},
            //   new int[] {10, 8, -12}
            //};
            //int result = diagonalDifference(arr);
            //Console.WriteLine(result);

            //textWriter.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
