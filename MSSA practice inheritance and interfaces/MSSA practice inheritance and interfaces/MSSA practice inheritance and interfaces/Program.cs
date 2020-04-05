using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSA_practice_inheritance_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            User alice = new User("Alice");
            alice.Hello();

            User bob = new User("Robert");
            bob.Hello();

            Console.WriteLine(alice.ToString());
            //Console.WriteLine(alice.UserName);

            Student bobStudent = new Student();
            bobStudent.Hello();
            //bobStudent.n

            User test1 = new Student();
            test1.Hello2();
            Student test2 = new Student();
            test2.Hello2();

            MagicList<int> myList = new MagicList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            Console.WriteLine(myList.ChooseRandom());


            User st1 = new User(); st1.UserName = "st1";
            User st2 = new User(); st2.UserName = "st2";
            User st3 = new User(); st3.UserName = "st3";
            User st4 = new User(); st4.UserName = "st4";
            User st5 = new User(); st5.UserName = "st5";
            User st6 = new User(); st6.UserName = "st6";
            User st7 = new User(); st7.UserName = "st7";
            User st8 = new User(); st8.UserName = "st8";
            MagicList<User> magicListOfUsers = new MagicList<User>();
            magicListOfUsers.Add(st1);
            magicListOfUsers.Add(st2);
            magicListOfUsers.Add(st3);
            magicListOfUsers.Add(st4);
            magicListOfUsers.Add(st5);
            magicListOfUsers.Add(st6);
            magicListOfUsers.Add(st7);
            magicListOfUsers.Add(st8);
            Console.WriteLine(magicListOfUsers.ChooseRandom());
            Console.WriteLine(magicListOfUsers[3]); //
           
        }
    }

    class User 
    {
        public string UserName { get; set; }
        protected string Password { get; set; }

        public void Hello() 
        { 
            Console.WriteLine("Hello {0}", UserName);
        }

        public virtual void Hello2()
        {
            Console.WriteLine("Hello {0}", UserName);
        }

        public User(string newName)
        {
            UserName = newName;
            Password = "password";
        }

        public User()
        {
            UserName = "new user";
            Password = "password";
        }
        public override string ToString()
        {
            return UserName;
        }

    }

    class Student : User
    {
        public void Hello()
        {
            Console.WriteLine("Hello student: {0}", UserName);
        }

        public override void Hello2()
        {
            Console.WriteLine("Hello student: {0}", UserName);
        }
    }

    class MagicList<TTTTTT>:List<TTTTTT>
    {
        public TTTTTT ChooseRandom()
        {
            Random randGenerator = new Random();
            return this[randGenerator.Next(0, Count)];
        }
    }


    class Basse
    {
        public int MyProperty1 { get; set; }
        protected int MyProperty2 { get; set; }
        private int MyProperty3 { get; set; }
        void Method()
        {
            MyProperty1 = 10; MyProperty2 = 10;MyProperty3 = 10;
        }
    }

    class Deriveddd:Basse
    {
        void Method()
        {
            MyProperty1 = 20; MyProperty2 = 20; // MyProperty3 = 20;
        }
    }

    class Unrelated
    {
        void Method()
        {
            Basse inst = new Basse();
            inst.MyProperty1 = 30; //inst.MyProperty2 = 30; inst.MyProperty3 = 30;
        }
    }
}

