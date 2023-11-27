using RL.Gnu;
using NUnit.Framework;

namespace libc_nunit
{
    [TestFixture]
    public class MemorySubsystemTest
    {
		[Test]
        public void TestCLikeGetPageSize()
        {
            var pagesize = libc.getpagesize();
			Assert.That(pagesize > 128);
        }

        [Test]
        public void TestDotNetLikeGetPageSize()
        {
            var pagesize = libc.GetPageSize();
			Assert.That(pagesize > 128);
        }

        [Test]
        public void TestCLikeGetPhysPages()
        {
            var physPages = libc.get_phys_pages();
			Assert.That(physPages > 128);
        }

        [Test]
        public void TestDotNetLikeGetPhysPages()
        {
            var physPages = libc.GetPhysicalPages();
			Assert.That(physPages > 128);
        }

         [Test]
        public void TestCLikeGetAvPhysPages()
        {
            var physPages = libc.get_avphys_pages();
			Assert.That(physPages > 128);
        }

        [Test]
        public void TestDotNetLikeGetAvPhysPages()
        {
            var physPages = libc.GetAvailablePhysicalPages();
			Assert.That(physPages > 128);
        }
    }
}
