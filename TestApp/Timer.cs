using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading;

namespace TestApp
{
    class Timer
    {
        public event EventHandler TimerReached;

        protected virtual void OnTimerReached(EventArgs e)
        {
            EventHandler handler = TimerReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }



        public Timer()
        {
            Delegate2 d = new Delegate2(Delegates.d1);
            //d += Delegates.d1;
            d += Delegates.d2;

            while (true)
            {
                DateTime dt;
                dt = DateTime.Now;

                Signal(Delegates.d2, dt);

                if (dt.Second % 5 == 0)
                {
                    //Signal(Delegates.d1);
                    //Signal(Delegates.d1, dt);
                    
                    EventArgs e = new EventArgs();
                    OnTimerReached(e);
                }
                else
                {
                    //Signal(Delegates.d2);
                    //Signal(Delegates.d2, dt);
                    //Signal(d, dt);
                }


                Thread.Sleep(1000);

            }
        }

        //public void Signal(Delegate1 del)
        //{
        //    del();
        //}

        public void Signal(Delegate2 del, DateTime dt)
        {
            del(dt);
        }
    }

}
