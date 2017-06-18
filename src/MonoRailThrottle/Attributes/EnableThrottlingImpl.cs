using Castle.MonoRail.Framework;

namespace MonoRailThrottle.Attributes
{
    public sealed class EnableThrottlingImpl : IFilter, IFilterAttributeAware
    {
        private EnableThrottlingAttribute _filter;

        public FilterAttribute Filter
        {
            set { _filter = (EnableThrottlingAttribute) value; }
        }

        public bool Perform(ExecuteWhen exec, IEngineContext context, IController controller, IControllerContext controllerContext)
        {
            //TODO implement it
            return true;
        }
    }
}