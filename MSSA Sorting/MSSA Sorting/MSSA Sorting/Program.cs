﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] nums = {10, 5, 22, 7, 30, 3, 1, 8, -2 };
            PrintArray(nums);

            //BubbleSort(nums);
            //SelectionSortReverse(nums);
            MergeSort(nums);
            PrintArray(nums);


        }

        static void SelectionSort(int[] arr)
        {
            for (int j = 0; j < arr.Length-1; j++)
            {
                int hand = j; //stores the position of the smallest value
                for (int i = j+1; i < arr.Length; i++)//this traverses the array
                {
                    if (arr[hand] > arr[i])//if I find something smaller in the array
                    {
                        //save it's position
                        hand = i;//i is the position, arr[i] is the value
                    }
                }
                //hand is the position of the smallest value
                int tmp = arr[hand]; //swap arr[hand] with arr[0]
                arr[hand] = arr[j];
                arr[j] = tmp;
            }
        }
        static void SelectionSortReverse(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int hand = j; //stores the position of the smallest value
                for (int i = j + 1; i < arr.Length; i++)//this traverses the array
                {
                    if (arr[hand] < arr[i])//if I find something larger in the array
                    {
                        //save it's position
                        hand = i;//i is the position, arr[i] is the value
                    }
                }
                //hand is the position of the smallest value
                int tmp = arr[hand]; //swap arr[hand] with arr[0]
                arr[hand] = arr[j];
                arr[j] = tmp;
            }
        }
        static void BubbleSort(int[] arr)
        {
            for (int j = 0; j < arr.Length-1; j++)
            {
                for (int i = 0; i < arr.Length - 1-j; i++)
                {
                    if (arr[i] > arr[i + 1]) //two adjacent numbers out of sequence
                    {                   //then swap them
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }
        }
        static void MergeSort(int[] arr)
        {
            int[] tmp = new int[arr.Length];
            MergeSortHelper(arr, 0, arr.Length - 1,tmp);
        }

        static void MergeSortHelper(int[] arr, int firstIdx, int lastIdx, int[] tmp)
        {
            if (firstIdx<lastIdx)//only divide if you have at least two elements
            {
                //divide and conquer
                int midIdx = (firstIdx + lastIdx) / 2;
                MergeSortHelper(arr, firstIdx, midIdx, tmp);//recursively sort the first half
                MergeSortHelper(arr, midIdx + 1, lastIdx,tmp);//recursively sort the second half
                Merge(arr, firstIdx, midIdx, lastIdx,tmp);
            }

        }

        static void Merge(int[] arr, int firstIdx, int midIdx, int lastIdx, int[] tmp)
        {
            int i = firstIdx;
            int j = midIdx + 1;
            int k = firstIdx;

            while (i <= midIdx && j <=lastIdx)
            {
                if(arr[i]<=arr[j])
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

            for ( k = firstIdx; k <= lastIdx; k++) //push elements from tmp back into arr
                arr[k] = tmp[k];


        }

        static void PrintArray(int[] arr)
        {
            foreach(int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}