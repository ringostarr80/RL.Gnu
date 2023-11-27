using System;

using RL.Gnu;
using NUnit.Framework;

namespace libc_nunit
{
    [TestFixture]
    public class ProcessorResourcesTest
    {
        [Test]
        public void TestCLikeGetNumberOfProcessors()
        {
            var processors = LibC.get_nprocs();
            Assert.That(processors >= 1);
        }

        [Test]
        public void TestDotNetLikeGetNumberOfProcessors()
        {
            var processors = LibC.GetNumberOfProcessors();
            Assert.That(processors >= 1);
        }

        [Test]
        public void TestCLikeGetNumberOfProcessorsConfigured()
        {
            var processorsConfigured = LibC.get_nprocs_conf();
            Assert.That(processorsConfigured >= 1);
        }

        [Test]
        public void TestDotNetLikeGetNumberOfProcessorsConfigured()
        {
            var processorsConfigured = LibC.GetNumberOfProcessorsConfigured();
            Assert.That(processorsConfigured >= 1);
        }

        [Test]
        public void TestCLike()
        {
            double[] loadavg;
            var samples = LibC.getloadavg(out loadavg, 3);
            Assert.That(3 == samples);
            Assert.That(3 == loadavg.Length);
            Assert.That(loadavg[0] >= 0);
            Assert.That(loadavg[1] >= 0);
            Assert.That(loadavg[2] >= 0);
        }

        [Test]
        public void TestCLikeWithDefault()
        {
            double[] loadavg;
            var samples = LibC.getloadavg(out loadavg);
            Assert.That(3 == samples);
            Assert.That(3 == loadavg.Length);
            Assert.That(loadavg[0] >= 0);
            Assert.That(loadavg[1] >= 0);
            Assert.That(loadavg[2] >= 0);
        }

        [Test]
        public void TestCLikeWith1Element()
        {
            double[] loadavg;
            var samples = LibC.getloadavg(out loadavg, 1);
            Assert.That(1 == samples);
            Assert.That(1 == loadavg.Length);
            Assert.That(loadavg[0] >= 0);
        }

        [Test]
        public void TestDotNetLike()
        {
            var loadavg = LibC.GetLoadAverages(3);
            Assert.That(3 == loadavg.Length);
            Assert.That(loadavg[0] >= 0);
            Assert.That(loadavg[1] >= 0);
            Assert.That(loadavg[2] >= 0);
        }

        [Test]
        public void TestDotNetLikeWithDefault()
        {
            var loadavg = LibC.GetLoadAverages();
            Assert.That(3 == loadavg.Length);
            Assert.That(loadavg[0] >= 0);
            Assert.That(loadavg[1] >= 0);
            Assert.That(loadavg[2] >= 0);
        }

        [Test]
        public void TestDotNetLikeWith1Element()
        {
            var loadavg = LibC.GetLoadAverages(1);
            Assert.That(1 == loadavg.Length);
            Assert.That(loadavg[0] >= 0);
        }

        [Test]
        public void TestWithLast1Minute()
        {
            double last1Minute;
            LibC.GetLoadAverages(out last1Minute);
            Assert.That(last1Minute >= 0);
        }

        [Test]
        public void TestWithLast5Minutes()
        {
            double last1Minute, last5Minutes;
            LibC.GetLoadAverages(out last1Minute, out last5Minutes);
            Assert.That(last1Minute >= 0);
            Assert.That(last5Minutes >= 0);
        }

        [Test]
        public void TestWithLast15Minutes()
        {
            double last1Minute, last5Minutes, last15Minutes;
            LibC.GetLoadAverages(out last1Minute, out last5Minutes, out last15Minutes);
            Assert.That(last1Minute >= 0);
            Assert.That(last5Minutes >= 0);
            Assert.That(last15Minutes >= 0);
        }

        [Test]
        public void TestOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                double[] loadavg;
                var samples = LibC.getloadavg(out loadavg, 0);
            });
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                double[] loadavg;
                var samples = LibC.getloadavg(out loadavg, 4);
            });
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                LibC.GetLoadAverages(0);
            });
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                LibC.GetLoadAverages(4);
            });
        }
    }
}
