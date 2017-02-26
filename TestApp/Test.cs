using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate void d();

namespace TestApp
{
    class Test
    {
        public Test()
        {
            d concreteD = new d(Delegates.d2);

            concreteD();

        }
    }


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
    }
}
