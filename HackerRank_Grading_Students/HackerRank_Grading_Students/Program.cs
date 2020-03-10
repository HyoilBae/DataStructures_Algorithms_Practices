using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Grading_Students
{
    class Program
    {
        public static int nextMultipleOf5(int n)
        {
            int i = 1;
            while(n > i*5)
            {
                i++;
            }
            return i*5;
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> finalGrade = new List<int>();
            

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    finalGrade.Add(grades[i]);
                }
                else if (Math.Abs(grades[i] - nextMultipleOf5(grades[i])) < 3)
                {
                    finalGrade.Add(nextMultipleOf5(grades[i]));
                }
                else if (Math.Abs(grades[i] - nextMultipleOf5(grades[i])) >=3)
                {
                    finalGrade.Add(grades[i]);
                }
            }
            return finalGrade;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);


            //int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> grades = new List<int>();

            //for (int i = 0; i < gradesCount; i++)
            //{
            //    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    grades.Add(gradesItem);
            //}
            List<int> grades = new List<int> { 73, 67, 38, 33 };

            List<int> result = gradingStudents(grades);
            Console.WriteLine(String.Join("\n", result));
            //List<int> result = Result.gradingStudents(grades);
            //textWriter.WriteLine(String.Join("\n", result));
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
