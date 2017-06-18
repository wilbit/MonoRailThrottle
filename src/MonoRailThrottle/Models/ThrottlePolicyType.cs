namespace MonoRailThrottle.Models
{
    public enum ThrottlePolicyType : int
    {
        IpThrottling = 1,
        ClientThrottling,
        EndpointThrottling
    }
}