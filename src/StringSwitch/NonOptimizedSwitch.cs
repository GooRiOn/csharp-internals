using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using System;

namespace StringSwitch
{
    [CoreJob]
    [AsciiDocExporter, HtmlExporter]
    public class NonOptimizedSwitch
    {
        [Params("Case1", "Case2", "Case3", "Case4", "Case5", "Case6")]
        public string Argument { get; set; }

        [Benchmark]
        public void Run()
        {
            switch (Argument)
            {
                case "Case1":
                    break;
                case "Case2":
                    break;
                case "Case3":
                    break;
                case "Case4":
                    break;
                case "Case5":
                    break;
                case "Case6":
                    break;
            }
        }
    }
}
