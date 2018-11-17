using System;
using System.Globalization;

namespace Assignment8
{
    public class TimeManager
    {

        public bool Running { get; private set; }
        public IDateTime Current { get; set; }
        public TimeManager(IDateTime current)
        {
            Current = current;
        }

        public string StartTimer()
        {
            Running = true;
            return Current.Now();
        }

        public string StopTimer()
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
            public string Now()
            {
                return System.DateTime.Now.ToString(CultureInfo.CurrentCulture);
            }
        }
    }
}