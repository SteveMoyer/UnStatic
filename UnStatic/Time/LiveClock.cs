using System;

namespace UnStatic.Time
{
    public class LiveClock : IClock
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }


        public DateTime Today
        {
            get { return DateTime.Today; }
        }
    }
}