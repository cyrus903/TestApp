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
            Console.WriteLine("d1 " + dt.ToLongDateString());
        }

        public static void d2(DateTime dt)
        {
            Console.WriteLine("d2 " + dt.ToLongTimeString());
        }

        public static void d3(DateTime dt)
        {
            Console.WriteLine("d3 " + dt.ToShortDateString());
        }

        public static void d4(DateTime dt)
        {
            Console.WriteLine("d4 " + dt.ToShortTimeString());
        }



        public static void event1(Object sender, EventArgs e)
        {
            Console.WriteLine("event1 " + sender.GetType() + " " + e.GetType());
        }

        public static void event2(Object sender, EventArgs e)
        {
            Console.WriteLine("event2 " + sender.GetType() + " " + e.GetType());
        }


        public static void customEvent1(Object sender, CustomTimerReachedEventArgs e)
        {
            Console.WriteLine("customEvent1 " + sender.GetType() + " " + e.GetType() + " " + e.dt);
        }
    }
}
