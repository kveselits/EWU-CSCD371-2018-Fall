using System;
using System.Windows.Threading;

namespace Assignment8
{
    public class MyClock
    {
        private TimeManager.Time Time { get; }
        private DispatcherTimer Timer { get; }
        public string CurrentTime { get; set; }
        public MyClock()
        {
            Time = new TimeManager.Time();
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromMilliseconds(300);
            Timer.Tick += TimerTick;
            Timer.Start();
        }
        private void TimerTick(object sender, EventArgs args)
        {
            CurrentTime = Time.Now();
        }
        public void AddEvent(EventHandler eventHandler)
        {
            Timer.Tick += eventHandler;
        }
    }
}