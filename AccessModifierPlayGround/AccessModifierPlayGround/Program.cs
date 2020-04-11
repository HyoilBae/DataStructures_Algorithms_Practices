using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierPlayGround
{
    public class A
    {
        protected string Name = "Hyo";

        internal int Age = 34;

        protected internal int myValue = 0;
    }

    class Program : A
    {
        static void Main(string[] args)
        {
            //public
            //private
            //protected
            //internal
            //protected internal
            //private protected

            privateMethod test1 = new privateMethod();
            //test1.Method1(); //infinite loop

            var a = new Program();
            var b = new A();
            Console.WriteLine(a.Name);
            a.Name = "Sue";
            Console.WriteLine(a.Name);
            //b.Name = "Jina";
            Console.WriteLine(a.Age);

            a.myValue = 5;
            Console.WriteLine(a.myValue);
        }
    }

    //private methods in public class
    public class privateMethod
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
            Method2();
        }

        private void Method2()
        {
            Console.WriteLine("Method2");
            Method1();
        }
    }


}

namespace OutOfInternal
{
    using AccessModifierPlayGround;

    class AoutOfInternal : A
    {
        static void Main()
        {
            var testProtectedInternal = new AoutOfInternal();
            testProtectedInternal.myValue = 3;

        }
        
        
    }
}

