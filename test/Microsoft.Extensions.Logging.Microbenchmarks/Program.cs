﻿using System.Reflection;
using BenchmarkDotNet.Running;

namespace Microsoft.Extensions.Logging.Microbenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
        }
    }
}