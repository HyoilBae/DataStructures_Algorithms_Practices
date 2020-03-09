using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_TImeConversion
{
    class Program
    {
        static string timeConversion(string s)
        {

            /*
             * Write your code here.
             */
            DateTime milTime = DateTime.Parse(s);
            return milTime.ToString("HH:mm:ss");
            

            //DateTime inputDateTime, militaryTime;
            //string strDateTime = s;
            //strDateTime.ToString("M/d/yyyy HH:mm");
            //try
            //{
            //    inputDateTime = DateTime.Parse(strDateTime);
            //    militaryTime = inputDateTime.MilitaryTime;
            //    //Console.WriteLine("{0} local time is {1} military time.", inputDateTime, militaryTime);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid format.");
            //    return timeConversion(s);
            //}
            //return militaryTime;
        }
        static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string s = Console.ReadLine();
            string s = "07:05:45PM";

           // timeConversion(s);
            string result = timeConversion(s);
            Console.WriteLine(result);

            //07:05:45PM
            //19:05:45


            //tw.WriteLine(result);

            //tw.Flush();
            //tw.Close();
        }
    }
}
