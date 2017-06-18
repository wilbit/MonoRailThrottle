using Castle.MonoRail.Framework;

namespace MonoRailThrottle.Attributes
{
    internal sealed class EnableThrottlingFromConfigurationImpl : IFilter, IFilterAttributeAware
    {
        private EnableThrottlingFromConfigurationAttribute _filter;

        public FilterAttribute Filter
        {
            set { _filter = (EnableThrottlingFromConfigurationAttribute) value; }
        }

        public bool Perform(ExecuteWhen exec, IEngineContext context, IController controller, IControllerContext controllerContext)
        {
            throw new System.NotImplementedException();
        }
    }
}