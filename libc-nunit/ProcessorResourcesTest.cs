using System;

using RL.Gnu;
using NUnit;
using NUnit.Framework;

namespace libc_nunit
{
    [TestFixture]
    public class ProcessorResourcesTest
    {
        [Test]
        public void TestCLikeGetNumberOfProcessors()
        {
            var processors = libc.get_nprocs();
            Assert.GreaterOrEqual(processors, 1);
        }

        [Test]
        public void TestDotNetLikeGetNumberOfProcessors()
        {
            var processors = libc.GetNumberOfProcessors();
            Assert.GreaterOrEqual(processors, 1);
        }

        [Test]
        public void TestCLikeGetNumberOfProcessorsConfigured()
        {
            var processorsConfigured = libc.get_nprocs_conf();
            Assert.GreaterOrEqual(processorsConfigured, 1);
        }

        [Test]
        public void TestDotNetLikeGetNumberOfProcessorsConfigured()
        {
            var processorsConfigured = libc.GetNumberOfProcessorsConfigured();
            Assert.GreaterOrEqual(processorsConfigured, 1);
        }

        [Test]
        public void TestCLike()
        {
            double[] loadavg;
            var samples = libc.getloadavg(out loadavg, 3);
            Assert.AreEqual(3, samples);
            Assert.AreEqual(3, loadavg.Length);
            Assert.GreaterOrEqual(loadavg[0], 0);
            Assert.GreaterOrEqual(loadavg[1], 0);
            Assert.GreaterOrEqual(loadavg[2], 0);
        }

        [Test]
        public void TestCLikeWithDefault()
        {
            double[] loadavg;
            var samples = libc.getloadavg(out loadavg);
            Assert.AreEqual(3, samples);
            Assert.AreEqual(3, loadavg.Length);
            Assert.GreaterOrEqual(loadavg[0], 0);
            Assert.GreaterOrEqual(loadavg[1], 0);
            Assert.GreaterOrEqual(loadavg[2], 0);
        }

        [Test]
        public void TestCLikeWith1Element()
        {
            double[] loadavg;
            var samples = libc.getloadavg(out loadavg, 1);
            Assert.AreEqual(1, samples);
            Assert.AreEqual(1, loadavg.Length);
            Assert.GreaterOrEqual(loadavg[0], 0);
        }

        [Test]
        public void TestDotNetLike()
        {
            var loadavg = libc.GetLoadAverages(3);
            Assert.AreEqual(3, loadavg.Length);
            Assert.GreaterOrEqual(loadavg[0], 0);
            Assert.GreaterOrEqual(loadavg[1], 0);
            Assert.GreaterOrEqual(loadavg[2], 0);
        }

        [Test]
        public void TestDotNetLikeWithDefault()
        {
            var loadavg = libc.GetLoadAverages();
            Assert.AreEqual(3, loadavg.Length);
            Assert.GreaterOrEqual(loadavg[0], 0);
            Assert.GreaterOrEqual(loadavg[1], 0);
            Assert.GreaterOrEqual(loadavg[2], 0);
        }

        [Test]
        public void TestDotNetLikeWith1Element()
        {
            var loadavg = libc.GetLoadAverages(1);
            Assert.AreEqual(1, loadavg.Length);
            Assert.GreaterOrEqual(loadavg[0], 0);
        }

        [Test]
        public void TestWithLast1Minute()
        {
            double last1Minute;
            libc.getloadavg(out last1Minute);
            Assert.GreaterOrEqual(last1Minute, 0);
        }

        [Test]
        public void TestWithLast5Minutes()
        {
            double last1Minute, last5Minutes;
            libc.getloadavg(out last1Minute, out last5Minutes);
            Assert.GreaterOrEqual(last1Minute, 0);
            Assert.GreaterOrEqual(last5Minutes, 0);
        }

        [Test]
        public void TestWithLast15Minutes()
        {
            double last1Minute, last5Minutes, last15Minutes;
            libc.getloadavg(out last1Minute, out last5Minutes, out last15Minutes);
            Assert.GreaterOrEqual(last1Minute, 0);
            Assert.GreaterOrEqual(last5Minutes, 0);
            Assert.GreaterOrEqual(last15Minutes, 0);
        }

        [Test]
        public void TestOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                double[] loadavg;
                var samples = libc.getloadavg(out loadavg, 0);
            });
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                double[] loadavg;
                var samples = libc.getloadavg(out loadavg, 4);
            });
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                libc.GetLoadAverages(0);
            });
            Assert.Throws<ArgumentOutOfRangeException>(() => {
                libc.GetLoadAverages(4);
            });
        }
    }
}
