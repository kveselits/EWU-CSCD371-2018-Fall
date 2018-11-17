using System;
using System.Globalization;

namespace Assignment8
{
    public class TimeManager
    {

        public bool Running { get; private set; } = false;
        public IDateTime Current { get; set; }
        public TimeManager(IDateTime current)
        {
            Current = current;
        }

        public DateTime StartTimer()
        {
            Running = true;
            return Current.Now();
        }

        public DateTime StopTimer()
        {
            if (!Running)
            {
                throw new InvalidOperationException("Timer has not been started.");
            }
            Running = false;
            return Current.Now();
        }


        public class Time : IDateTime
        {
            public DateTime Now()
            {
                return System.DateTime.Now;
            }
        }
    }
}