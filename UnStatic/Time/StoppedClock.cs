using System;

namespace UnStatic.Time
{
    public class StoppedClock:IClock
    {
        private DateTime _time;

        public StoppedClock(DateTime time)
        {
            _time = time;
        }
        public void SetClock(DateTime newTime)
        {
            _time = newTime;
        }
        public DateTime Now
        {
            get { return _time; }
        }

        public DateTime UtcNow
        {
            get { return _time.ToUniversalTime(); }
        }

        public DateTime Today
        {
            get {  return _time.Date; }
        }
    }
}