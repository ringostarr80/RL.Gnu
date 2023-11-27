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
            var pagesize = LibC.getpagesize();
            Assert.That(pagesize, Is.GreaterThan(128));
        }

        [Test]
        public void TestDotNetLikeGetPageSize()
        {
            var pagesize = LibC.GetPageSize();
			Assert.That(pagesize, Is.GreaterThan(128));
        }

        [Test]
        public void TestCLikeGetPhysPages()
        {
            var physPages = LibC.get_phys_pages();
			Assert.That(physPages, Is.GreaterThan(128));
        }

        [Test]
        public void TestDotNetLikeGetPhysPages()
        {
            var physPages = LibC.GetPhysicalPages();
			Assert.That(physPages, Is.GreaterThan(128));
        }

         [Test]
        public void TestCLikeGetAvPhysPages()
        {
            var physPages = LibC.get_avphys_pages();
			Assert.That(physPages, Is.GreaterThan(128));
        }

        [Test]
        public void TestDotNetLikeGetAvPhysPages()
        {
            var physPages = LibC.GetAvailablePhysicalPages();
			Assert.That(physPages, Is.GreaterThan(128));
        }
    }
}
