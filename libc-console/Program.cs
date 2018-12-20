using System;

using RL.Gnu;

namespace libc_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // there are different ways to retrieve the load averages.
			// 1. the classical c-way.
			double[] loadavg;
            var samples = libc.getloadavg(out loadavg, 3);
			if (samples != -1) {
				Console.WriteLine("load: {0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);
			}

			// 2. the dotnet-like-way.
			loadavg = libc.GetLoadAverages();
			Console.WriteLine("load: {0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);

			var pageSize = libc.GetPageSize();
			Console.WriteLine("pagesize: {0}", pageSize);

			var physPages = libc.GetPhysicalPages();
			Console.WriteLine("phys_pages: {0}", physPages);

			var memory = pageSize * physPages / 1024 / 1024;
			Console.WriteLine("memory: {0}MB", memory);
        }
    }
}
