using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading;

namespace TestApp
{

    public delegate void CustomTimerReachedEventHandler(Object sender, CustomTimerReachedEventArgs e);

    public delegate void MyEventHandler(int i);

    //public delegate void EventHandler(Object sender, EventArgs e);

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
        public event EventHandler TimerReached;

        protected virtual void OnTimerReached(EventArgs e)
        {
            EventHandler handler = TimerReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        
        public event CustomTimerReachedEventHandler CustomTimerReached;        

        protected virtual void OnCustomTimerReached(CustomTimerReachedEventArgs e)
        {
            CustomTimerReachedEventHandler handler = CustomTimerReached;
         
            if (handler != null)
            {
                handler(this, e);               
            }
        }

        public event MyEventHandler MyEventRaised;

        protected virtual void OnMyEventRaised(int i)
        {
            if (MyEventRaised != null)
            {
                MyEventRaised(i);
            }
        }
       

        public CustomTimer()
        {            
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
                    OnTimerReached(EventArgs.Empty);
                }
                else if (dt.Second % 5 == 0)
                {
                    CustomTimerReachedEventArgs e = new CustomTimerReachedEventArgs(dt);

                    OnCustomTimerReached(e);
                }
                else if (dt.Second % 7 == 0)
                {
                    int i = dt.Millisecond;
                    OnMyEventRaised(i);
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
