using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading;

namespace TestApp
{

    public delegate void CustomTimerReachedEventHandler(Object sender, CustomTimerReachedEventArgs e);

    public class CustomTimerReachedEventArgs: EventArgs
    {
        public DateTime dt { get; set; }

        public CustomTimerReachedEventArgs(DateTime dt)
        {
            this.dt = dt;
        }
    }

    class CustomTimer
    {
        public event EventHandler TimerReachedHandler;

        protected virtual void OnTimerReached(EventArgs e)
        {
            EventHandler handler = TimerReachedHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        
        public event CustomTimerReachedEventHandler CustomTimerReachedHandler;

        protected virtual void OnCustomTimerReached(CustomTimerReachedEventArgs e)
        {
            CustomTimerReachedEventHandler handler = CustomTimerReachedHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public CustomTimer()
        {
            //Delegate2 d = new Delegate2(Delegates.d1);
            //d += Delegates.d1;
            //d += Delegates.d2;

          
        }


        public void Start()
        {
            while (true)
            {
                DateTime dt;
                dt = DateTime.Now;

                Signal(Delegates.d2, dt);

                if (dt.Second % 3 == 0)
                {
                    //Signal(Delegates.d1);
                    //Signal(Delegates.d1, dt);

                    //EventArgs e = new EventArgs();
                    OnTimerReached(EventArgs.Empty);
                }
                if (dt.Second % 5 == 0)
                {
                    CustomTimerReachedEventArgs e = new CustomTimerReachedEventArgs(dt);

                    OnCustomTimerReached(e);
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
