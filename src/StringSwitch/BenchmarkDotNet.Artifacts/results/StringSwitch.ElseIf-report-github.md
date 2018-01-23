``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 1 [1607, Anniversary Update] (10.0.14393.2007)
Intel Core i7-3615QM CPU 2.30GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2241008 Hz, Resolution=446.2278 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host] : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT  [AttachedDebugger]
  Core   : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT

Job=Core  Runtime=Core  

```
| Method | Argument |      Mean |     Error |    StdDev |
|------- |--------- |----------:|----------:|----------:|
|    **Run** |    **Case1** |  **2.311 ns** | **0.0188 ns** | **0.0175 ns** |
|    **Run** |    **Case2** |  **9.780 ns** | **0.0826 ns** | **0.0773 ns** |
|    **Run** |    **Case3** | **17.242 ns** | **0.1075 ns** | **0.1005 ns** |
|    Run |    Case3 | 17.129 ns | 0.0910 ns | 0.0807 ns |
|    **Run** |    **Case4** | **24.797 ns** | **0.3970 ns** | **0.3714 ns** |
|    **Run** |    **Case5** | **32.053 ns** | **0.2374 ns** | **0.2221 ns** |
|    **Run** |    **Case6** | **39.042 ns** | **0.4609 ns** | **0.4311 ns** |
