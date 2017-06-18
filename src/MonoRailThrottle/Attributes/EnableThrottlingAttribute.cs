using Castle.MonoRail.Framework;
using MonoRailThrottle.Models;

namespace MonoRailThrottle.Attributes
{
    //INFO считывается рефлексией
    public class EnableThrottlingAttribute : FilterAttribute
    {
        public EnableThrottlingAttribute(ExecuteWhen when)
            : base(when, typeof(EnableThrottlingImpl))
        {
        }

        public long PerSecond { get; set; }

        public long PerMinute { get; set; }

        public long PerHour { get; set; }

        public long PerDay { get; set; }

        public long PerWeek { get; set; }

        public long GetLimit(RateLimitPeriod period)
        {
            switch (period)
            {
                case RateLimitPeriod.Second:
                    return PerSecond;
                case RateLimitPeriod.Minute:
                    return PerMinute;
                case RateLimitPeriod.Hour:
                    return PerHour;
                case RateLimitPeriod.Day:
                    return PerDay;
                case RateLimitPeriod.Week:
                    return PerWeek;
                default:
                    return PerSecond;
            }
        }
    }
}