using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using System;

namespace StringSwitch
{
    [CoreJob]
    [AsciiDocExporter, HtmlExporter]
    public class ElseIf
    {
        [Params("Case1", "Case2", "Case3", "Case4", "Case5", "Case6")]
        public string Argument { get; set; }

        [Benchmark]
        public void Run()
        {
            if(Argument == "Case1")
            {
            }
            else if(Argument == "Case2")
            {
            }
            else if (Argument == "Case3")
            {
            }
            else if (Argument == "Case4")
            {
            }
            else if (Argument == "Case5")
            {
            }
            else if (Argument == "Case6")
            {
            }
            else if (Argument == "Case7")
            {
            }
        }
    }
}
