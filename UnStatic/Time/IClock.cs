using System;

namespace UnStatic.Time
{
    public interface IClock
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateTime Today { get; }
    }
}