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
            Assert.That(processors, Is.GreaterThanOrEqualTo(1));
        }

        [Test]
        public void TestDotNetLikeGetNumberOfProcessors()
        {
            var processors = LibC.GetNumberOfProcessors();
            Assert.That(processors, Is.GreaterThanOrEqualTo(1));
        }

        [Test]
        public void TestCLikeGetNumberOfProcessorsConfigured()
        {
            var processorsConfigured = LibC.get_nprocs_conf();
            Assert.That(processorsConfigured, Is.GreaterThanOrEqualTo(1));
        }

        [Test]
        public void TestDotNetLikeGetNumberOfProcessorsConfigured()
        {
            var processorsConfigured = LibC.GetNumberOfProcessorsConfigured();
            Assert.That(processorsConfigured, Is.GreaterThanOrEqualTo(1));
        }

        [Test]
        public void TestCLike()
        {
            var samples = LibC.getloadavg(out double[] loadavg, 3);
            Assert.That(samples, Is.EqualTo(3));
            Assert.That(loadavg.Length, Is.EqualTo(3));
            Assert.That(loadavg[0], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[1], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[2], Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestCLikeWithDefault()
        {
            var samples = LibC.getloadavg(out double[] loadavg);
            Assert.That(samples, Is.EqualTo(3));
            Assert.That(loadavg.Length, Is.EqualTo(3));
            Assert.That(loadavg[0], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[1], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[2], Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestCLikeWith1Element()
        {
            var samples = LibC.getloadavg(out double[] loadavg, 1);
            Assert.That(samples, Is.EqualTo(1));
            Assert.That(loadavg.Length, Is.EqualTo(1));
            Assert.That(loadavg[0], Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestDotNetLike()
        {
            var loadavg = LibC.GetLoadAverages(3);
            Assert.That(loadavg.Length, Is.EqualTo(3));
            Assert.That(loadavg[0], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[1], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[2], Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestDotNetLikeWithDefault()
        {
            var loadavg = LibC.GetLoadAverages();
            Assert.That(loadavg.Length, Is.EqualTo(3));
            Assert.That(loadavg[0], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[1], Is.GreaterThanOrEqualTo(0));
            Assert.That(loadavg[2], Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestDotNetLikeWith1Element()
        {
            var loadavg = LibC.GetLoadAverages(1);
            Assert.That(loadavg.Length, Is.EqualTo(1));
            Assert.That(loadavg[0], Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestWithLast1Minute()
        {
            LibC.GetLoadAverages(out double last1Minute);
            Assert.That(last1Minute, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestWithLast5Minutes()
        {
            LibC.GetLoadAverages(out double last1Minute, out double last5Minutes);
            Assert.That(last1Minute, Is.GreaterThanOrEqualTo(0));
            Assert.That(last5Minutes, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestWithLast15Minutes()
        {
            LibC.GetLoadAverages(out double last1Minute, out double last5Minutes, out double last15Minutes);
            Assert.That(last1Minute, Is.GreaterThanOrEqualTo(0));
            Assert.That(last5Minutes, Is.GreaterThanOrEqualTo(0));
            Assert.That(last15Minutes, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void TestOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>((Action)(() => {
                var samples = LibC.getloadavg(out double[] loadavg, 0);
            }));
            Assert.Throws<ArgumentOutOfRangeException>((Action)(() => {
                var samples = LibC.getloadavg(out double[] loadavg, 4);
            }));
            Assert.Throws<ArgumentOutOfRangeException>((Action)(() => {
                LibC.GetLoadAverages(0);
            }));
            Assert.Throws<ArgumentOutOfRangeException>((Action)(() => {
                LibC.GetLoadAverages(4);
            }));
        }
    }
}
