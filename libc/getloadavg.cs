using System;
using System.Runtime.InteropServices;

namespace RL.Gnu
{
    /// <summary>
    /// This is a wrapper-class for several libc functions.
    /// </summary>
    public class libc
    {
        /// <summary>
        /// The getloadavg() function returns the number of processes in the system run queue averaged over various periods of time.
        /// Up to nelem samples are retrieved and assigned to successive elements of loadavg[].
        /// The system imposes a maximum of 3 samples, representing averages over the last 1, 5, and 15 minutes, respectively.
        /// </summary>
        /// <param name="loadavg">a double array where to write the data.</param>
        /// <param name="nelem">how many elements to write (up to 3).</param>
        /// <returns>If the load average was unobtainable, -1 is returned; otherwise, the number of samples actually retrieved is returned.</returns>
        public static int getloadavg(out double[] loadavg, int nelem = 3)
        {
            if (nelem < 1 || nelem > 3) {
                throw new ArgumentOutOfRangeException("nelem", nelem, "\"nelem\" must be between 1 and 3!");
            }
            loadavg = new double[nelem];
            return getloadavg(loadavg, nelem);
        }

        /// <summary>
        /// The getloadavg() function assigns the load average of the last minute.
        /// </summary>
        /// <param name="last1Minute">writes out the load average of the last minute.</param>
        public static void getloadavg(out double last1Minute)
        {
            var loadavg = new double[1];
            var samples = getloadavg(loadavg, 1);
            if (samples == -1) {
                throw new Exception("the load average is unobtainable!");
            }
            
            last1Minute = loadavg[0];
        }

        /// <summary>
        /// The getloadavg() function assigns the load average of the last and the last 5 minutes.
        /// </summary>
        /// <param name="last1Minute">writes out the load average of the last minute.</param>
        /// <param name="last5Minutes">writes out the load average of the last 5 minutes.</param>
        public static void getloadavg(out double last1Minute, out double last5Minutes)
        {
            var loadavg = new double[2];
            var samples = getloadavg(loadavg, 2);
            if (samples == -1) {
                throw new Exception("the load average is unobtainable!");
            }
            
            last1Minute = loadavg[0];
            last5Minutes = loadavg[1];
        }

        /// <summary>
        /// The getloadavg() function assigns the load average of the last, the last 5 and the last 15 minutes.
        /// </summary>
        /// <param name="last1Minute">writes out the load average of the last minute.</param>
        /// <param name="last5Minutes">writes out the load average of the last 5 minutes.</param>
        /// <param name="last15Minutes">writes out the load average of the last 15 minutes.</param>
        public static void getloadavg(out double last1Minute, out double last5Minutes, out double last15Minutes)
        {
            var loadavg = new double[3];
            var samples = getloadavg(loadavg, 3);
            if (samples == -1) {
                throw new Exception("the load average is unobtainable!");
            }
            
            last1Minute = loadavg[0];
            last5Minutes = loadavg[1];
            last15Minutes = loadavg[2];
        }

        /// <summary>
        /// The GetLoadAverages() function returns a double array of processes in the system run queue averaged over various periods of time.
        /// Up to nelem samples are retrieved and returned as a double array.
        /// The system imposes a maximum of 3 samples, representing averages over the last 1, 5, and 15 minutes, respectively.
        /// </summary>
        /// <param name="nelem">how many elements to write (up to 3).</param>
        /// <returns>a double array with the load averages.</returns>
        public static double[] GetLoadAverages(int nelem = 3)
        {
            if (nelem < 1 || nelem > 3) {
                throw new ArgumentOutOfRangeException("nelem", nelem, "\"nelem\" must be between 1 and 3!");
            }
            var loadavg = new double[nelem];
            var samples = getloadavg(loadavg, nelem);
            if (samples == -1) {
                throw new Exception("the load average is unobtainable!");
            }
            return loadavg;
        }

        [DllImport("libc.so.6")]
        private static extern int getloadavg(double[] loadavg, int nelem);
    }
}
