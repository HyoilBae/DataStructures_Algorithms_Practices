using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class User
    {
        public string _UserName { get; set; }
        protected string _PassWord { get; set; }

        public User(string UserName, string PassWord)
        {
            _UserName = UserName;
            _PassWord = PassWord;
            
        }

        public User()
        {
           
        }
        public void Hello()
        {
            Console.WriteLine("Hello {0}", _UserName);
            //Console.WriteLine($"Hello {UserName}");
        }
        public override string ToString()
        {
            return _UserName;
        }
    }
}
