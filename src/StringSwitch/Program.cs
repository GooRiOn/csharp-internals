using BenchmarkDotNet.Running;
using System;

namespace StringSwitch
{
    class Program
    {
        static void Main()
        {
            var optimizedSwitchSummary = BenchmarkRunner.Run<OptimizedSwitch>();
            var nonOptimizedSwitchSummary = BenchmarkRunner.Run<NonOptimizedSwitch>();
            var elseIfSummary = BenchmarkRunner.Run<ElseIf>();

            Console.ReadLine();
        }
    }
}
