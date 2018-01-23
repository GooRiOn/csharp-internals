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
|    **Run** |    **Case1** |  **2.328 ns** | **0.0397 ns** | **0.0352 ns** |
|    **Run** |    **Case2** |  **9.755 ns** | **0.1253 ns** | **0.1046 ns** |
|    **Run** |    **Case3** | **16.828 ns** | **0.1889 ns** | **0.1674 ns** |
|    Run |    Case3 | 16.666 ns | 0.0546 ns | 0.0484 ns |
|    **Run** |    **Case4** | **23.998 ns** | **0.2328 ns** | **0.2178 ns** |
|    **Run** |    **Case5** | **31.976 ns** | **0.6534 ns** | **0.6710 ns** |
|    **Run** |    **Case6** | **38.198 ns** | **0.1952 ns** | **0.1826 ns** |
