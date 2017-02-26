using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


delegate void Delegate1();

delegate void Delegate2(DateTime dt);

namespace TestApp
{
    class Delegates
    {
        public static void d1()
        {
            Console.WriteLine("This is d1");
        }

        public static void d2()
        {
            Console.WriteLine("This is d2");
        }

        public static void d1(DateTime dt)
        {
            Console.WriteLine(dt.ToLongDateString());
        }

        public static void d2(DateTime dt)
        {
            Console.WriteLine(dt.ToLongTimeString());
        }

        public static void d3(DateTime dt)
        {
            Console.WriteLine(dt.ToShortDateString());
        }

        public static void d4(DateTime dt)
        {
            Console.WriteLine(dt.ToShortTimeString());
        }
        
    }
}
