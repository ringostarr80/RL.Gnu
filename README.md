# RL.Gnu.libc Wrapper

[![License: CC0](https://img.shields.io/github/license/ringostarr80/RL.Gnu.svg)](https://creativecommons.org/publicdomain/zero/1.0/legalcode)
![NuGet](https://img.shields.io/nuget/v/RL.Gnu.libc)
![Version](https://img.shields.io/github/v/tag/ringostarr80/RL.Gnu?sort=semver)
![Workflow: CodeQL](https://img.shields.io/github/workflow/status/ringostarr80/RL.Gnu/CodeQL)

## Intention
This currently very small project was made to wrap some Gnu libc functions to the dotnet-world.
This library doesn't work on Windows.

## Usage
to get the load averages:

```C#
using System;
using RL.Gnu;

namespace Console
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
                Console.WriteLine("{0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);
            }

            // 2. the dotnet-like-way.
            loadavg = libc.GetLoadAverages();
            Console.WriteLine("{0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);
        }
    }
}
```
