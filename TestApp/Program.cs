﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new Test();
            CustomTimer tm = new CustomTimer();

            tm.TimerReached += Delegates.event1;
            //tm.TimerReached += Delegates.event2;
            //tm.TimerReached += new EventHandler(Delegates.e1);

            tm.CustomTimerReached += Delegates.customEvent1;

            tm.MyEventRaised += Delegates.myEvent;

            Thread th = new Thread( tm.Start);
            th.Start();
            
           

            ConsoleKeyInfo info;
            while (true)
            {
                
                info = Console.ReadKey();
                if (info.KeyChar == 'a')
                {
                    Console.WriteLine("You pressed a");
                    //tm.TimerReached += Delegates.event1;
                    tm.TimerReached -= Delegates.event2;
                    tm.TimerReached += Delegates.event1;
                }
                else if (info.KeyChar == 'b')
                {
                    Console.WriteLine("You pressed b");
                    tm.TimerReached -= Delegates.event1;
                    tm.TimerReached += Delegates.event2;
                }

            }
        }
    }
}
