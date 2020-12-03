using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            child child = new child();
            child c = child;
            Console.WriteLine(c.Sub(10, 5));
        }
    }

    abstract class parent
    {
        protected abstract int Sub(int a, int b);
    }

    abstract class child : parent
    {
        protected override int Sub(int a, int b)
        {
            return a - b;
        }

        internal int sub(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}