# RL.Gnu.LibC Wrapper

[![License: CC0](https://img.shields.io/github/license/ringostarr80/RL.Gnu.svg)](https://creativecommons.org/publicdomain/zero/1.0/legalcode)
![Workflow: CodeQL](https://img.shields.io/github/actions/workflow/status/ringostarr80/RL.Gnu/codeql-analysis.yml?branch=main)
![NuGet](https://img.shields.io/nuget/v/RL.Gnu.LibC)
![Version](https://img.shields.io/github/v/tag/ringostarr80/RL.Gnu?sort=semver)
[![codecov](https://codecov.io/gh/ringostarr80/RL.Gnu/branch/main/graph/badge.svg?token=31AGL12HSR)](https://codecov.io/gh/ringostarr80/RL.Gnu)

## Intention
This currently very small project was made to wrap some Gnu libc functions to the dotnet-world.
This library doesn't work on Windows.

## Build and publish nupkg file

```sh
dotnet pack --configuration=Release
dotnet nuget push bin/Release/RL.Gnu.LibC.<version>.nupkg --api-key=<api-key>
```

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
            var samples = LibC.getloadavg(out loadavg, 3);
            if (samples != -1) {
                Console.WriteLine("{0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);
            }

            // 2. the dotnet-like-way.
            loadavg = LibC.GetLoadAverages();
            Console.WriteLine("{0} {1} {2}", loadavg[0], loadavg[1], loadavg[2]);
        }
    }
}
```
