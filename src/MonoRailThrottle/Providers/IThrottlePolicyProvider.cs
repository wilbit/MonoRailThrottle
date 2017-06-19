﻿using System.Collections.Generic;
using MonoRailThrottle.Models;

namespace MonoRailThrottle.Providers
{
    /// <summary>
    /// Implement this interface if you want to load the policy rules from a persistent store
    /// </summary>
    public interface IThrottlePolicyProvider
    {
        ThrottlePolicySettings ReadSettings();
        IEnumerable<ThrottlePolicyRule> AllRules();
        IEnumerable<ThrottlePolicyWhitelist> AllWhitelists();
    }
}