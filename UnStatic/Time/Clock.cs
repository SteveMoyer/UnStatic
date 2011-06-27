using System;

namespace UnStatic.Time
{
    public class Clock 
    {
        private static IClock _clock = new LiveClock();
        public static void SetClock(IClock clock)
        {
            _clock = clock;
        }
        public static void ResetClock()
        {
            _clock = new LiveClock();
        }

        public static DateTime Now
        {
            get { return _clock.Now; }
        }

        public static DateTime UtcNow
        {
            get { return _clock.UtcNow; }
        }


        public static DateTime Today
        {
            get { return _clock.Today; }
        }
    }
}
