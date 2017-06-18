using MonoRailThrottle.Net;
using NUnit.Framework;

namespace MonoRailThrottle.Tests
{
    [TestFixture]
    public class IpAddressUtilTests
    {
        [Test]
        public void IsPrivateIpAddress_PrivateAddress_ReturnsTrue()
        {
            bool result = IpAddressUtil.IsPrivateIpAddress("10.0.0.1");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPrivateIpAddress_PublicAddress_ReturnsFalse()
        {
            bool result = IpAddressUtil.IsPrivateIpAddress("8.8.8.8");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPrivateIpAddress_PublicAddressIpv6_ReturnsFalse()
        {
            bool result = IpAddressUtil.IsPrivateIpAddress("2001:4860:4860::8888");

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPrivateIpAddress_PrivateAddressIpv6_ReturnsFalse()
        {
            bool result = IpAddressUtil.IsPrivateIpAddress("fd74:20cf:81a2::");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPrivateIpAddress_PrivateAddressWithPort_ReturnsTrue()
        {
            bool result = IpAddressUtil.IsPrivateIpAddress("10.0.0.1:5555");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPrivateIpAddress_PrivateAddressIpv6WithPort_ReturnsTrue()
        {
            bool result = IpAddressUtil.IsPrivateIpAddress("[fd74:20cf:81a2::]:5555");

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPrivateIpAddress_PublicIpAddressWithInitialSpace_ReturnsFalse()
        {
            bool result = IpAddressUtil.IsPrivateIpAddress(" 8.8.8.8");

            Assert.That(result, Is.False);
        }
    }
}