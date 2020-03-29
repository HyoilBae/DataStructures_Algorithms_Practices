using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MagicList<T> : List<T>
    {
        public T ChooseRandom()
        {
            Random randomGenerator = new Random();
            return this[randomGenerator.Next(0, Count)];
        }
    }
}
