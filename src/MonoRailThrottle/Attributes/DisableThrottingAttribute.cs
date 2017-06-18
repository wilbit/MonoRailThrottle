using Castle.MonoRail.Framework;

namespace MonoRailThrottle.Attributes
{
    //INFO в оригинале считывается рефлексией, но можно поробовать просто использовать SkipFilterAttribute правильно настроенный
    public class DisableThrottingAttribute : SkipFilterAttribute //ActionFilterAttribute, IActionFilter
    {
        //TODO add type of attribute
    }
}