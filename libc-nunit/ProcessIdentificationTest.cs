using System;

using RL.Gnu;
using NUnit;
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
			Assert.Greater(pid, 1);
        }

		[Test]
        public void TestDotNetLikeGetPid()
        {
            var pid = libc.GetPid();
			Assert.Greater(pid, 1);
        }

        [Test]
        public void TestCLikeGetPPid()
        {
            var ppid = libc.getppid();
            Assert.Greater(ppid, 1);
        }

		[Test]
        public void TestDotNetLikeGetPPid()
        {
            var ppid = libc.GetPPid();
            Assert.Greater(ppid, 1);
        }
    }
}
