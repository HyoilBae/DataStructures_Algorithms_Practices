using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Struct
{
    class Program
    {

        public struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double GPA { get; set; }

            private string _major;
            public string Major
            {
                get { return _major; }
                set
                {
                    if (value == "MSSA")
                    {
                        _major = value;
                    }
                    else
                    {
                        _major = "other";
                    }

                }

            }

            //public Student(string newFirstName, string newLastName, double newGPA, string newMajor)
            //{
            //    this.FirstName = newFirstName;
            //    this.LastName = newLastName;
            //    this.GPA = newGPA;
            //    this.Major = newMajor;
            //}
        }

        static void Main(string[] args)
        {
            Student alice = new Student();
            alice.FirstName = "Alice";
            alice.LastName = "Brown";
            alice.GPA = 3.56;
            alice.Major = "MSSA";
        }
    }
}
