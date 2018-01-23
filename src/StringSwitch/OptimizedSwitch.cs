using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using System;

namespace StringSwitch
{
    [CoreJob]
    [AsciiDocExporter, HtmlExporter]
    public class OptimizedSwitch
    {
        [Params("Case1", "Case2", "Case3", "Case4", "Case5", "Case6")]
        public string Argument { get; set; }

        [Benchmark]
        public void Run()
        {
            switch (Argument)
            {
                case "Case1":
                    //Console.WriteLine("Case1");
                    break;
                case "Case2":
                    //Console.WriteLine("Case2");
                    break;
                case "Case3":
                    //Console.WriteLine("Case3");
                    break;
                case "Case4":
                    //Console.WriteLine("Case4");
                    break;
                case "Case5":
                    //Console.WriteLine("Case5");
                    break;
                case "Case6":
                    //Console.WriteLine("Case6");
                    break;
                case "Case7":
                    //Console.WriteLine("Case7");
                    break;
            }
        }
    }
}
