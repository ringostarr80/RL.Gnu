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
            var pid = libc.getpid();
			Assert.That(pid > 1);
        }

		[Test]
        public void TestDotNetLikeGetPid()
        {
            var pid = libc.GetPid();
			Assert.That(pid > 1);
        }

        [Test]
        public void TestCLikeGetPPid()
        {
            var ppid = libc.getppid();
            Assert.That(ppid > 1);
        }

		[Test]
        public void TestDotNetLikeGetPPid()
        {
            var ppid = libc.GetPPid();
            Assert.That(ppid > 1);
        }
    }
}
