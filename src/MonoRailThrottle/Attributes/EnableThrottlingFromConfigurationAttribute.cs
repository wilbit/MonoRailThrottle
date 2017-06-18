using Castle.MonoRail.Framework;

namespace MonoRailThrottle.Attributes
{
    public sealed class EnableThrottlingFromConfigurationAttribute : FilterAttribute
    {
        public EnableThrottlingFromConfigurationAttribute(ExecuteWhen when)
            : base(when, typeof(EnableThrottlingFromConfigurationImpl))
        {
        }
    }
}