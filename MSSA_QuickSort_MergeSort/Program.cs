using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_QuickSort_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mergeArr = new int[] { 1, 3, 10, 12, 15, 2, 3, 4, 5 };
            //MergeSort(mergeArr);
            QuickSort(mergeArr);
            Console.WriteLine(string.Join(", ", mergeArr));
            Console.WriteLine();

            //int[] nums = Array.ConvertAll(File.ReadAllLines("randomTxtNumber.txt"), line => Convert.ToInt32(line));
            //MergeSort(nums);
            //QuickSort(nums);
            //Console.WriteLine(string.Join(", ", nums));

            //Random randomInt = new Random();
            //int[] millionNumber = new int[1000000];
            //for (int i = 0; i < 1000000; i++)
            //{
            //    millionNumber[i] = randomInt.Next(0, int.MaxValue);
            //}
            //MergeSort(millionNumber);
            //Console.WriteLine(string.Join("\n", millionNumber));
        }



        public static void QuickSort(int[] arr)
        {
            QuickSortHelper(arr, 0, arr.Length - 1);
        }
        public static void QuickSortHelper(int[] arr, int startPos, int endPos)
        {
            if(endPos - startPos >=1) //onyl do the sort if you have at least two elements
            {
                int pivot = arr[endPos];
                int newPivotPos = Partition(arr, startPos, endPos);
                QuickSortHelper(arr, startPos, newPivotPos - 1);
                QuickSortHelper(arr, newPivotPos + 1, endPos);
            }
        }

        public static int Partition(int[] arr, int startPos, int endPos)
        {
            int pivot = arr[endPos];
            int j = startPos - 1; // j holds the position of the lst value found taht is less than pivot
            for (int i = startPos; i <= endPos; i++) // i takes me through all the elements
            {
                if (arr[i]<pivot)
                {
                    j++;
                    //swap at i and j
                    int tmp2 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp2;
                }
            }

            //move the pivot in its final position
            int tmp = arr[j + 1];
            arr[j + 1] = arr[endPos];
            arr[endPos] = tmp;

            return j + 1;
        }



        public static void MergeSort(int[] arr)
        {
            int[] tmp = new int[arr.Length];
            MergeSortHelper(arr, 0, arr.Length - 1, tmp);
        }

        public static void MergeSortHelper(int[] arr, int startPosition, int endPosition, int[] tmp)
        {
            if (endPosition - startPosition >= 1) //if we have at least two elements
            {
                int middlePosition = (startPosition + endPosition) / 2;
                MergeSortHelper(arr, startPosition, middlePosition, tmp);
                MergeSortHelper(arr, middlePosition + 1, endPosition, tmp);
                Merge(arr, startPosition, middlePosition, endPosition, tmp);
            }
        }

        public static void Merge(int[] arr, int startPosition, int middlePosition, int endPosition, int[] tmp)
        {
            int i = startPosition;
            int j = middlePosition + 1;
            int k = i;

            //int[] tmp = new int[arr.Length]; // this is going to make a new array everytime so that this won't be very efficient way
                                            //instead of doing this, you better create this once in MergeSort method and pass them as a parameter

            while (i <= middlePosition && j <= endPosition)
            {
                if (arr[i] < arr[j])
                {
                    tmp[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    tmp[k] = arr[j];
                    j++;
                    k++;
                }
            }

            //copy left overs
            while ( i <= middlePosition)
            {
                tmp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= endPosition)
            {
                tmp[k] = arr[j];
                j++;
                k++;
            }

            //push elements from tmp back into arr
            for (k = startPosition; k < endPosition; k++)
            {
                arr[k] = tmp[k];
            }
        }
    }
}
