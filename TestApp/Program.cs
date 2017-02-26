using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new Test();
            Timer tm = new Timer();

            tm.TimerReached += Delegates.e1;
            //tm.TimerReached += new EventHandler(Delegates.e1);

            Console.ReadKey();
        }
    }
}
