using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : User
    {
        public Student(string Name, string passWord)
        {
            base._UserName = Name;
            base._PassWord = passWord;
        }

        public Student()
        {

        }
    }
}
