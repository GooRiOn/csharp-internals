``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 1 [1607, Anniversary Update] (10.0.14393.2007)
Intel Core i7-3615QM CPU 2.30GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2241008 Hz, Resolution=446.2278 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host] : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT  [AttachedDebugger]
  Core   : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT

Job=Core  Runtime=Core  

```
| Method | Argument |      Mean |     Error |    StdDev |    Median |
|------- |--------- |----------:|----------:|----------:|----------:|
|    **Run** |    **Case1** |  **9.652 ns** | **0.1195 ns** | **0.1118 ns** |  **9.605 ns** |
|    **Run** |    **Case2** |  **9.870 ns** | **0.2345 ns** | **0.3982 ns** |  **9.668 ns** |
|    **Run** |    **Case3** |  **9.331 ns** | **0.0959 ns** | **0.0897 ns** |  **9.314 ns** |
|    Run |    Case3 |  9.344 ns | 0.1541 ns | 0.1442 ns |  9.259 ns |
|    **Run** |    **Case4** | **10.204 ns** | **0.1149 ns** | **0.1075 ns** | **10.176 ns** |
|    **Run** |    **Case5** | **10.200 ns** | **0.0438 ns** | **0.0410 ns** | **10.209 ns** |
|    **Run** |    **Case6** | **10.956 ns** | **0.2539 ns** | **0.2251 ns** | **10.844 ns** |
