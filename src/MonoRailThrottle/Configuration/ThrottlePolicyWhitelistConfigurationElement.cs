using System.Configuration;

namespace MonoRailThrottle.Configuration
{
    public class ThrottlePolicyWhitelistConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("entry", IsRequired = true)]
        public string Entry => this["entry"] as string;

        [ConfigurationProperty("policyType", IsRequired = true)]
        public int PolicyType => (int)this["policyType"];
    }
}