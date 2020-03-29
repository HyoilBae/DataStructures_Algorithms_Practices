using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubleNumber= 123.3;
            var intNumber = 123;

            intNumber = Convert.ToInt32(doubleNumber);
        }
    }
}
