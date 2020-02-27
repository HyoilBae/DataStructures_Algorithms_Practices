using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> scoreAandB = new List<int>();
            int aScore = 0;
            int bScore = 0;

            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] > b[i])
                {
                    aScore = aScore + 1;
                }
                else if (a[i] < b[i])
                {
                    bScore = bScore + 1;
                }
                else
                {
                    continue;
                }

            }
            scoreAandB.Add(aScore);
            scoreAandB.Add(bScore);

            return scoreAandB;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            //List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            //List<int> result = compareTriplets(a, b);
            List<int> result = compareTriplets(a, b);
            //textWriter.WriteLine(String.Join(" ", result));
            Console.WriteLine(String.Join(" ", result));
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
