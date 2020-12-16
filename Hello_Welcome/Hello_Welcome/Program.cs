using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Welcome
{
    class Program
    {
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            new Program().sayHello();   
            new Class1().printWelcome();
        }
    }
}
