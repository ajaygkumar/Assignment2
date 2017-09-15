using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace passbyvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int c=1;
            sample(c);
            Console.WriteLine(c);
            Console.ReadKey();
        }
        public static void sample(int b)
        {
            b = 100;
        }
    }
}
