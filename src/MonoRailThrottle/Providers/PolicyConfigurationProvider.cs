using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using MonoRailThrottle.Configuration;
using MonoRailThrottle.Models;

namespace MonoRailThrottle.Providers
{
    public class PolicyConfigurationProvider : IThrottlePolicyProvider
    {
        private readonly ThrottlePolicyConfiguration _policyConfig;

        public PolicyConfigurationProvider()
        {
            _policyConfig = ConfigurationManager.GetSection("throttlePolicy") as ThrottlePolicyConfiguration;
        }

        public ThrottlePolicySettings ReadSettings()
        {
            var settings = new ThrottlePolicySettings()
            {
                IpThrottling = _policyConfig.IpThrottling,
                ClientThrottling = _policyConfig.ClientThrottling,
                EndpointThrottling = _policyConfig.EndpointThrottling,
                StackBlockedRequests = _policyConfig.StackBlockedRequests,
                LimitPerSecond = _policyConfig.LimitPerSecond,
                LimitPerMinute = _policyConfig.LimitPerMinute,
                LimitPerHour = _policyConfig.LimitPerHour,
                LimitPerDay = _policyConfig.LimitPerDay,
                LimitPerWeek = _policyConfig.LimitPerWeek
            };

            return settings;
        }

        public IEnumerable<ThrottlePolicyRule> AllRules()
        {
            if (_policyConfig.Rules == null)
            {
                return Enumerable.Empty<ThrottlePolicyRule>();
            }

            var rules = new List<ThrottlePolicyRule>();
            foreach (ThrottlePolicyRuleConfigurationElement rule in _policyConfig.Rules)
            {
                rules.Add(new ThrottlePolicyRule
                {
                    Entry = rule.Entry,
                    PolicyType = (ThrottlePolicyType)rule.PolicyType,
                    LimitPerSecond = rule.LimitPerSecond,
                    LimitPerMinute = rule.LimitPerMinute,
                    LimitPerHour = rule.LimitPerHour,
                    LimitPerDay = rule.LimitPerDay,
                    LimitPerWeek = rule.LimitPerWeek
                });
            }

            return rules;
        }

        public IEnumerable<ThrottlePolicyWhitelist> AllWhitelists()
        {
            if (_policyConfig.Whitelists == null)
            {
                return Enumerable.Empty<ThrottlePolicyWhitelist>();
            }

            var whitelists = new List<ThrottlePolicyWhitelist>();
            foreach (ThrottlePolicyWhitelistConfigurationElement whitelist in _policyConfig.Whitelists)
            {
                whitelists.Add(new ThrottlePolicyWhitelist
                {
                    Entry = whitelist.Entry,
                    PolicyType = (ThrottlePolicyType)whitelist.PolicyType,
                });
            }

            return whitelists;
        }
    }
}