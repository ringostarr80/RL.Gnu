﻿using System;
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
            var samples = LibC.getloadavg(out loadavg, 3);
			if (samples != -1) {
				Console.WriteLine("load: {0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);
			}

			// 2. the dotnet-like-way.
			loadavg = LibC.GetLoadAverages();
			Console.WriteLine("load: {0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);

			var pageSize = LibC.GetPageSize();
			Console.WriteLine("pagesize: {0}", pageSize);

			var physPages = LibC.GetPhysicalPages();
			Console.WriteLine("phys_pages: {0}", physPages);

			var memory = pageSize * physPages / 1024 / 1024;
			Console.WriteLine("memory: {0}MB", memory);

			File.WriteAllText("foo.txt", "foo content");
			LibC.SymbolicLink("foo.txt", "bar.txt");
			var canonicalizedFilename = LibC.CanonicalizeFileName("bar.txt");
			Console.WriteLine("canonicalize_file_name of 'bar.txt' => '" + canonicalizedFilename + "'");

			var link = LibC.ReadLink("bar.txt");
			Console.WriteLine("readlink(bar.txt) => '" + link + "'");

			var realPath = LibC.RealPath("bar.txt");
			Console.WriteLine("realpath of 'bar.txt' => '" + realPath + "'");

			File.Delete("bar.txt");
			File.Delete("foo.txt");
		}
    }
}
