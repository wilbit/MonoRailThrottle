using log4net;

namespace MonoRailThrottle.Logging
{
    public class TracingThrottleLogger : IThrottleLogger
    {
        private readonly ILog _traceWriter = LogManager.GetLogger(typeof(TracingThrottleLogger));

        public void Log(ThrottleLogEntry entry)
        {
            _traceWriter?.InfoFormat(
                $"{entry.Request}\n{entry.LogDate} Request {entry.RequestId} from {entry.ClientIp} has been throttled (blocked)," +
                $" quota {entry.RateLimit}/{entry.RateLimitPeriod} exceeded by {entry.TotalRequests}");
        }
    }
}