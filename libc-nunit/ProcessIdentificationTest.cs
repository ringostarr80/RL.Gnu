using RL.Gnu;
using NUnit.Framework;

namespace libc_nunit
{
    [TestFixture]
    public class ProcessIdentificationTest
    {
		[Test]
        public void TestCLikeGetPid()
        {
            var pid = LibC.getpid();
			Assert.That(pid > 1);
        }

		[Test]
        public void TestDotNetLikeGetPid()
        {
            var pid = LibC.GetPid();
			Assert.That(pid > 1);
        }

        [Test]
        public void TestCLikeGetPPid()
        {
            var ppid = LibC.getppid();
            Assert.That(ppid > 1);
        }

		[Test]
        public void TestDotNetLikeGetPPid()
        {
            var ppid = LibC.GetPPid();
            Assert.That(ppid > 1);
        }
    }
}
