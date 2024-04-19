using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Class1
    {
        public int a;
        private int b;
        internal int c;
        protected int d;
        protected internal int e;
        public Class1()
        {
            a = 1; b = 2; c = 3; d = 4; e = 5;
        }
    }
    public class Class2
    {
        public static void main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine("a,c,e");
        }
    }
    public class Class3:Class1
    {
        public static void main(string[] args)
        {
            Class3 c = (Class3)new Class1();
            Console.WriteLine(c.d);
        }
    }
}

namespace ConsoleApp3
{
    public class Class4
    {
        public static void main(string[] args)
        {
            ConsoleApp2.Class1 c = new ConsoleApp2.Class1();
            Console.WriteLine(c.);
        }
    }
}
