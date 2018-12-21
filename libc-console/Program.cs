using System;
using System.IO;

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

			File.WriteAllText("foo.txt", "foo content");
			libc.SymbolicLink("foo.txt", "bar.txt");
			var canonicalizedFilename = libc.CanonicalizeFileName("bar.txt");
			Console.WriteLine("canonicalize_file_name of 'bar.txt' => '" + canonicalizedFilename + "'");

			var link = libc.ReadLink("bar.txt");
			Console.WriteLine("readlink(bar.txt) => '" + link + "'");

			var realPath = libc.RealPath("bar.txt");
			Console.WriteLine("realpath of 'bar.txt' => '" + realPath + "'");

			string resolved;
			libc.realpath("bar.txt", out resolved);
			Console.WriteLine("realpath2 of 'bar.txt' => resolved: '" + resolved + "'");

			File.Delete("bar.txt");
			File.Delete("foo.txt");
		}
    }
}
