using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC440_module04_part2__Interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Student> myDictionary = new Dictionary<int, Student>();
            myDictionary.Add(1, new Student() { Name="Alice", GPA= 2.0, Major="MSSA"});
            myDictionary.Add(7, new Student() { Name = "Bob", GPA = 1.0, Major = "Hardward" });
            myDictionary.Add(2, new Student() { Name = "Mike", GPA = 4.0, Major = "Music" });
            myDictionary.Add(9, new Student() { Name = "David", GPA = 3.0, Major = "Arts" });
            Console.WriteLine(myDictionary[2]);
            foreach (var key in myDictionary.Keys)
            {
                Console.WriteLine(key+" "+myDictionary[key]);
            }
            Console.WriteLine();
            foreach (var val in myDictionary.Values)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();
            foreach (KeyValuePair<int, Student> pair in myDictionary)
            {
                Console.WriteLine(pair.Key +" "+pair.Value);
            }

            Console.WriteLine("==========================================================");
            //IMyInterface my Interface;
            //myInterface = new IMyInterface();

            Student myStudent = new Student();
            myStudent.Name = "Alice";

            Instructor myInstructor = new Instructor();
            myInstructor.Name = "Bob";

            MyFancyMethod(myStudent);
            MyFancyMethod(myInstructor);

            ArrayList myStudentList = new ArrayList();
            myStudentList.Add(new Student() { Name = "Alice", GPA = 4.0, Major = "Mathmatics" });
            myStudentList.Add(new Student() { Name = "Bob", GPA = 3.0, Major = "Biology" });
            myStudentList.Add(new Student() { Name = "David", GPA = 2.0, Major = "History" });
            myStudentList.Add(new Student() { Name = "Jimbo", GPA = 1.0, Major = "Economic" });
            myStudentList.Add(new Student() { Name = "Hyoil", GPA = 3.5, Major = "Computer Science" });
            //myStudentList.Sort(new MyStudentComparerClass());
            myStudentList.Sort();

            foreach (var item in myStudentList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============================================");
            Larry<int, Student> myLarry = new Larry<int, Student>();
            myLarry.MyTyp1Property = 2020;
            myLarry.MyTyp2Property = new Student() { Name = "Larry", GPA = 4.0, Major = "Chem" };
            myLarry.Print();
        }



        //public void FancyMethod(Student st)
        //{
        //    st.PrintMe();
        //}

        //public void FancyMethod(Instructor st)
        //{
        //    st.PrintMe();
        //}

        public static void MyFancyMethod(ISayHello myObj)
        {
            myObj.PrintMe();
        }

        public static void FancyMethor(IMyEmptyInterface obj)
        {
            //((Student)obj).PrintMe();
        }

        public static T FindMin<T>(T num1, T num2) where T : IComparable
        {
            if (num1.CompareTo(num2) < 0)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

    }
    public class Larry<Type1, Type2>
    {
        public Type1 MyTyp1Property { get; set; }
        public Type2 MyTyp2Property { get; set; }

        public void Print()
        {
            Console.WriteLine(MyTyp1Property+ "\t" +MyTyp2Property);
        }
    }


    public interface ISayHello
    {
        void PrintMe();
    }

    public class Student : ISayHello, IComparable, IMyEmptyInterface
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }

        public int CompareTo(object obj)
        {
            //return this.Major.CompareTo(((Student)obj).Major);
            return string.Compare(this.Major, ((Student)obj).Major);

            //if (this.GPA > ((Student)obj).GPA)
            //{
            //    return -1;
            //}
            //else if (this.GPA < ((Student)obj).GPA)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
        }

        public void PrintMe()
        {
            Console.WriteLine("Hello this is studnet {0}", Name);
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\tGPA: {1}\tMajor: {2}", Name, GPA, Major);
        }
    }

    public interface IMyEmptyInterface
    {

    }

    public class MyStudentComparerClass : IComparer
    {
        public int Compare(object x, object y)
        {
            //return ((Student)x).Name.CompareTo(((Student)y).Name);
            Student studentX = (Student)x;
            Student studentY = (Student)y;
            return studentX.Name.CompareTo(studentY.Name);
        }
    }

    public class Instructor : ISayHello, IMyEmptyInterface
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public void PrintMe()
        {
            Console.WriteLine("Hello this is studnet {0}", Name);
        }
    }
}

