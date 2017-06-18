using System.Configuration;

namespace MonoRailThrottle.Configuration
{
    public class ThrottlePolicyRuleConfigurationCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ThrottlePolicyRuleConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ThrottlePolicyRuleConfigurationElement)element).Entry;
        }
    }
}