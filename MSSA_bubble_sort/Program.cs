using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            ////-------------------bubble sort
            //int[] nums = { 10, 5, 22, 7, 30, 3, 1, 8, -2 };
            //int[] numsInOrder = new int[nums.Length];
            //PrintArray(nums);
            //Console.WriteLine();

            //BubbleSort(nums);
            //PrintArray(nums);
            //Console.WriteLine();

            ////------------------Selection Sort
            //int[] nums2 = { 10, 5, 22, 7, 30, 3, 1, 8, -2 };
            //PrintArray(nums2);
            //Console.WriteLine();

            //SelectionSort(nums2);
            //PrintArray(nums2);
            //Console.WriteLine();

            //----------------------MergeSort
            int[] num3 = { 3, 12, 7, 8, 0, 37, 41, 7 };
            PrintArray(num3);
            Console.WriteLine();

            MergeSort(num3);
            PrintArray(num3);
            Console.WriteLine();

        }
        static void MergeSort(int[] arr)
        {
            int[] tmp = new int[arr.Length];
            MergeSortHelper(arr, 0, (arr.Length - 1), tmp);
        }
        static void MergeSortHelper(int[] arr, int firstIdx, int lastIdx, int[] tmp)
        {
            if (firstIdx < lastIdx)//only divide if you have at least two elements
            {
            //divide and conquer
            int midIdx = (firstIdx + lastIdx) / 2;
            //recursively sort the first half
            MergeSortHelper(arr, firstIdx, midIdx, tmp);
            MergeSortHelper(arr, midIdx + 1, lastIdx, tmp);
            Merge(arr, firstIdx, midIdx, lastIdx, tmp);
            }
        }
        static void Merge(int[] arr, int firstIdx, int midIdx, int lastIdx, int[] tmp)
        {
            int i = firstIdx;
            int j = midIdx + 1;
            int k = firstIdx;

            while (i <= midIdx && j <= lastIdx)
            {
                if (arr[i] < arr[j])
                {
                    tmp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    tmp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            //copy left overs
            while (i <= midIdx)
            {
                tmp[k] = arr[i];
                k++;
                i++;
            }
            while (j <= lastIdx)
            {
                tmp[k] = arr[j];
                k++;
                j++;
            }

            for (k = firstIdx; k <= lastIdx; k++) //push elementss from tmp back into arr
            {
                arr[k] = tmp[k];
            }
        }

        static void SelectionSort(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int hand = j; //stores the position 
                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[hand] > arr[i]) //if I find something smaller in the array
                    {
                        //save it's position
                        hand = i; //i is te position, arr[i] is the value
                    }
                }
                //hand is the position of the smallest value
                int tmp = arr[hand];
                arr[hand] = arr[j];
                arr[j] = tmp;
            }
        }

        static void BubbleSort(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1 - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }

            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
