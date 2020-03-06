using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNumberValueSort
{
    class Program
    {
        static void Main(string[] args)
        {
            HighLow("1 2 3 4 5");
            HighLow("1 2 -3 4 5");
            HighLow("1 9 3 4 -5");
            HighLow("13");

            //int[] intNumArr = new int[] { 5, 2, 3, 4, 1 };
            //HighLow(intNumArr);
        }

        public static void HighLow(string str)
        {
            int min = 0;
            int max = 0;

            foreach (string n in str.Split(' '))
            {
                Console.Write(n + ", ");

                if (Convert.ToInt32(n) > max)
                {
                    max = Convert.ToInt32(n);
                }
                if (Convert.ToInt32(n) < min)
                {
                    min = Convert.ToInt32(n);
                }
            }
            Console.WriteLine("MAX number is = {0} MIN number is = {1}", max, min);
       
        }



        //public static void HighLow(int[] intArr)
        //{
        //    List<int> intList = new List<int>();

        //    for (int i = 0; i < intArr.Length; i++)
        //    {
        //        intList.Add(intArr[i]);
        //    }

        //    Console.WriteLine("After string numbers are converted to int numbers and remove spaces between numbers");
        //    foreach (var item in intList)
        //    {
        //        Console.Write(item);
        //    }
        //    Console.WriteLine();

        //    for (int i = 0; i < intArr.Length; i++)
        //    {
        //        for (int j = 0; j < intArr.Length; j++)
        //        {
        //            if (intArr[i] < intArr[j])
        //            {
        //                var temp = intArr[j];
        //                intArr[j] = intArr[i];
        //                intArr[i] = temp;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Numbers after sorted");
        //    Console.WriteLine(string.Join(" ", intList));

        //    //result
        //    Console.WriteLine($"The smallest number is : {intList[0]}");
        //    Console.WriteLine($"The biggest number is : {intList[intList.Count - 1]}");
        //}

        //public static void HighLow(string str)
        //{
        //    var format = new NumberFormatInfo();
        //    format.NegativeSign = "-";
        //    format.NumberDecimalSeparator = ".";

        //    Console.WriteLine("User Input :");
        //    Console.WriteLine(string.Join(", ", str));

        //    List<int> intList = new List<int>();

        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if ((int)char.GetNumericValue(str[i]) == -1)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            int number = (int)char.GetNumericValue(str[i]);
        //            intList.Add(number);
        //        }
        //    }

        //    Console.WriteLine("After string numbers are converted to int numbers and remove spaces between numbers");
        //    foreach (var item in intList)
        //    {
        //        Console.Write(item);
        //    }
        //    Console.WriteLine();

        //    //smae as problem 3 method
        //    for (int i = 0; i < intList.Count; i++)
        //    {
        //        for (int j = 0; j < intList.Count; j++)
        //        {
        //            if (intList[i] < intList[j])
        //            {
        //                var temp = intList[j];
        //                intList[j] = intList[i];
        //                intList[i] = temp;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Numbers after sorted");
        //    Console.WriteLine(string.Join(" ", intList));

        //    //result
        //    Console.WriteLine($"The smallest number is : {intList[0]}");
        //    Console.WriteLine($"The biggest number is : {intList[intList.Count - 1]}");





        //}
    }
}
